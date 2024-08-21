namespace Agendamento.UI.Navegacao
{
    partial class frmNavCor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavCor));
            DataGridView grdCor;
            toolStrip1 = new ToolStrip();
            btnCadastrar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnRemover = new ToolStripButton();
            toolStrip2 = new ToolStrip();
            objIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            corDtoBindingSource = new BindingSource(components);
            grdCor = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdCor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)corDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCadastrar, btnEditar, btnRemover });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(605, 25);
            toolStrip1.TabIndex = 0;
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
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Location = new Point(0, 25);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.RenderMode = ToolStripRenderMode.System;
            toolStrip2.Size = new Size(605, 25);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // grdCor
            // 
            grdCor.AllowUserToAddRows = false;
            grdCor.AllowUserToDeleteRows = false;
            grdCor.AllowUserToResizeColumns = false;
            grdCor.AllowUserToResizeRows = false;
            grdCor.AutoGenerateColumns = false;
            grdCor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCor.Columns.AddRange(new DataGridViewColumn[] { objIDDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn });
            grdCor.DataSource = corDtoBindingSource;
            grdCor.Dock = DockStyle.Fill;
            grdCor.Location = new Point(0, 50);
            grdCor.MultiSelect = false;
            grdCor.Name = "grdCor";
            grdCor.ReadOnly = true;
            grdCor.RowHeadersVisible = false;
            grdCor.RowTemplate.Height = 25;
            grdCor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCor.ShowCellErrors = false;
            grdCor.ShowCellToolTips = false;
            grdCor.ShowEditingIcon = false;
            grdCor.ShowRowErrors = false;
            grdCor.Size = new Size(605, 273);
            grdCor.TabIndex = 2;
            grdCor.SelectionChanged += grdCor_SelectionChanged;
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
            // corDtoBindingSource
            // 
            corDtoBindingSource.DataSource = typeof(Services.Application.Dto.CorDto);
            // 
            // frmNavCor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 323);
            Controls.Add(grdCor);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            Name = "frmNavCor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cor";
            Load += frmNavCor_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdCor).EndInit();
            ((System.ComponentModel.ISupportInitialize)corDtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCadastrar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnRemover;
        private ToolStrip toolStrip2;
        private DataGridView grdCor;
        private DataGridViewTextBoxColumn objIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private BindingSource corDtoBindingSource;
    }
}