namespace Agendamento.UI.Cadastros
{
    partial class frmCadServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadServico));
            toolStrip1 = new ToolStrip();
            btnCancelar = new ToolStripButton();
            btnCadastrar = new ToolStripButton();
            cmbCategoria = new ComboBox();
            label1 = new Label();
            btnRegistrarCategoria = new Button();
            btnEditarCategoria = new Button();
            btnRemoverCategoria = new Button();
            txtCusto = new TextBox();
            dtTimeService = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
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
            toolStrip1.Size = new Size(610, 25);
            toolStrip1.TabIndex = 5;
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
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.System;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(4, 22);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(180, 23);
            cmbCategoria.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 7;
            label1.Text = "Categoria  : ";
            // 
            // btnRegistrarCategoria
            // 
            btnRegistrarCategoria.BackColor = Color.Transparent;
            btnRegistrarCategoria.BackgroundImage = (Image)resources.GetObject("btnRegistrarCategoria.BackgroundImage");
            btnRegistrarCategoria.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegistrarCategoria.Location = new Point(188, 22);
            btnRegistrarCategoria.Name = "btnRegistrarCategoria";
            btnRegistrarCategoria.Size = new Size(26, 23);
            btnRegistrarCategoria.TabIndex = 8;
            btnRegistrarCategoria.UseVisualStyleBackColor = false;
            btnRegistrarCategoria.Click += btnRegistrarCategoria_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.BackColor = Color.Transparent;
            btnEditarCategoria.BackgroundImage = (Image)resources.GetObject("btnEditarCategoria.BackgroundImage");
            btnEditarCategoria.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditarCategoria.Location = new Point(215, 22);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(26, 23);
            btnEditarCategoria.TabIndex = 9;
            btnEditarCategoria.UseVisualStyleBackColor = false;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnRemoverCategoria
            // 
            btnRemoverCategoria.BackColor = Color.Transparent;
            btnRemoverCategoria.BackgroundImage = (Image)resources.GetObject("btnRemoverCategoria.BackgroundImage");
            btnRemoverCategoria.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemoverCategoria.Location = new Point(242, 22);
            btnRemoverCategoria.Name = "btnRemoverCategoria";
            btnRemoverCategoria.Size = new Size(26, 23);
            btnRemoverCategoria.TabIndex = 10;
            btnRemoverCategoria.UseVisualStyleBackColor = false;
            btnRemoverCategoria.Click += btnRemoverCategoria_Click;
            // 
            // txtCusto
            // 
            txtCusto.Location = new Point(274, 22);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(122, 23);
            txtCusto.TabIndex = 11;
            txtCusto.TextAlign = HorizontalAlignment.Center;
            // 
            // dtTimeService
            // 
            dtTimeService.Format = DateTimePickerFormat.Time;
            dtTimeService.Location = new Point(402, 22);
            dtTimeService.Name = "dtTimeService";
            dtTimeService.Size = new Size(200, 23);
            dtTimeService.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 4);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 13;
            label2.Text = "Custo : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 4);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 4);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 15;
            label4.Text = "Tempo de serviço : ";
            // 
            // frmCadServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 83);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtTimeService);
            Controls.Add(txtCusto);
            Controls.Add(btnRemoverCategoria);
            Controls.Add(btnEditarCategoria);
            Controls.Add(btnRegistrarCategoria);
            Controls.Add(label1);
            Controls.Add(cmbCategoria);
            Controls.Add(toolStrip1);
            Name = "frmCadServico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de serviço";
            Load += frmCadServico_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnCadastrar;
        private ComboBox cmbCategoria;
        private Label label1;
        private Button btnRegistrarCategoria;
        private Button btnEditarCategoria;
        private Button btnRemoverCategoria;
        private TextBox txtCusto;
        private DateTimePicker dtTimeService;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}