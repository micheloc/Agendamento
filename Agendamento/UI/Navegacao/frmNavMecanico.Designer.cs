namespace Agendamento.UI.Navegacao
{
    partial class frmNavMecanico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavMecanico));
            toolStrip1 = new ToolStrip();
            btnRegistrarMecanico = new ToolStripButton();
            btnEditarMecanico = new ToolStripButton();
            btnRemoverMecanico = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            cmbEspecializacao = new ToolStripComboBox();
            grdMecanico = new DataGridView();
            objIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEspecialidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            especialidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mecanicoAuxBindingSource = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdMecanico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mecanicoAuxBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnRegistrarMecanico, btnEditarMecanico, btnRemoverMecanico, toolStripSeparator1, toolStripLabel1, cmbEspecializacao });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 33);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnRegistrarMecanico
            // 
            btnRegistrarMecanico.Image = (Image)resources.GetObject("btnRegistrarMecanico.Image");
            btnRegistrarMecanico.ImageTransparentColor = Color.Magenta;
            btnRegistrarMecanico.Name = "btnRegistrarMecanico";
            btnRegistrarMecanico.Padding = new Padding(5);
            btnRegistrarMecanico.Size = new Size(83, 30);
            btnRegistrarMecanico.Text = "Registrar";
            btnRegistrarMecanico.Click += btnRegistrarMecanico_Click;
            // 
            // btnEditarMecanico
            // 
            btnEditarMecanico.Enabled = false;
            btnEditarMecanico.Image = (Image)resources.GetObject("btnEditarMecanico.Image");
            btnEditarMecanico.ImageTransparentColor = Color.Magenta;
            btnEditarMecanico.Name = "btnEditarMecanico";
            btnEditarMecanico.Padding = new Padding(5);
            btnEditarMecanico.Size = new Size(67, 30);
            btnEditarMecanico.Text = "Editar";
            btnEditarMecanico.Click += btnEditarMecanico_Click;
            // 
            // btnRemoverMecanico
            // 
            btnRemoverMecanico.Enabled = false;
            btnRemoverMecanico.Image = (Image)resources.GetObject("btnRemoverMecanico.Image");
            btnRemoverMecanico.ImageTransparentColor = Color.Magenta;
            btnRemoverMecanico.Name = "btnRemoverMecanico";
            btnRemoverMecanico.Padding = new Padding(5);
            btnRemoverMecanico.Size = new Size(84, 30);
            btnRemoverMecanico.Text = "Remover";
            btnRemoverMecanico.Click += btnRemoverMecanico_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(91, 30);
            toolStripLabel1.Text = "Especialização : ";
            // 
            // cmbEspecializacao
            // 
            cmbEspecializacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecializacao.FlatStyle = FlatStyle.System;
            cmbEspecializacao.Name = "cmbEspecializacao";
            cmbEspecializacao.Size = new Size(121, 33);
            cmbEspecializacao.SelectedIndexChanged += cmbEspecializacao_SelectedIndexChanged;
            // 
            // grdMecanico
            // 
            grdMecanico.AllowUserToAddRows = false;
            grdMecanico.AllowUserToDeleteRows = false;
            grdMecanico.AllowUserToResizeColumns = false;
            grdMecanico.AllowUserToResizeRows = false;
            grdMecanico.AutoGenerateColumns = false;
            grdMecanico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMecanico.Columns.AddRange(new DataGridViewColumn[] { objIDDataGridViewTextBoxColumn, idEspecialidadeDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, especialidadeDataGridViewTextBoxColumn });
            grdMecanico.DataSource = mecanicoAuxBindingSource;
            grdMecanico.Dock = DockStyle.Fill;
            grdMecanico.Location = new Point(0, 33);
            grdMecanico.MultiSelect = false;
            grdMecanico.Name = "grdMecanico";
            grdMecanico.ReadOnly = true;
            grdMecanico.RowHeadersVisible = false;
            grdMecanico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdMecanico.ShowCellErrors = false;
            grdMecanico.ShowCellToolTips = false;
            grdMecanico.ShowEditingIcon = false;
            grdMecanico.ShowRowErrors = false;
            grdMecanico.Size = new Size(800, 417);
            grdMecanico.TabIndex = 3;
            grdMecanico.SelectionChanged += grdMecanico_SelectionChanged;
            // 
            // objIDDataGridViewTextBoxColumn
            // 
            objIDDataGridViewTextBoxColumn.DataPropertyName = "objID";
            objIDDataGridViewTextBoxColumn.HeaderText = "objID";
            objIDDataGridViewTextBoxColumn.Name = "objIDDataGridViewTextBoxColumn";
            objIDDataGridViewTextBoxColumn.ReadOnly = true;
            objIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // idEspecialidadeDataGridViewTextBoxColumn
            // 
            idEspecialidadeDataGridViewTextBoxColumn.DataPropertyName = "IdEspecialidade";
            idEspecialidadeDataGridViewTextBoxColumn.HeaderText = "IdEspecialidade";
            idEspecialidadeDataGridViewTextBoxColumn.Name = "idEspecialidadeDataGridViewTextBoxColumn";
            idEspecialidadeDataGridViewTextBoxColumn.ReadOnly = true;
            idEspecialidadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            nomeDataGridViewTextBoxColumn.FillWeight = 194.923859F;
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especialidadeDataGridViewTextBoxColumn
            // 
            especialidadeDataGridViewTextBoxColumn.DataPropertyName = "especialidade";
            especialidadeDataGridViewTextBoxColumn.FillWeight = 5.07614136F;
            especialidadeDataGridViewTextBoxColumn.HeaderText = "Especialidade";
            especialidadeDataGridViewTextBoxColumn.Name = "especialidadeDataGridViewTextBoxColumn";
            especialidadeDataGridViewTextBoxColumn.ReadOnly = true;
            especialidadeDataGridViewTextBoxColumn.Width = 180;
            // 
            // mecanicoAuxBindingSource
            // 
            mecanicoAuxBindingSource.DataSource = typeof(Services.Application.Auxiliar.MecanicoAux);
            // 
            // frmNavMecanico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grdMecanico);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNavMecanico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mecânicos";
            Load += frmNavMecanico_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdMecanico).EndInit();
            ((System.ComponentModel.ISupportInitialize)mecanicoAuxBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnRegistrarMecanico;
        private ToolStripButton btnEditarMecanico;
        private ToolStripButton btnRemoverMecanico;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox cmbEspecializacao;
        private DataGridView grdMecanico;
        private BindingSource mecanicoAuxBindingSource;
        private DataGridViewTextBoxColumn objIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEspecialidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn especialidadeDataGridViewTextBoxColumn;
    }
}