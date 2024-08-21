namespace Agendamento.UI.Navegacao
{
    partial class frmNavCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavCliente));
            groupBox1 = new GroupBox();
            grdCliente = new DataGridView();
            objIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cpfcnpjDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enderecosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contatosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteVeiculosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            toolStrip2 = new ToolStrip();
            toolStrip1 = new ToolStrip();
            btnRegistrarCliente = new ToolStripButton();
            btnEditarCliente = new ToolStripButton();
            btnRemoverCliente = new ToolStripButton();
            groupBox2 = new GroupBox();
            grdEnderecos = new DataGridView();
            objIDDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            idClienteDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cepDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            logradouroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bairroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            enderecoBindingSource = new BindingSource(components);
            toolStrip3 = new ToolStrip();
            btnRegistrarEndereco = new ToolStripButton();
            btnEditarEnderecos = new ToolStripButton();
            btnRemoverEnderecos = new ToolStripButton();
            groupBox3 = new GroupBox();
            grdContatos = new DataGridView();
            objIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            idClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            celularDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contatoBindingSource = new BindingSource(components);
            toolStrip4 = new ToolStrip();
            btnRegistrarContato = new ToolStripButton();
            btnEditarContatos = new ToolStripButton();
            btnRemoverContatos = new ToolStripButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdEnderecos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enderecoBindingSource).BeginInit();
            toolStrip3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdContatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource).BeginInit();
            toolStrip4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(grdCliente);
            groupBox1.Controls.Add(toolStrip2);
            groupBox1.Controls.Add(toolStrip1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(953, 252);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // grdCliente
            // 
            grdCliente.AllowUserToAddRows = false;
            grdCliente.AllowUserToDeleteRows = false;
            grdCliente.AllowUserToResizeColumns = false;
            grdCliente.AllowUserToResizeRows = false;
            grdCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdCliente.AutoGenerateColumns = false;
            grdCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCliente.Columns.AddRange(new DataGridViewColumn[] { objIDDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, cpfcnpjDataGridViewTextBoxColumn, enderecosDataGridViewTextBoxColumn, contatosDataGridViewTextBoxColumn, clienteVeiculosDataGridViewTextBoxColumn });
            grdCliente.DataSource = clienteBindingSource;
            grdCliente.Location = new Point(3, 82);
            grdCliente.MultiSelect = false;
            grdCliente.Name = "grdCliente";
            grdCliente.ReadOnly = true;
            grdCliente.RowHeadersVisible = false;
            grdCliente.RowTemplate.Height = 25;
            grdCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCliente.Size = new Size(947, 167);
            grdCliente.TabIndex = 2;
            grdCliente.SelectionChanged += grdCliente_SelectionChanged;
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
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfcnpjDataGridViewTextBoxColumn
            // 
            cpfcnpjDataGridViewTextBoxColumn.DataPropertyName = "cpf_cnpj";
            cpfcnpjDataGridViewTextBoxColumn.HeaderText = "CPF/CNPJ";
            cpfcnpjDataGridViewTextBoxColumn.Name = "cpfcnpjDataGridViewTextBoxColumn";
            cpfcnpjDataGridViewTextBoxColumn.ReadOnly = true;
            cpfcnpjDataGridViewTextBoxColumn.Width = 220;
            // 
            // enderecosDataGridViewTextBoxColumn
            // 
            enderecosDataGridViewTextBoxColumn.DataPropertyName = "Enderecos";
            enderecosDataGridViewTextBoxColumn.HeaderText = "Enderecos";
            enderecosDataGridViewTextBoxColumn.Name = "enderecosDataGridViewTextBoxColumn";
            enderecosDataGridViewTextBoxColumn.ReadOnly = true;
            enderecosDataGridViewTextBoxColumn.Visible = false;
            // 
            // contatosDataGridViewTextBoxColumn
            // 
            contatosDataGridViewTextBoxColumn.DataPropertyName = "Contatos";
            contatosDataGridViewTextBoxColumn.HeaderText = "Contatos";
            contatosDataGridViewTextBoxColumn.Name = "contatosDataGridViewTextBoxColumn";
            contatosDataGridViewTextBoxColumn.ReadOnly = true;
            contatosDataGridViewTextBoxColumn.Visible = false;
            // 
            // clienteVeiculosDataGridViewTextBoxColumn
            // 
            clienteVeiculosDataGridViewTextBoxColumn.DataPropertyName = "ClienteVeiculos";
            clienteVeiculosDataGridViewTextBoxColumn.HeaderText = "ClienteVeiculos";
            clienteVeiculosDataGridViewTextBoxColumn.Name = "clienteVeiculosDataGridViewTextBoxColumn";
            clienteVeiculosDataGridViewTextBoxColumn.ReadOnly = true;
            clienteVeiculosDataGridViewTextBoxColumn.Visible = false;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Services.Domain.Entities.Cliente);
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Location = new Point(3, 52);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Padding = new Padding(2);
            toolStrip2.RenderMode = ToolStripRenderMode.System;
            toolStrip2.Size = new Size(947, 25);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnRegistrarCliente, btnEditarCliente, btnRemoverCliente });
            toolStrip1.Location = new Point(3, 19);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(947, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Image = (Image)resources.GetObject("btnRegistrarCliente.Image");
            btnRegistrarCliente.ImageTransparentColor = Color.Magenta;
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Padding = new Padding(5);
            btnRegistrarCliente.Size = new Size(83, 30);
            btnRegistrarCliente.Text = "Registrar";
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Enabled = false;
            btnEditarCliente.Image = (Image)resources.GetObject("btnEditarCliente.Image");
            btnEditarCliente.ImageTransparentColor = Color.Magenta;
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Padding = new Padding(5);
            btnEditarCliente.Size = new Size(67, 30);
            btnEditarCliente.Text = "Editar";
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // btnRemoverCliente
            // 
            btnRemoverCliente.Enabled = false;
            btnRemoverCliente.Image = (Image)resources.GetObject("btnRemoverCliente.Image");
            btnRemoverCliente.ImageTransparentColor = Color.Magenta;
            btnRemoverCliente.Name = "btnRemoverCliente";
            btnRemoverCliente.Padding = new Padding(5);
            btnRemoverCliente.Size = new Size(84, 30);
            btnRemoverCliente.Text = "Remover";
            btnRemoverCliente.Click += btnRemoverCliente_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(grdEnderecos);
            groupBox2.Controls.Add(toolStrip3);
            groupBox2.Location = new Point(0, 252);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(953, 251);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereços";
            // 
            // grdEnderecos
            // 
            grdEnderecos.AllowUserToAddRows = false;
            grdEnderecos.AllowUserToDeleteRows = false;
            grdEnderecos.AllowUserToResizeColumns = false;
            grdEnderecos.AllowUserToResizeRows = false;
            grdEnderecos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdEnderecos.AutoGenerateColumns = false;
            grdEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEnderecos.Columns.AddRange(new DataGridViewColumn[] { objIDDataGridViewTextBoxColumn2, idClienteDataGridViewTextBoxColumn1, cepDataGridViewTextBoxColumn, logradouroDataGridViewTextBoxColumn, numeroDataGridViewTextBoxColumn, bairroDataGridViewTextBoxColumn, clienteDataGridViewTextBoxColumn1 });
            grdEnderecos.DataSource = enderecoBindingSource;
            grdEnderecos.Location = new Point(3, 55);
            grdEnderecos.MultiSelect = false;
            grdEnderecos.Name = "grdEnderecos";
            grdEnderecos.ReadOnly = true;
            grdEnderecos.RowHeadersVisible = false;
            grdEnderecos.RowTemplate.Height = 25;
            grdEnderecos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdEnderecos.Size = new Size(947, 193);
            grdEnderecos.TabIndex = 3;
            grdEnderecos.SelectionChanged += grdEnderecos_SelectionChanged;
            // 
            // objIDDataGridViewTextBoxColumn2
            // 
            objIDDataGridViewTextBoxColumn2.DataPropertyName = "objID";
            objIDDataGridViewTextBoxColumn2.HeaderText = "objID";
            objIDDataGridViewTextBoxColumn2.Name = "objIDDataGridViewTextBoxColumn2";
            objIDDataGridViewTextBoxColumn2.ReadOnly = true;
            objIDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // idClienteDataGridViewTextBoxColumn1
            // 
            idClienteDataGridViewTextBoxColumn1.DataPropertyName = "IdCliente";
            idClienteDataGridViewTextBoxColumn1.HeaderText = "IdCliente";
            idClienteDataGridViewTextBoxColumn1.Name = "idClienteDataGridViewTextBoxColumn1";
            idClienteDataGridViewTextBoxColumn1.ReadOnly = true;
            idClienteDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            cepDataGridViewTextBoxColumn.HeaderText = "CEP";
            cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            cepDataGridViewTextBoxColumn.ReadOnly = true;
            cepDataGridViewTextBoxColumn.Width = 200;
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            logradouroDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            logradouroDataGridViewTextBoxColumn.DataPropertyName = "logradouro";
            logradouroDataGridViewTextBoxColumn.HeaderText = "Logradouro";
            logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            logradouroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Nº";
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.ReadOnly = true;
            numeroDataGridViewTextBoxColumn.Width = 80;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            bairroDataGridViewTextBoxColumn.ReadOnly = true;
            bairroDataGridViewTextBoxColumn.Width = 150;
            // 
            // clienteDataGridViewTextBoxColumn1
            // 
            clienteDataGridViewTextBoxColumn1.DataPropertyName = "Cliente";
            clienteDataGridViewTextBoxColumn1.HeaderText = "Cliente";
            clienteDataGridViewTextBoxColumn1.Name = "clienteDataGridViewTextBoxColumn1";
            clienteDataGridViewTextBoxColumn1.ReadOnly = true;
            clienteDataGridViewTextBoxColumn1.Visible = false;
            // 
            // enderecoBindingSource
            // 
            enderecoBindingSource.DataSource = typeof(Services.Domain.Entities.Endereco);
            // 
            // toolStrip3
            // 
            toolStrip3.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip3.Items.AddRange(new ToolStripItem[] { btnRegistrarEndereco, btnEditarEnderecos, btnRemoverEnderecos });
            toolStrip3.Location = new Point(3, 19);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.RenderMode = ToolStripRenderMode.System;
            toolStrip3.Size = new Size(947, 33);
            toolStrip3.TabIndex = 1;
            toolStrip3.Text = "toolStrip3";
            // 
            // btnRegistrarEndereco
            // 
            btnRegistrarEndereco.Enabled = false;
            btnRegistrarEndereco.Image = (Image)resources.GetObject("btnRegistrarEndereco.Image");
            btnRegistrarEndereco.ImageTransparentColor = Color.Magenta;
            btnRegistrarEndereco.Name = "btnRegistrarEndereco";
            btnRegistrarEndereco.Padding = new Padding(5);
            btnRegistrarEndereco.Size = new Size(83, 30);
            btnRegistrarEndereco.Text = "Registrar";
            btnRegistrarEndereco.Click += btnRegistrarEndereco_Click;
            // 
            // btnEditarEnderecos
            // 
            btnEditarEnderecos.Enabled = false;
            btnEditarEnderecos.Image = (Image)resources.GetObject("btnEditarEnderecos.Image");
            btnEditarEnderecos.ImageTransparentColor = Color.Magenta;
            btnEditarEnderecos.Name = "btnEditarEnderecos";
            btnEditarEnderecos.Padding = new Padding(5, 0, 0, 0);
            btnEditarEnderecos.Size = new Size(62, 30);
            btnEditarEnderecos.Text = "Editar";
            btnEditarEnderecos.Click += btnEditarEnderecos_Click;
            // 
            // btnRemoverEnderecos
            // 
            btnRemoverEnderecos.Enabled = false;
            btnRemoverEnderecos.Image = (Image)resources.GetObject("btnRemoverEnderecos.Image");
            btnRemoverEnderecos.ImageTransparentColor = Color.Magenta;
            btnRemoverEnderecos.Name = "btnRemoverEnderecos";
            btnRemoverEnderecos.Padding = new Padding(5, 0, 0, 0);
            btnRemoverEnderecos.Size = new Size(79, 30);
            btnRemoverEnderecos.Text = "Remover";
            btnRemoverEnderecos.Click += btnRemoverEnderecos_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(grdContatos);
            groupBox3.Controls.Add(toolStrip4);
            groupBox3.Location = new Point(0, 503);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(953, 261);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contatos";
            // 
            // grdContatos
            // 
            grdContatos.AllowUserToAddRows = false;
            grdContatos.AllowUserToDeleteRows = false;
            grdContatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdContatos.AutoGenerateColumns = false;
            grdContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdContatos.Columns.AddRange(new DataGridViewColumn[] { objIDDataGridViewTextBoxColumn1, idClienteDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn, celularDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, clienteDataGridViewTextBoxColumn });
            grdContatos.DataSource = contatoBindingSource;
            grdContatos.Location = new Point(3, 65);
            grdContatos.MultiSelect = false;
            grdContatos.Name = "grdContatos";
            grdContatos.ReadOnly = true;
            grdContatos.RowHeadersVisible = false;
            grdContatos.RowTemplate.Height = 25;
            grdContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdContatos.Size = new Size(947, 193);
            grdContatos.TabIndex = 4;
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
            // idClienteDataGridViewTextBoxColumn
            // 
            idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            telefoneDataGridViewTextBoxColumn.Width = 220;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            celularDataGridViewTextBoxColumn.ReadOnly = true;
            celularDataGridViewTextBoxColumn.Width = 220;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            emailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            clienteDataGridViewTextBoxColumn.ReadOnly = true;
            clienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // contatoBindingSource
            // 
            contatoBindingSource.DataSource = typeof(Services.Domain.Entities.Contato);
            // 
            // toolStrip4
            // 
            toolStrip4.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip4.Items.AddRange(new ToolStripItem[] { btnRegistrarContato, btnEditarContatos, btnRemoverContatos });
            toolStrip4.Location = new Point(3, 19);
            toolStrip4.Name = "toolStrip4";
            toolStrip4.RenderMode = ToolStripRenderMode.System;
            toolStrip4.Size = new Size(947, 33);
            toolStrip4.TabIndex = 1;
            toolStrip4.Text = "toolStrip4";
            // 
            // btnRegistrarContato
            // 
            btnRegistrarContato.Enabled = false;
            btnRegistrarContato.Image = (Image)resources.GetObject("btnRegistrarContato.Image");
            btnRegistrarContato.ImageTransparentColor = Color.Magenta;
            btnRegistrarContato.Name = "btnRegistrarContato";
            btnRegistrarContato.Padding = new Padding(5);
            btnRegistrarContato.Size = new Size(83, 30);
            btnRegistrarContato.Text = "Registrar";
            btnRegistrarContato.Click += btnRegistrarContato_Click;
            // 
            // btnEditarContatos
            // 
            btnEditarContatos.Enabled = false;
            btnEditarContatos.Image = (Image)resources.GetObject("btnEditarContatos.Image");
            btnEditarContatos.ImageTransparentColor = Color.Magenta;
            btnEditarContatos.Name = "btnEditarContatos";
            btnEditarContatos.Padding = new Padding(5);
            btnEditarContatos.Size = new Size(67, 30);
            btnEditarContatos.Text = "Editar";
            btnEditarContatos.Click += btnEditarContatos_Click;
            // 
            // btnRemoverContatos
            // 
            btnRemoverContatos.Enabled = false;
            btnRemoverContatos.Image = (Image)resources.GetObject("btnRemoverContatos.Image");
            btnRemoverContatos.ImageTransparentColor = Color.Magenta;
            btnRemoverContatos.Name = "btnRemoverContatos";
            btnRemoverContatos.Padding = new Padding(5);
            btnRemoverContatos.Size = new Size(84, 30);
            btnRemoverContatos.Text = "Remover";
            btnRemoverContatos.Click += btnRemoverContatos_Click;
            // 
            // frmNavCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 764);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmNavCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente/Endereço/Contato";
            Load += frmNavCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdEnderecos).EndInit();
            ((System.ComponentModel.ISupportInitialize)enderecoBindingSource).EndInit();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdContatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource).EndInit();
            toolStrip4.ResumeLayout(false);
            toolStrip4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView grdCliente;
        private DataGridViewTextBoxColumn objIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cpfcnpjDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enderecosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contatosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteVeiculosDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
        private ToolStrip toolStrip2;
        private ToolStrip toolStrip1;
        private ToolStripButton btnRegistrarCliente;
        private ToolStripButton btnEditarCliente;
        private ToolStripButton btnRemoverCliente;
        private GroupBox groupBox2;
        private DataGridView grdEnderecos;
        private ToolStrip toolStrip3;
        private ToolStripButton btnRegistrarEndereco;
        private ToolStripButton btnEditarEnderecos;
        private ToolStripButton btnRemoverEnderecos;
        private GroupBox groupBox3;
        private DataGridView grdContatos;
        private ToolStrip toolStrip4;
        private ToolStripButton btnRegistrarContato;
        private ToolStripButton btnEditarContatos;
        private ToolStripButton btnRemoverContatos;
        private DataGridViewTextBoxColumn objIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private BindingSource contatoBindingSource;
        private DataGridViewTextBoxColumn objIDDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn1;
        private BindingSource enderecoBindingSource;
    }
}