namespace SQLServerControlVersion
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            panel1 = new Panel();
            treeView1 = new TreeView();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStrip2 = new ToolStrip();
            txtObjeto = new ToolStripLabel();
            txtCmd = new TextBox();
            dgvHistorico = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nm_Servidor = new DataGridViewTextBoxColumn();
            Nm_Database = new DataGridViewTextBoxColumn();
            Dt_Alteracao = new DataGridViewTextBoxColumn();
            Nm_Login = new DataGridViewTextBoxColumn();
            Tp_Evento = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(treeView1);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 1039);
            panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.DimGray;
            treeView1.Dock = DockStyle.Fill;
            treeView1.Font = new Font("Segoe UI", 12F);
            treeView1.ForeColor = Color.White;
            treeView1.Location = new Point(0, 55);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(550, 984);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.Click += treeView1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackgroundImage = Properties.Resources.Screenshot_2;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(550, 55);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton1.ForeColor = Color.White;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(140, 52);
            toolStripButton1.Text = "Conectar";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton3.ForeColor = Color.White;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(141, 52);
            toolStripButton3.Text = "Atualizar";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStrip2
            // 
            toolStrip2.AutoSize = false;
            toolStrip2.BackgroundImage = Properties.Resources.Screenshot_2;
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { txtObjeto });
            toolStrip2.Location = new Point(550, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1547, 55);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // txtObjeto
            // 
            txtObjeto.Font = new Font("Segoe UI", 14F);
            txtObjeto.ForeColor = Color.White;
            txtObjeto.Name = "txtObjeto";
            txtObjeto.Size = new Size(87, 52);
            txtObjeto.Text = "Objeto";
            // 
            // txtCmd
            // 
            txtCmd.BackColor = Color.DimGray;
            txtCmd.Dock = DockStyle.Top;
            txtCmd.Font = new Font("Segoe UI", 14F);
            txtCmd.ForeColor = Color.White;
            txtCmd.Location = new Point(550, 55);
            txtCmd.Multiline = true;
            txtCmd.Name = "txtCmd";
            txtCmd.ScrollBars = ScrollBars.Both;
            txtCmd.Size = new Size(1547, 817);
            txtCmd.TabIndex = 3;
            // 
            // dgvHistorico
            // 
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AllowUserToDeleteRows = false;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Columns.AddRange(new DataGridViewColumn[] { Id, Nm_Servidor, Nm_Database, Dt_Alteracao, Nm_Login, Tp_Evento });
            dgvHistorico.Dock = DockStyle.Fill;
            dgvHistorico.Location = new Point(550, 872);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.RowHeadersWidth = 51;
            dgvHistorico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorico.Size = new Size(1547, 167);
            dgvHistorico.TabIndex = 4;
            dgvHistorico.CellClick += dgvHistorico_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Nm_Servidor
            // 
            Nm_Servidor.DataPropertyName = "Nm_Servidor";
            Nm_Servidor.HeaderText = "Servidor";
            Nm_Servidor.MinimumWidth = 6;
            Nm_Servidor.Name = "Nm_Servidor";
            Nm_Servidor.ReadOnly = true;
            Nm_Servidor.Width = 200;
            // 
            // Nm_Database
            // 
            Nm_Database.DataPropertyName = "Nm_Database";
            Nm_Database.HeaderText = "Banco de Dados";
            Nm_Database.MinimumWidth = 6;
            Nm_Database.Name = "Nm_Database";
            Nm_Database.ReadOnly = true;
            Nm_Database.Width = 200;
            // 
            // Dt_Alteracao
            // 
            Dt_Alteracao.DataPropertyName = "Dt_Alteracao";
            Dt_Alteracao.HeaderText = "Data";
            Dt_Alteracao.MinimumWidth = 6;
            Dt_Alteracao.Name = "Dt_Alteracao";
            Dt_Alteracao.ReadOnly = true;
            Dt_Alteracao.Width = 200;
            // 
            // Nm_Login
            // 
            Nm_Login.DataPropertyName = "Nm_Login";
            Nm_Login.HeaderText = "User";
            Nm_Login.MinimumWidth = 6;
            Nm_Login.Name = "Nm_Login";
            Nm_Login.ReadOnly = true;
            Nm_Login.Width = 200;
            // 
            // Tp_Evento
            // 
            Tp_Evento.DataPropertyName = "Tp_Evento";
            Tp_Evento.HeaderText = "Tipo de Alteração";
            Tp_Evento.MinimumWidth = 6;
            Tp_Evento.Name = "Tp_Evento";
            Tp_Evento.ReadOnly = true;
            Tp_Evento.Width = 200;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2097, 1039);
            Controls.Add(dgvHistorico);
            Controls.Add(txtCmd);
            Controls.Add(toolStrip2);
            Controls.Add(panel1);
            Name = "frmPrincipal";
            Text = "Controle de versão - SQL Server 1.0";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            panel1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private TreeView treeView1;
        private ToolStripButton toolStripButton3;
        private ToolStrip toolStrip2;
        private TextBox txtCmd;
        private DataGridView dgvHistorico;
        private ToolStripLabel txtObjeto;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nm_Servidor;
        private DataGridViewTextBoxColumn Nm_Database;
        private DataGridViewTextBoxColumn Dt_Alteracao;
        private DataGridViewTextBoxColumn Nm_Login;
        private DataGridViewTextBoxColumn Tp_Evento;
    }
}
