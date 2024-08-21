namespace Agendamento.UI.Navegacao
{
    partial class frmNavCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavCategoria));
            toolStrip2 = new ToolStrip();
            toolStrip1 = new ToolStrip();
            btnCadastrar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnRemover = new ToolStripButton();
            grdCategorias = new DataGridView();
            objIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            servicosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaBindingSource = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Location = new Point(0, 25);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.RenderMode = ToolStripRenderMode.System;
            toolStrip2.Size = new Size(524, 25);
            toolStrip2.TabIndex = 3;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCadastrar, btnEditar, btnRemover });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(524, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageTransparentColor = Color.Magenta;
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(73, 22);
            btnCadastrar.Text = "Registrar";
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(57, 22);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Enabled = false;
            btnRemover.Image = (Image)resources.GetObject("btnRemover.Image");
            btnRemover.ImageTransparentColor = Color.Magenta;
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(62, 22);
            btnRemover.Text = "Excluir";
            btnRemover.Click += btnRemover_Click;
            // 
            // grdCategorias
            // 
            grdCategorias.AllowUserToAddRows = false;
            grdCategorias.AllowUserToDeleteRows = false;
            grdCategorias.AllowUserToResizeColumns = false;
            grdCategorias.AllowUserToResizeRows = false;
            grdCategorias.AutoGenerateColumns = false;
            grdCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCategorias.Columns.AddRange(new DataGridViewColumn[] { objIDDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, servicosDataGridViewTextBoxColumn });
            grdCategorias.DataSource = categoriaBindingSource;
            grdCategorias.Dock = DockStyle.Fill;
            grdCategorias.Location = new Point(0, 50);
            grdCategorias.MultiSelect = false;
            grdCategorias.Name = "grdCategorias";
            grdCategorias.ReadOnly = true;
            grdCategorias.RowHeadersVisible = false;
            grdCategorias.RowTemplate.Height = 25;
            grdCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCategorias.Size = new Size(524, 318);
            grdCategorias.TabIndex = 4;
            grdCategorias.SelectionChanged += grdCategorias_SelectionChanged;
            // 
            // objIDDataGridViewTextBoxColumn
            // 
            objIDDataGridViewTextBoxColumn.DataPropertyName = "objID";
            objIDDataGridViewTextBoxColumn.HeaderText = "objID";
            objIDDataGridViewTextBoxColumn.Name = "objIDDataGridViewTextBoxColumn";
            objIDDataGridViewTextBoxColumn.ReadOnly = true;
            objIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servicosDataGridViewTextBoxColumn
            // 
            servicosDataGridViewTextBoxColumn.DataPropertyName = "Servicos";
            servicosDataGridViewTextBoxColumn.HeaderText = "Servicos";
            servicosDataGridViewTextBoxColumn.Name = "servicosDataGridViewTextBoxColumn";
            servicosDataGridViewTextBoxColumn.ReadOnly = true;
            servicosDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Services.Domain.Entities.Categoria);
            // 
            // frmNavCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 368);
            Controls.Add(grdCategorias);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Name = "frmNavCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            Load += frmNavCategoria_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip2;
        private ToolStrip toolStrip1;
        private ToolStripButton btnCadastrar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnRemover;
        private DataGridView grdCategorias;
        private DataGridViewTextBoxColumn objIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn servicosDataGridViewTextBoxColumn;
        private BindingSource categoriaBindingSource;
    }
}