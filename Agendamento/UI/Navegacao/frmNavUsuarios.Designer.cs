namespace Agendamento.UI.Navegacao
{
    partial class frmNavUsuarios
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavUsuarios));
            groupBox1 = new GroupBox();
            grdCliente = new DataGridView();
            objIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            senhaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            acessoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agendarServicosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioPermissaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioBindingSource = new BindingSource(components);
            toolStrip2 = new ToolStrip();
            toolStrip1 = new ToolStrip();
            btnRegistrarUsuario = new ToolStripButton();
            btnEditarUsuario = new ToolStripButton();
            btnRemoverUsuario = new ToolStripButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grdCliente);
            groupBox1.Controls.Add(toolStrip2);
            groupBox1.Controls.Add(toolStrip1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(789, 495);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // grdCliente
            // 
            grdCliente.AllowUserToAddRows = false;
            grdCliente.AllowUserToDeleteRows = false;
            grdCliente.AllowUserToResizeColumns = false;
            grdCliente.AllowUserToResizeRows = false;
            grdCliente.AutoGenerateColumns = false;
            grdCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCliente.Columns.AddRange(new DataGridViewColumn[] { objIDDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, senhaDataGridViewTextBoxColumn, acessoDataGridViewTextBoxColumn, agendarServicosDataGridViewTextBoxColumn, usuarioPermissaoDataGridViewTextBoxColumn });
            grdCliente.DataSource = usuarioBindingSource;
            grdCliente.Dock = DockStyle.Fill;
            grdCliente.Location = new Point(3, 77);
            grdCliente.MultiSelect = false;
            grdCliente.Name = "grdCliente";
            grdCliente.ReadOnly = true;
            grdCliente.RowHeadersVisible = false;
            grdCliente.RowTemplate.Height = 25;
            grdCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCliente.Size = new Size(783, 415);
            grdCliente.TabIndex = 2;
            // 
            // objIDDataGridViewTextBoxColumn
            // 
            objIDDataGridViewTextBoxColumn.DataPropertyName = "objID";
            objIDDataGridViewTextBoxColumn.HeaderText = "objID";
            objIDDataGridViewTextBoxColumn.Name = "objIDDataGridViewTextBoxColumn";
            objIDDataGridViewTextBoxColumn.ReadOnly = true;
            objIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome de exibição";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
            senhaDataGridViewTextBoxColumn.HeaderText = "senha";
            senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            senhaDataGridViewTextBoxColumn.ReadOnly = true;
            senhaDataGridViewTextBoxColumn.Visible = false;
            // 
            // acessoDataGridViewTextBoxColumn
            // 
            acessoDataGridViewTextBoxColumn.DataPropertyName = "acesso";
            acessoDataGridViewTextBoxColumn.HeaderText = "Acesso";
            acessoDataGridViewTextBoxColumn.Name = "acessoDataGridViewTextBoxColumn";
            acessoDataGridViewTextBoxColumn.ReadOnly = true;
            acessoDataGridViewTextBoxColumn.Width = 175;
            // 
            // agendarServicosDataGridViewTextBoxColumn
            // 
            agendarServicosDataGridViewTextBoxColumn.DataPropertyName = "AgendarServicos";
            agendarServicosDataGridViewTextBoxColumn.HeaderText = "AgendarServicos";
            agendarServicosDataGridViewTextBoxColumn.Name = "agendarServicosDataGridViewTextBoxColumn";
            agendarServicosDataGridViewTextBoxColumn.ReadOnly = true;
            agendarServicosDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioPermissaoDataGridViewTextBoxColumn
            // 
            usuarioPermissaoDataGridViewTextBoxColumn.DataPropertyName = "UsuarioPermissao";
            usuarioPermissaoDataGridViewTextBoxColumn.HeaderText = "UsuarioPermissao";
            usuarioPermissaoDataGridViewTextBoxColumn.Name = "usuarioPermissaoDataGridViewTextBoxColumn";
            usuarioPermissaoDataGridViewTextBoxColumn.ReadOnly = true;
            usuarioPermissaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Services.Domain.Entities.Usuario);
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Location = new Point(3, 52);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Padding = new Padding(2);
            toolStrip2.RenderMode = ToolStripRenderMode.System;
            toolStrip2.Size = new Size(783, 25);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnRegistrarUsuario, btnEditarUsuario, btnRemoverUsuario });
            toolStrip1.Location = new Point(3, 19);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(783, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Image = (Image)resources.GetObject("btnRegistrarUsuario.Image");
            btnRegistrarUsuario.ImageTransparentColor = Color.Magenta;
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Padding = new Padding(5);
            btnRegistrarUsuario.Size = new Size(83, 30);
            btnRegistrarUsuario.Text = "Registrar";
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Enabled = false;
            btnEditarUsuario.Image = (Image)resources.GetObject("btnEditarUsuario.Image");
            btnEditarUsuario.ImageTransparentColor = Color.Magenta;
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Padding = new Padding(5);
            btnEditarUsuario.Size = new Size(67, 30);
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnRemoverUsuario
            // 
            btnRemoverUsuario.Enabled = false;
            btnRemoverUsuario.Image = (Image)resources.GetObject("btnRemoverUsuario.Image");
            btnRemoverUsuario.ImageTransparentColor = Color.Magenta;
            btnRemoverUsuario.Name = "btnRemoverUsuario";
            btnRemoverUsuario.Padding = new Padding(5);
            btnRemoverUsuario.Size = new Size(84, 30);
            btnRemoverUsuario.Text = "Remover";
            btnRemoverUsuario.Click += btnRemoverUsuario_Click;
            // 
            // frmNavUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 495);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNavUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuários";
            Load += frmNavUsuarios_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView grdCliente;
        private ToolStrip toolStrip2;
        private ToolStrip toolStrip1;
        private ToolStripButton btnRegistrarUsuario;
        private ToolStripButton btnEditarUsuario;
        private ToolStripButton btnRemoverUsuario;
        private DataGridViewTextBoxColumn objIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acessoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agendarServicosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioPermissaoDataGridViewTextBoxColumn;
        private BindingSource usuarioBindingSource;
    }
}