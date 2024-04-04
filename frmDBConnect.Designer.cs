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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 12);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome do Servidor";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(32, 35);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(738, 27);
            txtServer.TabIndex = 1;
            txtServer.Text = "NB-N158";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(32, 113);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(738, 27);
            txtUser.TabIndex = 3;
            txtUser.Text = "SA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 90);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Usuário";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(32, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(738, 27);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "45482";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 179);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(32, 294);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(738, 27);
            txtDatabase.TabIndex = 7;
            txtDatabase.Text = "ControleSQL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 271);
            label4.Name = "label4";
            label4.Size = new Size(183, 20);
            label4.TabIndex = 6;
            label4.Text = "Nome do banco de dados";
            // 
            // button1
            // 
            button1.Location = new Point(614, 358);
            button1.Name = "button1";
            button1.Size = new Size(156, 38);
            button1.TabIndex = 8;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmDBConnect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 422);
            Controls.Add(button1);
            Controls.Add(txtDatabase);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(txtServer);
            Controls.Add(label1);
            Name = "frmDBConnect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conexão com o SQL Server";
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
    }
}