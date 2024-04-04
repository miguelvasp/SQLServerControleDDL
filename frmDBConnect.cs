namespace SQLServerControlVersion
{
    public partial class frmDBConnect : Form
    {
        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string database { get; set; }
        public bool DadosOk { get; set; }


        public frmDBConnect()
        {
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
    }
}
