namespace Agendamento.UI.Navegacao
{
    partial class frmNavMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavMarca));
            grdMarca = new DataGridView();
            objIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fabricanteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            veiculosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaBindingSource = new BindingSource(components);
            toolStrip2 = new ToolStrip();
            toolStrip1 = new ToolStrip();
            btnCadastrar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnRemover = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)grdMarca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)marcaBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grdMarca
            // 
            grdMarca.AllowUserToAddRows = false;
            grdMarca.AllowUserToDeleteRows = false;
            grdMarca.AllowUserToResizeColumns = false;
            grdMarca.AllowUserToResizeRows = false;
            grdMarca.AutoGenerateColumns = false;
            grdMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMarca.Columns.AddRange(new DataGridViewColumn[] { objIDDataGridViewTextBoxColumn, fabricanteDataGridViewTextBoxColumn, veiculosDataGridViewTextBoxColumn });
            grdMarca.DataSource = marcaBindingSource;
            grdMarca.Dock = DockStyle.Fill;
            grdMarca.Location = new Point(0, 50);
            grdMarca.MultiSelect = false;
            grdMarca.Name = "grdMarca";
            grdMarca.ReadOnly = true;
            grdMarca.RowHeadersVisible = false;
            grdMarca.RowTemplate.Height = 25;
            grdMarca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdMarca.ShowCellErrors = false;
            grdMarca.ShowCellToolTips = false;
            grdMarca.ShowEditingIcon = false;
            grdMarca.ShowRowErrors = false;
            grdMarca.Size = new Size(582, 285);
            grdMarca.TabIndex = 5;
            grdMarca.SelectionChanged += grdMarca_SelectionChanged_1;
            // 
            // objIDDataGridViewTextBoxColumn
            // 
            objIDDataGridViewTextBoxColumn.DataPropertyName = "objID";
            objIDDataGridViewTextBoxColumn.HeaderText = "objID";
            objIDDataGridViewTextBoxColumn.Name = "objIDDataGridViewTextBoxColumn";
            objIDDataGridViewTextBoxColumn.ReadOnly = true;
            objIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fabricanteDataGridViewTextBoxColumn
            // 
            fabricanteDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fabricanteDataGridViewTextBoxColumn.DataPropertyName = "fabricante";
            fabricanteDataGridViewTextBoxColumn.HeaderText = "Fabricante";
            fabricanteDataGridViewTextBoxColumn.Name = "fabricanteDataGridViewTextBoxColumn";
            fabricanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // veiculosDataGridViewTextBoxColumn
            // 
            veiculosDataGridViewTextBoxColumn.DataPropertyName = "Veiculos";
            veiculosDataGridViewTextBoxColumn.HeaderText = "Veiculos";
            veiculosDataGridViewTextBoxColumn.Name = "veiculosDataGridViewTextBoxColumn";
            veiculosDataGridViewTextBoxColumn.ReadOnly = true;
            veiculosDataGridViewTextBoxColumn.Visible = false;
            // 
            // marcaBindingSource
            // 
            marcaBindingSource.DataSource = typeof(Services.Domain.Entities.Marca);
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Location = new Point(0, 25);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.RenderMode = ToolStripRenderMode.System;
            toolStrip2.Size = new Size(582, 25);
            toolStrip2.TabIndex = 4;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCadastrar, btnEditar, btnRemover });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(582, 25);
            toolStrip1.TabIndex = 3;
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
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnRemover
            // 
            btnRemover.Enabled = false;
            btnRemover.Image = (Image)resources.GetObject("btnRemover.Image");
            btnRemover.ImageTransparentColor = Color.Magenta;
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(62, 22);
            btnRemover.Text = "Excluir";
            btnRemover.Click += btnRemover_Click_1;
            // 
            // frmNavMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 335);
            Controls.Add(grdMarca);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Name = "frmNavMarca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marca";
            Load += Marca_Load;
            ((System.ComponentModel.ISupportInitialize)grdMarca).EndInit();
            ((System.ComponentModel.ISupportInitialize)marcaBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdMarca;
        private DataGridViewTextBoxColumn objIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fabricanteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn veiculosDataGridViewTextBoxColumn;
        private BindingSource marcaBindingSource;
        private ToolStrip toolStrip2;
        private ToolStrip toolStrip1;
        private ToolStripButton btnCadastrar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnRemover;
    }
}