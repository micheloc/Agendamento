namespace Agendamento.UI.Navegacao
{
    partial class frmNavVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavVeiculos));
            groupBox1 = new GroupBox();
            grdVeiculo = new DataGridView();
            objIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modeloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            corDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            veiculoAuxBindingSource = new BindingSource(components);
            toolStrip2 = new ToolStrip();
            toolStrip1 = new ToolStrip();
            btnRegistrarVeiculo = new ToolStripButton();
            btnEditarVeiculo = new ToolStripButton();
            btnRemoverVeiculo = new ToolStripButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdVeiculo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)veiculoAuxBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grdVeiculo);
            groupBox1.Controls.Add(toolStrip2);
            groupBox1.Controls.Add(toolStrip1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 465);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // grdVeiculo
            // 
            grdVeiculo.AllowUserToAddRows = false;
            grdVeiculo.AllowUserToDeleteRows = false;
            grdVeiculo.AllowUserToResizeColumns = false;
            grdVeiculo.AllowUserToResizeRows = false;
            grdVeiculo.AutoGenerateColumns = false;
            grdVeiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVeiculo.Columns.AddRange(new DataGridViewColumn[] { objIDDataGridViewTextBoxColumn, modeloDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, corDataGridViewTextBoxColumn, anoDataGridViewTextBoxColumn });
            grdVeiculo.DataSource = veiculoAuxBindingSource;
            grdVeiculo.Dock = DockStyle.Fill;
            grdVeiculo.Location = new Point(3, 77);
            grdVeiculo.MultiSelect = false;
            grdVeiculo.Name = "grdVeiculo";
            grdVeiculo.ReadOnly = true;
            grdVeiculo.RowHeadersVisible = false;
            grdVeiculo.RowTemplate.Height = 25;
            grdVeiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVeiculo.Size = new Size(794, 385);
            grdVeiculo.TabIndex = 2;
            grdVeiculo.SelectionChanged += grdVeiculo_SelectionChanged;
            // 
            // objIDDataGridViewTextBoxColumn
            // 
            objIDDataGridViewTextBoxColumn.DataPropertyName = "objID";
            objIDDataGridViewTextBoxColumn.HeaderText = "objID";
            objIDDataGridViewTextBoxColumn.Name = "objIDDataGridViewTextBoxColumn";
            objIDDataGridViewTextBoxColumn.ReadOnly = true;
            objIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            modeloDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            marcaDataGridViewTextBoxColumn.ReadOnly = true;
            marcaDataGridViewTextBoxColumn.Width = 150;
            // 
            // corDataGridViewTextBoxColumn
            // 
            corDataGridViewTextBoxColumn.DataPropertyName = "cor";
            corDataGridViewTextBoxColumn.HeaderText = "Cor";
            corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            corDataGridViewTextBoxColumn.ReadOnly = true;
            corDataGridViewTextBoxColumn.Width = 150;
            // 
            // anoDataGridViewTextBoxColumn
            // 
            anoDataGridViewTextBoxColumn.DataPropertyName = "ano";
            anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            anoDataGridViewTextBoxColumn.ReadOnly = true;
            anoDataGridViewTextBoxColumn.Width = 150;
            // 
            // veiculoAuxBindingSource
            // 
            veiculoAuxBindingSource.DataSource = typeof(Services.Application.Auxiliar.VeiculoAux);
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Location = new Point(3, 52);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Padding = new Padding(2);
            toolStrip2.RenderMode = ToolStripRenderMode.System;
            toolStrip2.Size = new Size(794, 25);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnRegistrarVeiculo, btnEditarVeiculo, btnRemoverVeiculo });
            toolStrip1.Location = new Point(3, 19);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(794, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnRegistrarVeiculo
            // 
            btnRegistrarVeiculo.Image = (Image)resources.GetObject("btnRegistrarVeiculo.Image");
            btnRegistrarVeiculo.ImageTransparentColor = Color.Magenta;
            btnRegistrarVeiculo.Name = "btnRegistrarVeiculo";
            btnRegistrarVeiculo.Padding = new Padding(5);
            btnRegistrarVeiculo.Size = new Size(83, 30);
            btnRegistrarVeiculo.Text = "Registrar";
            btnRegistrarVeiculo.Click += btnRegistrarVeiculo_Click;
            // 
            // btnEditarVeiculo
            // 
            btnEditarVeiculo.Enabled = false;
            btnEditarVeiculo.Image = (Image)resources.GetObject("btnEditarVeiculo.Image");
            btnEditarVeiculo.ImageTransparentColor = Color.Magenta;
            btnEditarVeiculo.Name = "btnEditarVeiculo";
            btnEditarVeiculo.Padding = new Padding(5);
            btnEditarVeiculo.Size = new Size(67, 30);
            btnEditarVeiculo.Text = "Editar";
            btnEditarVeiculo.Click += btnEditarVeiculo_Click;
            // 
            // btnRemoverVeiculo
            // 
            btnRemoverVeiculo.Enabled = false;
            btnRemoverVeiculo.Image = (Image)resources.GetObject("btnRemoverVeiculo.Image");
            btnRemoverVeiculo.ImageTransparentColor = Color.Magenta;
            btnRemoverVeiculo.Name = "btnRemoverVeiculo";
            btnRemoverVeiculo.Padding = new Padding(5);
            btnRemoverVeiculo.Size = new Size(84, 30);
            btnRemoverVeiculo.Text = "Remover";
            btnRemoverVeiculo.Click += btnRemoverVeiculo_Click;
            // 
            // frmNavVeiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 465);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNavVeiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veiculos";
            Load += frmNavVeiculos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdVeiculo).EndInit();
            ((System.ComponentModel.ISupportInitialize)veiculoAuxBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView grdVeiculo;
        private ToolStrip toolStrip2;
        private ToolStrip toolStrip1;
        private ToolStripButton btnRegistrarVeiculo;
        private ToolStripButton btnEditarVeiculo;
        private ToolStripButton btnRemoverVeiculo;
        private DataGridViewTextBoxColumn objIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private BindingSource veiculoAuxBindingSource;
    }
}