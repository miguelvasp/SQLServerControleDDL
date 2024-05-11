
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
            splitContainer1 = new SplitContainer();
            treeView1 = new TreeView();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            dgvHistorico = new DataGridView();
            txtCmd = new TextBox();
            toolStrip2 = new ToolStrip();
            txtObjeto = new ToolStripLabel();
            Id = new DataGridViewTextBoxColumn();
            Nm_Servidor = new DataGridViewTextBoxColumn();
            Nm_Database = new DataGridViewTextBoxColumn();
            Dt_Alteracao = new DataGridViewTextBoxColumn();
            Nm_Login = new DataGridViewTextBoxColumn();
            Tp_Evento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ActiveCaptionText;
            splitContainer1.Panel1.Controls.Add(treeView1);
            splitContainer1.Panel1.Controls.Add(toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.AppWorkspace;
            splitContainer1.Panel2.Controls.Add(dgvHistorico);
            splitContainer1.Panel2.Controls.Add(txtCmd);
            splitContainer1.Panel2.Controls.Add(toolStrip2);
            splitContainer1.Size = new Size(2097, 1039);
            splitContainer1.SplitterDistance = 500;
            splitContainer1.TabIndex = 5;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.White;
            treeView1.Dock = DockStyle.Fill;
            treeView1.Font = new Font("Segoe UI", 12F);
            treeView1.ForeColor = Color.Black;
            treeView1.Location = new Point(0, 55);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(500, 984);
            treeView1.TabIndex = 2;
            treeView1.AfterSelect += treeView1_AfterSelect_1;
            treeView1.Click += treeView1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackgroundImage = (Image)resources.GetObject("toolStrip1.BackgroundImage");
            toolStrip1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(500, 55);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            toolStripButton1.ForeColor = Color.White;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(124, 52);
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
            toolStripButton3.Size = new Size(125, 52);
            toolStripButton3.Text = "Atualizar";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // dgvHistorico
            // 
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AllowUserToDeleteRows = false;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Columns.AddRange(new DataGridViewColumn[] { Id, Nm_Servidor, Nm_Database, Dt_Alteracao, Nm_Login, Tp_Evento });
            dgvHistorico.Dock = DockStyle.Fill;
            dgvHistorico.Location = new Point(0, 826);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.RowHeadersWidth = 51;
            dgvHistorico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorico.Size = new Size(1593, 213);
            dgvHistorico.TabIndex = 5;
            dgvHistorico.CellContentClick += dgvHistorico_CellContentClick;
            // 
            // txtCmd
            // 
            txtCmd.BackColor = Color.White;
            txtCmd.Dock = DockStyle.Top;
            txtCmd.Font = new Font("Segoe UI", 14F);
            txtCmd.ForeColor = Color.Black;
            txtCmd.Location = new Point(0, 55);
            txtCmd.Multiline = true;
            txtCmd.Name = "txtCmd";
            txtCmd.ScrollBars = ScrollBars.Both;
            txtCmd.Size = new Size(1593, 771);
            txtCmd.TabIndex = 4;
            // 
            // toolStrip2
            // 
            toolStrip2.AutoSize = false;
            toolStrip2.BackgroundImage = (Image)resources.GetObject("toolStrip2.BackgroundImage");
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { txtObjeto });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1593, 55);
            toolStrip2.TabIndex = 3;
            toolStrip2.Text = "toolStrip2";
            // 
            // txtObjeto
            // 
            txtObjeto.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtObjeto.ForeColor = Color.White;
            txtObjeto.Name = "txtObjeto";
            txtObjeto.Size = new Size(70, 52);
            txtObjeto.Text = "Objeto";
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
            Nm_Servidor.Width = 300;
            // 
            // Nm_Database
            // 
            Nm_Database.DataPropertyName = "Nm_Database";
            Nm_Database.HeaderText = "Banco de Dados";
            Nm_Database.MinimumWidth = 6;
            Nm_Database.Name = "Nm_Database";
            Nm_Database.ReadOnly = true;
            Nm_Database.Width = 300;
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
            Controls.Add(splitContainer1);
            Name = "frmPrincipal";
            Text = "Controle de versão - SQL Server 1.0";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private SplitContainer splitContainer1;
        private TreeView treeView1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton3;
        private DataGridView dgvHistorico;
        private TextBox txtCmd;
        private ToolStrip toolStrip2;
        private ToolStripLabel txtObjeto;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nm_Servidor;
        private DataGridViewTextBoxColumn Nm_Database;
        private DataGridViewTextBoxColumn Dt_Alteracao;
        private DataGridViewTextBoxColumn Nm_Login;
        private DataGridViewTextBoxColumn Tp_Evento;
    }
}
