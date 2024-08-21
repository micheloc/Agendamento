namespace Agendamento.UI.Navegacao
{
    partial class frmNavServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavServico));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            btnRegistrarServico = new ToolStripButton();
            btnEditarServico = new ToolStripButton();
            btnRemoverServico = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            cmbCategoria = new ToolStripComboBox();
            grdServico = new DataGridView();
            objIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idCategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            custoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tempoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            servicoAuxBindingSource = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdServico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicoAuxBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnRegistrarServico, btnEditarServico, btnRemoverServico, toolStripSeparator1, toolStripLabel1, cmbCategoria });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(727, 33);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnRegistrarServico
            // 
            btnRegistrarServico.Image = (Image)resources.GetObject("btnRegistrarServico.Image");
            btnRegistrarServico.ImageTransparentColor = Color.Magenta;
            btnRegistrarServico.Name = "btnRegistrarServico";
            btnRegistrarServico.Padding = new Padding(5);
            btnRegistrarServico.Size = new Size(83, 30);
            btnRegistrarServico.Text = "Registrar";
            btnRegistrarServico.Click += btnRegistrarCliente_Click;
            // 
            // btnEditarServico
            // 
            btnEditarServico.Enabled = false;
            btnEditarServico.Image = (Image)resources.GetObject("btnEditarServico.Image");
            btnEditarServico.ImageTransparentColor = Color.Magenta;
            btnEditarServico.Name = "btnEditarServico";
            btnEditarServico.Padding = new Padding(5);
            btnEditarServico.Size = new Size(67, 30);
            btnEditarServico.Text = "Editar";
            btnEditarServico.Click += btnEditarServico_Click;
            // 
            // btnRemoverServico
            // 
            btnRemoverServico.Enabled = false;
            btnRemoverServico.Image = (Image)resources.GetObject("btnRemoverServico.Image");
            btnRemoverServico.ImageTransparentColor = Color.Magenta;
            btnRemoverServico.Name = "btnRemoverServico";
            btnRemoverServico.Padding = new Padding(5);
            btnRemoverServico.Size = new Size(84, 30);
            btnRemoverServico.Text = "Remover";
            btnRemoverServico.Click += btnRemoverServico_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(67, 30);
            toolStripLabel1.Text = "Categoria : ";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.System;
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 33);
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // grdServico
            // 
            grdServico.AllowUserToAddRows = false;
            grdServico.AllowUserToDeleteRows = false;
            grdServico.AutoGenerateColumns = false;
            grdServico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdServico.Columns.AddRange(new DataGridViewColumn[] { objIDDataGridViewTextBoxColumn, idCategoriaDataGridViewTextBoxColumn, categoriaDescDataGridViewTextBoxColumn, custoDataGridViewTextBoxColumn, tempoDataGridViewTextBoxColumn });
            grdServico.DataSource = servicoAuxBindingSource;
            grdServico.Dock = DockStyle.Fill;
            grdServico.Location = new Point(0, 33);
            grdServico.Name = "grdServico";
            grdServico.ReadOnly = true;
            grdServico.RowHeadersVisible = false;
            grdServico.RowTemplate.Height = 25;
            grdServico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdServico.Size = new Size(727, 342);
            grdServico.TabIndex = 3;
            grdServico.SelectionChanged += grdServico_SelectionChanged;
            // 
            // objIDDataGridViewTextBoxColumn
            // 
            objIDDataGridViewTextBoxColumn.DataPropertyName = "objID";
            objIDDataGridViewTextBoxColumn.HeaderText = "objID";
            objIDDataGridViewTextBoxColumn.Name = "objIDDataGridViewTextBoxColumn";
            objIDDataGridViewTextBoxColumn.ReadOnly = true;
            objIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IdCategoria";
            idCategoriaDataGridViewTextBoxColumn.HeaderText = "IdCategoria";
            idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            idCategoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoriaDescDataGridViewTextBoxColumn
            // 
            categoriaDescDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            categoriaDescDataGridViewTextBoxColumn.DataPropertyName = "categoriaDesc";
            categoriaDescDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDescDataGridViewTextBoxColumn.Name = "categoriaDescDataGridViewTextBoxColumn";
            categoriaDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custoDataGridViewTextBoxColumn
            // 
            custoDataGridViewTextBoxColumn.DataPropertyName = "custo";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            custoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            custoDataGridViewTextBoxColumn.HeaderText = "Custo";
            custoDataGridViewTextBoxColumn.Name = "custoDataGridViewTextBoxColumn";
            custoDataGridViewTextBoxColumn.ReadOnly = true;
            custoDataGridViewTextBoxColumn.Width = 180;
            // 
            // tempoDataGridViewTextBoxColumn
            // 
            tempoDataGridViewTextBoxColumn.DataPropertyName = "tempo";
            tempoDataGridViewTextBoxColumn.HeaderText = "Tempo";
            tempoDataGridViewTextBoxColumn.Name = "tempoDataGridViewTextBoxColumn";
            tempoDataGridViewTextBoxColumn.ReadOnly = true;
            tempoDataGridViewTextBoxColumn.Width = 180;
            // 
            // servicoAuxBindingSource
            // 
            servicoAuxBindingSource.DataSource = typeof(Services.Application.Auxiliar.ServicoAux);
            // 
            // frmNavServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 375);
            Controls.Add(grdServico);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNavServico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Serviços";
            Load += frmNavServico_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdServico).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicoAuxBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnRegistrarServico;
        private ToolStripButton btnEditarServico;
        private ToolStripButton btnRemoverServico;
        private DataGridView grdServico;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox cmbCategoria;
        private DataGridViewTextBoxColumn objIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDescDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn custoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tempoDataGridViewTextBoxColumn;
        private BindingSource servicoAuxBindingSource;
    }
}