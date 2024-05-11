using SQLServerControlVersion.Models;

namespace SQLServerControlVersion
{
    public partial class frmDBConnect : Form
    {
        public List<Conexao> ConexoesCadastradas = new List<Conexao>();
        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string database { get; set; }
        public bool DadosOk { get; set; }


        public frmDBConnect(List<Conexao> cnnCad)
        {
            ConexoesCadastradas = cnnCad;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServer.Text) || string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtDatabase.Text))
            {
                MessageBox.Show("Preencha todas as informações!");
            }
            else
            {
                Server = txtServer.Text;
                User = txtUser.Text;
                Password = txtPassword.Text;
                database = txtDatabase.Text;
                DadosOk = true;
                this.Close();
            }
        }

        private void frmDBConnect_Load(object sender, EventArgs e)
        {
            cboConexoes.Items.Clear();
            cboConexoes.Items.Add("");
            foreach (var con in ConexoesCadastradas)
            {
                cboConexoes.Items.Add(con.Alias);
            }
        }

        private void cboConexoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cboConexoes.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedValue))
            {
                var conexaoSelecionada = ConexoesCadastradas.Where(_ => _.Alias == selectedValue).FirstOrDefault();
                if (conexaoSelecionada != null)
                {
                    txtServer.Text = conexaoSelecionada.Server;
                    txtUser.Text = conexaoSelecionada.User;
                    txtPassword.Text = conexaoSelecionada.Password;
                    txtDatabase.Text = conexaoSelecionada.database;
                }
            }
        }
    }


}
