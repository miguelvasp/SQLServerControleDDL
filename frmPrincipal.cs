using SQLServerControlVersion.Models;
using SQLServerControlVersion.Repository;
using System.Data;

namespace SQLServerControlVersion
{
    public partial class frmPrincipal : Form
    {
        public List<Conexao> ConexoesCadastradas = new List<Conexao>();
        public string ConnectionList { get; set; }
        public string ConnectionString { get; set; }

        private List<TraceObject> lista;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ConnectionList = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "cnn.tcn");

            if (!File.Exists(ConnectionList))
            {
                File.Create(ConnectionList).Dispose();
            }
            else
            {
                var conexoes = File.ReadAllLines(ConnectionList);
                foreach (string cnn in conexoes)
                {
                    if (!string.IsNullOrEmpty(cnn))
                    {
                        var chave = Util.Decrypt(cnn);
                        var c = chave.Split('|');
                        Conexao cn = new Conexao();
                        cn.Server = c[0];
                        cn.User = c[1];
                        cn.Password = c[2];
                        cn.database = c[3];
                        cn.Alias = cn.Server + " > " + cn.database;
                        ConexoesCadastradas.Add(cn);
                    }

                }
            }
        }

        private void Carregar(Conexao cn)
        {
            treeView1.Nodes.Clear();
            var ObjetosDB = new TraceRepository().CarregarObjetos(this.ConnectionString);

            //salva as conexoes
            if (cn != null)
                SalvarConexao(cn);


            TreeNode node = new TreeNode("Banco de dados");
            TreeNode tabelas = new TreeNode("Tabelas");
            TreeNode views = new TreeNode("Views");
            TreeNode procs = new TreeNode("Stored Procedures");
            TreeNode func = new TreeNode("Functions");
            TreeNode outros = new TreeNode("Outros");

            foreach (var obj in ObjetosDB)
            {
                if (obj.Tp_Evento == "TABLE")
                    tabelas.Nodes.Add(obj.Tp_Evento + "|" + obj.Nm_Objeto, obj.Nm_Objeto);
                else if (obj.Tp_Evento == "VIEW")
                    views.Nodes.Add(obj.Tp_Evento + "|" + obj.Nm_Objeto, obj.Nm_Objeto);
                else if (obj.Tp_Evento == "PROCEDURE")
                    procs.Nodes.Add(obj.Tp_Evento + "|" + obj.Nm_Objeto, obj.Nm_Objeto);
                else if (obj.Tp_Evento == "FUNCTION")
                    func.Nodes.Add(obj.Tp_Evento + "|" + obj.Nm_Objeto, obj.Nm_Objeto);
                else
                    outros.Nodes.Add(obj.Tp_Evento + "|" + obj.Nm_Objeto, obj.Nm_Objeto);
            }

            node.Nodes.Add(tabelas);
            node.Nodes.Add(views);
            node.Nodes.Add(procs);
            node.Nodes.Add(func);
            node.Nodes.Add(outros);
            treeView1.Nodes.Add(node);
        }

        private void SalvarConexao(Conexao cn)
        {
            ConexoesCadastradas.Add(cn);
            using (StreamWriter writer = new StreamWriter(ConnectionList))
            {
                foreach (var alias in ConexoesCadastradas.Select(_ => _.Alias).Distinct().ToList())
                {
                    var c = ConexoesCadastradas.Where(_ => _.Alias == alias).First();
                    var linha = $"{c.Server}|{c.User}|{c.Password}|{c.database}";
                    writer.WriteLine(Util.Encrypt(linha));
                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmDBConnect frmcnn = new frmDBConnect(ConexoesCadastradas);
            frmcnn.ShowDialog();
            if (frmcnn.DadosOk)
            {
                Conexao cn = new Conexao
                {
                    Server = frmcnn.Server,
                    User = frmcnn.User,
                    Password = frmcnn.Password,
                    database = frmcnn.database,
                    Alias = frmcnn.Server + " > " + frmcnn.database
                };
                this.ConnectionString = $"Data Source={frmcnn.Server};Initial Catalog={frmcnn.database};user id={frmcnn.User};password={frmcnn.Password};Max Pool Size=200;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;MultipleActiveResultSets=True";
                this.Carregar(cn);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Carregar(null);
        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void CarregaCommand(TraceObject obj)
        {
            var xml = obj.Ds_Evento;
            DataSet ds = new DataSet();
            StringReader reader = new StringReader(xml);
            ds.ReadXml(reader);
            txtCmd.Text = ds.Tables["TSQLCommand"].Rows[0]["CommandText"].ToString();
        }

        private void dgvHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            try
            {
                var tipo = node.Name.Split('|')[0];
                var obj = node.Name.Split('|')[1];

                txtObjeto.Text = tipo + " > " + obj;

                lista = new TraceRepository().CarregarHistorico(this.ConnectionString, tipo, obj).ToList();
                if (lista.Count() > 0)
                {
                    this.CarregaCommand(lista.First());
                }
                dgvHistorico.AutoGenerateColumns = false;
                dgvHistorico.DataSource = lista;
            }
            catch (Exception)
            {

            }
        }

        private void dgvHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHistorico_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(dgvHistorico.Rows[dgvHistorico.SelectedRows[0].Index].Cells[0].Value);
            var obj = lista.Where(_ => _.Id == Id).FirstOrDefault();
            if (obj != null)
            {
                this.CarregaCommand(obj);
            }
        }
    }
}
