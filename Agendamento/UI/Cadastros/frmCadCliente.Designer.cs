namespace Agendamento.UI.Cadastros
{
    partial class frmCadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCliente));
            txtNome = new TextBox();
            label1 = new Label();
            btnCancelar = new ToolStripButton();
            btnCadastrar = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            groupBox1 = new GroupBox();
            txtRegistro = new MaskedTextBox();
            rdPJ = new RadioButton();
            rdPF = new RadioButton();
            groupBox2 = new GroupBox();
            grdEnderecos = new DataGridView();
            objIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cepDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            logradouroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bairroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enderecoBindingSource = new BindingSource(components);
            toolStrip2 = new ToolStrip();
            btnAdicionarEndereco = new ToolStripButton();
            btnEditarEndereco = new ToolStripButton();
            btnRemoverEndereco = new ToolStripButton();
            groupBox3 = new GroupBox();
            grdContatos = new DataGridView();
            objIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            idClienteDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            celularDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            contatoBindingSource = new BindingSource(components);
            toolStrip3 = new ToolStrip();
            btnAdicionarContato = new ToolStripButton();
            btnEditarContato = new ToolStripButton();
            btnRemoverContato = new ToolStripButton();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdEnderecos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enderecoBindingSource).BeginInit();
            toolStrip2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdContatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource).BeginInit();
            toolStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Location = new Point(5, 39);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(253, 23);
            txtNome.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome : ";
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageTransparentColor = Color.Magenta;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 22);
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageTransparentColor = Color.Magenta;
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(70, 22);
            btnCadastrar.Text = "Finalizar";
            btnCadastrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCancelar, btnCadastrar });
            toolStrip1.Location = new Point(0, 386);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtRegistro);
            groupBox1.Controls.Add(rdPJ);
            groupBox1.Controls.Add(rdPF);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 69);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // txtRegistro
            // 
            txtRegistro.Location = new Point(261, 39);
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(225, 23);
            txtRegistro.TabIndex = 10;
            // 
            // rdPJ
            // 
            rdPJ.AutoSize = true;
            rdPJ.Location = new Point(308, 15);
            rdPJ.Name = "rdPJ";
            rdPJ.Size = new Size(35, 19);
            rdPJ.TabIndex = 9;
            rdPJ.TabStop = true;
            rdPJ.Text = "PJ";
            rdPJ.UseVisualStyleBackColor = true;
            rdPJ.CheckedChanged += rdPJ_CheckedChanged;
            // 
            // rdPF
            // 
            rdPF.AutoSize = true;
            rdPF.Location = new Point(265, 15);
            rdPF.Name = "rdPF";
            rdPF.Size = new Size(38, 19);
            rdPF.TabIndex = 8;
            rdPF.TabStop = true;
            rdPF.Text = "PF";
            rdPF.UseVisualStyleBackColor = true;
            rdPF.CheckedChanged += rdPF_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grdEnderecos);
            groupBox2.Controls.Add(toolStrip2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 151);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereços ";
            // 
            // grdEnderecos
            // 
            grdEnderecos.AllowUserToAddRows = false;
            grdEnderecos.AllowUserToDeleteRows = false;
            grdEnderecos.AllowUserToResizeColumns = false;
            grdEnderecos.AllowUserToResizeRows = false;
            grdEnderecos.AutoGenerateColumns = false;
            grdEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEnderecos.Columns.AddRange(new DataGridViewColumn[] { objIDDataGridViewTextBoxColumn, idClienteDataGridViewTextBoxColumn, cepDataGridViewTextBoxColumn, logradouroDataGridViewTextBoxColumn, bairroDataGridViewTextBoxColumn, numeroDataGridViewTextBoxColumn, clienteDataGridViewTextBoxColumn });
            grdEnderecos.DataSource = enderecoBindingSource;
            grdEnderecos.Dock = DockStyle.Fill;
            grdEnderecos.Location = new Point(3, 52);
            grdEnderecos.MultiSelect = false;
            grdEnderecos.Name = "grdEnderecos";
            grdEnderecos.ReadOnly = true;
            grdEnderecos.RowHeadersVisible = false;
            grdEnderecos.RowTemplate.Height = 25;
            grdEnderecos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdEnderecos.ShowCellErrors = false;
            grdEnderecos.ShowCellToolTips = false;
            grdEnderecos.ShowEditingIcon = false;
            grdEnderecos.ShowRowErrors = false;
            grdEnderecos.Size = new Size(794, 96);
            grdEnderecos.TabIndex = 10;
            grdEnderecos.SelectionChanged += grdEnderecos_SelectionChanged;
            // 
            // objIDDataGridViewTextBoxColumn
            // 
            objIDDataGridViewTextBoxColumn.DataPropertyName = "objID";
            objIDDataGridViewTextBoxColumn.HeaderText = "objID";
            objIDDataGridViewTextBoxColumn.Name = "objIDDataGridViewTextBoxColumn";
            objIDDataGridViewTextBoxColumn.ReadOnly = true;
            objIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            cepDataGridViewTextBoxColumn.HeaderText = "CEP";
            cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            logradouroDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            logradouroDataGridViewTextBoxColumn.DataPropertyName = "logradouro";
            logradouroDataGridViewTextBoxColumn.HeaderText = "Logradouro";
            logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            logradouroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            bairroDataGridViewTextBoxColumn.ReadOnly = true;
            bairroDataGridViewTextBoxColumn.Width = 150;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Nº";
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            clienteDataGridViewTextBoxColumn.ReadOnly = true;
            clienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // enderecoBindingSource
            // 
            enderecoBindingSource.DataSource = typeof(Services.Domain.Entities.Endereco);
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnAdicionarEndereco, btnEditarEndereco, btnRemoverEndereco });
            toolStrip2.Location = new Point(3, 19);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.RenderMode = ToolStripRenderMode.System;
            toolStrip2.Size = new Size(794, 33);
            toolStrip2.TabIndex = 9;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnAdicionarEndereco
            // 
            btnAdicionarEndereco.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarEndereco.Image = (Image)resources.GetObject("btnAdicionarEndereco.Image");
            btnAdicionarEndereco.ImageTransparentColor = Color.Magenta;
            btnAdicionarEndereco.Name = "btnAdicionarEndereco";
            btnAdicionarEndereco.Padding = new Padding(5);
            btnAdicionarEndereco.Size = new Size(30, 30);
            btnAdicionarEndereco.Text = "toolStripButton1";
            btnAdicionarEndereco.Click += btnAdicionarEndereco_Click;
            // 
            // btnEditarEndereco
            // 
            btnEditarEndereco.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditarEndereco.Image = (Image)resources.GetObject("btnEditarEndereco.Image");
            btnEditarEndereco.ImageTransparentColor = Color.Magenta;
            btnEditarEndereco.Name = "btnEditarEndereco";
            btnEditarEndereco.Padding = new Padding(5);
            btnEditarEndereco.Size = new Size(30, 30);
            btnEditarEndereco.Text = "toolStripButton2";
            btnEditarEndereco.Click += btnEditarEndereco_Click;
            // 
            // btnRemoverEndereco
            // 
            btnRemoverEndereco.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRemoverEndereco.Image = (Image)resources.GetObject("btnRemoverEndereco.Image");
            btnRemoverEndereco.ImageTransparentColor = Color.Magenta;
            btnRemoverEndereco.Name = "btnRemoverEndereco";
            btnRemoverEndereco.Padding = new Padding(5);
            btnRemoverEndereco.Size = new Size(30, 30);
            btnRemoverEndereco.Text = "toolStripButton3";
            btnRemoverEndereco.Click += btnRemoverEndereco_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grdContatos);
            groupBox3.Controls.Add(toolStrip3);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 220);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(800, 166);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contatos";
            // 
            // grdContatos
            // 
            grdContatos.AllowUserToAddRows = false;
            grdContatos.AllowUserToDeleteRows = false;
            grdContatos.AllowUserToResizeColumns = false;
            grdContatos.AllowUserToResizeRows = false;
            grdContatos.AutoGenerateColumns = false;
            grdContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdContatos.Columns.AddRange(new DataGridViewColumn[] { objIDDataGridViewTextBoxColumn1, idClienteDataGridViewTextBoxColumn1, celularDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, clienteDataGridViewTextBoxColumn1 });
            grdContatos.DataSource = contatoBindingSource;
            grdContatos.Dock = DockStyle.Fill;
            grdContatos.Location = new Point(3, 52);
            grdContatos.MultiSelect = false;
            grdContatos.Name = "grdContatos";
            grdContatos.ReadOnly = true;
            grdContatos.RowHeadersVisible = false;
            grdContatos.RowTemplate.Height = 25;
            grdContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdContatos.ShowCellErrors = false;
            grdContatos.ShowCellToolTips = false;
            grdContatos.ShowEditingIcon = false;
            grdContatos.ShowRowErrors = false;
            grdContatos.Size = new Size(794, 111);
            grdContatos.TabIndex = 10;
            grdContatos.SelectionChanged += grdContatos_SelectionChanged;
            // 
            // objIDDataGridViewTextBoxColumn1
            // 
            objIDDataGridViewTextBoxColumn1.DataPropertyName = "objID";
            objIDDataGridViewTextBoxColumn1.HeaderText = "objID";
            objIDDataGridViewTextBoxColumn1.Name = "objIDDataGridViewTextBoxColumn1";
            objIDDataGridViewTextBoxColumn1.ReadOnly = true;
            objIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idClienteDataGridViewTextBoxColumn1
            // 
            idClienteDataGridViewTextBoxColumn1.DataPropertyName = "IdCliente";
            idClienteDataGridViewTextBoxColumn1.HeaderText = "IdCliente";
            idClienteDataGridViewTextBoxColumn1.Name = "idClienteDataGridViewTextBoxColumn1";
            idClienteDataGridViewTextBoxColumn1.ReadOnly = true;
            idClienteDataGridViewTextBoxColumn1.Visible = false;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            celularDataGridViewTextBoxColumn.ReadOnly = true;
            celularDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            telefoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn1
            // 
            clienteDataGridViewTextBoxColumn1.DataPropertyName = "Cliente";
            clienteDataGridViewTextBoxColumn1.HeaderText = "Cliente";
            clienteDataGridViewTextBoxColumn1.Name = "clienteDataGridViewTextBoxColumn1";
            clienteDataGridViewTextBoxColumn1.ReadOnly = true;
            clienteDataGridViewTextBoxColumn1.Visible = false;
            // 
            // contatoBindingSource
            // 
            contatoBindingSource.DataSource = typeof(Services.Domain.Entities.Contato);
            // 
            // toolStrip3
            // 
            toolStrip3.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip3.Items.AddRange(new ToolStripItem[] { btnAdicionarContato, btnEditarContato, btnRemoverContato });
            toolStrip3.Location = new Point(3, 19);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.RenderMode = ToolStripRenderMode.System;
            toolStrip3.Size = new Size(794, 33);
            toolStrip3.TabIndex = 9;
            toolStrip3.Text = "toolStrip3";
            // 
            // btnAdicionarContato
            // 
            btnAdicionarContato.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarContato.Image = (Image)resources.GetObject("btnAdicionarContato.Image");
            btnAdicionarContato.ImageTransparentColor = Color.Magenta;
            btnAdicionarContato.Name = "btnAdicionarContato";
            btnAdicionarContato.Padding = new Padding(5);
            btnAdicionarContato.Size = new Size(30, 30);
            btnAdicionarContato.Text = "toolStripButton1";
            btnAdicionarContato.Click += btnAdicionarContato_Click;
            // 
            // btnEditarContato
            // 
            btnEditarContato.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditarContato.Image = (Image)resources.GetObject("btnEditarContato.Image");
            btnEditarContato.ImageTransparentColor = Color.Magenta;
            btnEditarContato.Name = "btnEditarContato";
            btnEditarContato.Padding = new Padding(5);
            btnEditarContato.Size = new Size(30, 30);
            btnEditarContato.Text = "toolStripButton2";
            btnEditarContato.Click += btnEditarContato_Click;
            // 
            // btnRemoverContato
            // 
            btnRemoverContato.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRemoverContato.Image = (Image)resources.GetObject("btnRemoverContato.Image");
            btnRemoverContato.ImageTransparentColor = Color.Magenta;
            btnRemoverContato.Name = "btnRemoverContato";
            btnRemoverContato.Padding = new Padding(5);
            btnRemoverContato.Size = new Size(30, 30);
            btnRemoverContato.Text = "toolStripButton3";
            btnRemoverContato.Click += btnRemoverContato_Click;
            // 
            // frmCadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Name = "frmCadCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Cliente";
            Load += frmCadCliente_Load_1;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdEnderecos).EndInit();
            ((System.ComponentModel.ISupportInitialize)enderecoBindingSource).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdContatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource).EndInit();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnCadastrar;
        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private MaskedTextBox txtRegistro;
        private RadioButton rdPJ;
        private RadioButton rdPF;
        private GroupBox groupBox2;
        private ToolStrip toolStrip2;
        private ToolStripButton btnAdicionarEndereco;
        private ToolStripButton btnEditarEndereco;
        private DataGridView grdEnderecos;
        private DataGridViewTextBoxColumn objIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private BindingSource enderecoBindingSource;
        private ToolStripButton btnRemoverEndereco;
        private GroupBox groupBox3;
        private DataGridView grdContatos;
        private ToolStrip toolStrip3;
        private ToolStripButton btnAdicionarContato;
        private ToolStripButton btnEditarContato;
        private ToolStripButton btnRemoverContato;
        private DataGridViewTextBoxColumn objIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn1;
        private BindingSource contatoBindingSource;
    }
}