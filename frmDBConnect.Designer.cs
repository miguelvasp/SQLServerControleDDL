namespace SQLServerControlVersion
{
    partial class frmDBConnect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtServer = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtDatabase = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            cboConexoes = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 122);
            label1.Name = "label1";
            label1.Size = new Size(158, 23);
            label1.TabIndex = 0;
            label1.Text = "Nome do Servidor";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(45, 148);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(830, 30);
            txtServer.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(45, 219);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(830, 30);
            txtUser.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 193);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 2;
            label2.Text = "Usuário";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(45, 294);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(830, 30);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 268);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(45, 369);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(830, 30);
            txtDatabase.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 343);
            label4.Name = "label4";
            label4.Size = new Size(215, 23);
            label4.TabIndex = 6;
            label4.Text = "Nome do banco de dados";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(699, 458);
            button1.Name = "button1";
            button1.Size = new Size(176, 44);
            button1.TabIndex = 8;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 21);
            label5.Name = "label5";
            label5.Size = new Size(187, 23);
            label5.TabIndex = 9;
            label5.Text = "Histórico de Conexões";
            // 
            // cboConexoes
            // 
            cboConexoes.FormattingEnabled = true;
            cboConexoes.Location = new Point(45, 47);
            cboConexoes.Name = "cboConexoes";
            cboConexoes.Size = new Size(830, 31);
            cboConexoes.TabIndex = 10;
            cboConexoes.SelectedIndexChanged += cboConexoes_SelectedIndexChanged;
            // 
            // frmDBConnect
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 530);
            Controls.Add(cboConexoes);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txtDatabase);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(txtServer);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmDBConnect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conexão com o SQL Server";
            Load += frmDBConnect_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtServer;
        private TextBox txtUser;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtDatabase;
        private Label label4;
        private Button button1;
        private Label label5;
        private ComboBox cboConexoes;
    }
}