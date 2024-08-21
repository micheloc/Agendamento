namespace Agendamento.UI.Cadastros
{
    partial class frmCadMecanico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadMecanico));
            label2 = new Label();
            txtNomeMecanico = new TextBox();
            btnRemoverEspecialidade = new Button();
            btnEditarEspecialidade = new Button();
            btnRegistrarEspecialidade = new Button();
            label1 = new Label();
            cmbEspecialidade = new ComboBox();
            toolStrip1 = new ToolStrip();
            btnCancelar = new ToolStripButton();
            btnCadastrar = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 5);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 20;
            label2.Text = "Mecânico : ";
            // 
            // txtNomeMecanico
            // 
            txtNomeMecanico.CharacterCasing = CharacterCasing.Upper;
            txtNomeMecanico.Location = new Point(5, 23);
            txtNomeMecanico.MaxLength = 100;
            txtNomeMecanico.Name = "txtNomeMecanico";
            txtNomeMecanico.Size = new Size(283, 23);
            txtNomeMecanico.TabIndex = 19;
            txtNomeMecanico.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRemoverEspecialidade
            // 
            btnRemoverEspecialidade.BackColor = Color.Transparent;
            btnRemoverEspecialidade.BackgroundImage = (Image)resources.GetObject("btnRemoverEspecialidade.BackgroundImage");
            btnRemoverEspecialidade.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemoverEspecialidade.Location = new Point(532, 23);
            btnRemoverEspecialidade.Name = "btnRemoverEspecialidade";
            btnRemoverEspecialidade.Size = new Size(26, 23);
            btnRemoverEspecialidade.TabIndex = 18;
            btnRemoverEspecialidade.UseVisualStyleBackColor = false;
            btnRemoverEspecialidade.Click += btnRemoverEspecialidade_Click;
            // 
            // btnEditarEspecialidade
            // 
            btnEditarEspecialidade.BackColor = Color.Transparent;
            btnEditarEspecialidade.BackgroundImage = (Image)resources.GetObject("btnEditarEspecialidade.BackgroundImage");
            btnEditarEspecialidade.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditarEspecialidade.Location = new Point(505, 23);
            btnEditarEspecialidade.Name = "btnEditarEspecialidade";
            btnEditarEspecialidade.Size = new Size(26, 23);
            btnEditarEspecialidade.TabIndex = 17;
            btnEditarEspecialidade.UseVisualStyleBackColor = false;
            btnEditarEspecialidade.Click += btnEditarEspecialidade_Click;
            // 
            // btnRegistrarEspecialidade
            // 
            btnRegistrarEspecialidade.BackColor = Color.Transparent;
            btnRegistrarEspecialidade.BackgroundImage = (Image)resources.GetObject("btnRegistrarEspecialidade.BackgroundImage");
            btnRegistrarEspecialidade.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegistrarEspecialidade.Location = new Point(478, 23);
            btnRegistrarEspecialidade.Name = "btnRegistrarEspecialidade";
            btnRegistrarEspecialidade.Size = new Size(26, 23);
            btnRegistrarEspecialidade.TabIndex = 16;
            btnRegistrarEspecialidade.UseVisualStyleBackColor = false;
            btnRegistrarEspecialidade.Click += btnRegistrarCategoria_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 5);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 15;
            label1.Text = "Especialidade  : ";
            // 
            // cmbEspecialidade
            // 
            cmbEspecialidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidade.FlatStyle = FlatStyle.System;
            cmbEspecialidade.FormattingEnabled = true;
            cmbEspecialidade.Location = new Point(294, 23);
            cmbEspecialidade.Name = "cmbEspecialidade";
            cmbEspecialidade.Size = new Size(180, 23);
            cmbEspecialidade.TabIndex = 14;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCancelar, btnCadastrar });
            toolStrip1.Location = new Point(0, 58);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(564, 25);
            toolStrip1.TabIndex = 21;
            toolStrip1.Text = "toolStrip1";
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
            btnCadastrar.Size = new Size(81, 22);
            btnCadastrar.Text = "Confirmar";
            btnCadastrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmCadMecanico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 83);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(label2);
            Controls.Add(txtNomeMecanico);
            Controls.Add(btnRemoverEspecialidade);
            Controls.Add(btnEditarEspecialidade);
            Controls.Add(btnRegistrarEspecialidade);
            Controls.Add(label1);
            Controls.Add(cmbEspecialidade);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadMecanico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro mêcanico";
            Load += frmCadMecanico_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtNomeMecanico;
        private Button btnRemoverEspecialidade;
        private Button btnEditarEspecialidade;
        private Button btnRegistrarEspecialidade;
        private Label label1;
        private ComboBox cmbEspecialidade;
        private ToolStrip toolStrip1;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnCadastrar;
    }
}