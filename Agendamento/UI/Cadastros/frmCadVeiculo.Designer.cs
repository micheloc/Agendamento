namespace Agendamento.UI.Cadastros
{
    partial class frmCadVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadVeiculo));
            btnRemoverModelo = new Button();
            btnEditarModelo = new Button();
            btnAdicionarModelo = new Button();
            label1 = new Label();
            cmbModelo = new ComboBox();
            toolStrip1 = new ToolStrip();
            btnCancelar = new ToolStripButton();
            btnCadastrar = new ToolStripButton();
            btnRemoverMarca = new Button();
            btnEditarMarca = new Button();
            btnAdicionarMarca = new Button();
            label2 = new Label();
            cmbMarca = new ComboBox();
            btnRemoverCor = new Button();
            btnEditarCor = new Button();
            btnAdicionarCor = new Button();
            label3 = new Label();
            cmbCor = new ComboBox();
            label4 = new Label();
            txtAno = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRemoverModelo
            // 
            btnRemoverModelo.BackColor = Color.Transparent;
            btnRemoverModelo.BackgroundImage = (Image)resources.GetObject("btnRemoverModelo.BackgroundImage");
            btnRemoverModelo.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemoverModelo.Location = new Point(242, 20);
            btnRemoverModelo.Name = "btnRemoverModelo";
            btnRemoverModelo.Size = new Size(26, 23);
            btnRemoverModelo.TabIndex = 16;
            btnRemoverModelo.UseVisualStyleBackColor = false;
            btnRemoverModelo.Click += btnRemoverModelo_Click;
            // 
            // btnEditarModelo
            // 
            btnEditarModelo.BackColor = Color.Transparent;
            btnEditarModelo.BackgroundImage = (Image)resources.GetObject("btnEditarModelo.BackgroundImage");
            btnEditarModelo.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditarModelo.Location = new Point(215, 20);
            btnEditarModelo.Name = "btnEditarModelo";
            btnEditarModelo.Size = new Size(26, 23);
            btnEditarModelo.TabIndex = 15;
            btnEditarModelo.UseVisualStyleBackColor = false;
            btnEditarModelo.Click += btnEditarModelo_Click;
            // 
            // btnAdicionarModelo
            // 
            btnAdicionarModelo.BackColor = Color.Transparent;
            btnAdicionarModelo.BackgroundImage = (Image)resources.GetObject("btnAdicionarModelo.BackgroundImage");
            btnAdicionarModelo.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdicionarModelo.Location = new Point(188, 20);
            btnAdicionarModelo.Name = "btnAdicionarModelo";
            btnAdicionarModelo.Size = new Size(26, 23);
            btnAdicionarModelo.TabIndex = 14;
            btnAdicionarModelo.UseVisualStyleBackColor = false;
            btnAdicionarModelo.Click += btnAdicionarModelo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 2);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 13;
            label1.Text = "Modelo  : ";
            // 
            // cmbModelo
            // 
            cmbModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModelo.FlatStyle = FlatStyle.System;
            cmbModelo.FormattingEnabled = true;
            cmbModelo.Location = new Point(4, 20);
            cmbModelo.Name = "cmbModelo";
            cmbModelo.Size = new Size(180, 23);
            cmbModelo.TabIndex = 12;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCancelar, btnCadastrar });
            toolStrip1.Location = new Point(0, 196);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(274, 25);
            toolStrip1.TabIndex = 11;
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
            // btnRemoverMarca
            // 
            btnRemoverMarca.BackColor = Color.Transparent;
            btnRemoverMarca.BackgroundImage = (Image)resources.GetObject("btnRemoverMarca.BackgroundImage");
            btnRemoverMarca.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemoverMarca.Location = new Point(242, 64);
            btnRemoverMarca.Name = "btnRemoverMarca";
            btnRemoverMarca.Size = new Size(26, 23);
            btnRemoverMarca.TabIndex = 21;
            btnRemoverMarca.UseVisualStyleBackColor = false;
            btnRemoverMarca.Click += btnRemoverMarca_Click;
            // 
            // btnEditarMarca
            // 
            btnEditarMarca.BackColor = Color.Transparent;
            btnEditarMarca.BackgroundImage = (Image)resources.GetObject("btnEditarMarca.BackgroundImage");
            btnEditarMarca.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditarMarca.Location = new Point(215, 64);
            btnEditarMarca.Name = "btnEditarMarca";
            btnEditarMarca.Size = new Size(26, 23);
            btnEditarMarca.TabIndex = 20;
            btnEditarMarca.UseVisualStyleBackColor = false;
            btnEditarMarca.Click += btnEditarMarca_Click;
            // 
            // btnAdicionarMarca
            // 
            btnAdicionarMarca.BackColor = Color.Transparent;
            btnAdicionarMarca.BackgroundImage = (Image)resources.GetObject("btnAdicionarMarca.BackgroundImage");
            btnAdicionarMarca.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdicionarMarca.Location = new Point(188, 64);
            btnAdicionarMarca.Name = "btnAdicionarMarca";
            btnAdicionarMarca.Size = new Size(26, 23);
            btnAdicionarMarca.TabIndex = 19;
            btnAdicionarMarca.UseVisualStyleBackColor = false;
            btnAdicionarMarca.Click += btnAdicionarMarca_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 46);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 18;
            label2.Text = "Marca  : ";
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FlatStyle = FlatStyle.System;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(4, 64);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(180, 23);
            cmbMarca.TabIndex = 17;
            // 
            // btnRemoverCor
            // 
            btnRemoverCor.BackColor = Color.Transparent;
            btnRemoverCor.BackgroundImage = (Image)resources.GetObject("btnRemoverCor.BackgroundImage");
            btnRemoverCor.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemoverCor.Location = new Point(242, 108);
            btnRemoverCor.Name = "btnRemoverCor";
            btnRemoverCor.Size = new Size(26, 23);
            btnRemoverCor.TabIndex = 26;
            btnRemoverCor.UseVisualStyleBackColor = false;
            btnRemoverCor.Click += btnRemoverCor_Click;
            // 
            // btnEditarCor
            // 
            btnEditarCor.BackColor = Color.Transparent;
            btnEditarCor.BackgroundImage = (Image)resources.GetObject("btnEditarCor.BackgroundImage");
            btnEditarCor.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditarCor.Location = new Point(215, 108);
            btnEditarCor.Name = "btnEditarCor";
            btnEditarCor.Size = new Size(26, 23);
            btnEditarCor.TabIndex = 25;
            btnEditarCor.UseVisualStyleBackColor = false;
            btnEditarCor.Click += btnEditarCor_Click;
            // 
            // btnAdicionarCor
            // 
            btnAdicionarCor.BackColor = Color.Transparent;
            btnAdicionarCor.BackgroundImage = (Image)resources.GetObject("btnAdicionarCor.BackgroundImage");
            btnAdicionarCor.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdicionarCor.Location = new Point(188, 108);
            btnAdicionarCor.Name = "btnAdicionarCor";
            btnAdicionarCor.Size = new Size(26, 23);
            btnAdicionarCor.TabIndex = 24;
            btnAdicionarCor.UseVisualStyleBackColor = false;
            btnAdicionarCor.Click += btnAdicionarCor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 90);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 23;
            label3.Text = "Cor : ";
            // 
            // cmbCor
            // 
            cmbCor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCor.FlatStyle = FlatStyle.System;
            cmbCor.FormattingEnabled = true;
            cmbCor.Location = new Point(4, 108);
            cmbCor.Name = "cmbCor";
            cmbCor.Size = new Size(180, 23);
            cmbCor.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 136);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 28;
            label4.Text = "Ano : ";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(4, 154);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(264, 23);
            txtAno.TabIndex = 27;
            txtAno.TextAlign = HorizontalAlignment.Center;
            // 
            // frmCadVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 221);
            Controls.Add(label4);
            Controls.Add(txtAno);
            Controls.Add(btnRemoverCor);
            Controls.Add(btnEditarCor);
            Controls.Add(btnAdicionarCor);
            Controls.Add(label3);
            Controls.Add(cmbCor);
            Controls.Add(btnRemoverMarca);
            Controls.Add(btnEditarMarca);
            Controls.Add(btnAdicionarMarca);
            Controls.Add(label2);
            Controls.Add(cmbMarca);
            Controls.Add(btnRemoverModelo);
            Controls.Add(btnEditarModelo);
            Controls.Add(btnAdicionarModelo);
            Controls.Add(label1);
            Controls.Add(cmbModelo);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro veiculo";
            Load += frmCadVeiculo_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemoverModelo;
        private Button btnEditarModelo;
        private Button btnAdicionarModelo;
        private Label label1;
        private ComboBox cmbModelo;
        private ToolStrip toolStrip1;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnCadastrar;
        private Button btnRemoverMarca;
        private Button btnEditarMarca;
        private Button btnAdicionarMarca;
        private Label label2;
        private ComboBox cmbMarca;
        private Button btnRemoverCor;
        private Button btnEditarCor;
        private Button btnAdicionarCor;
        private Label label3;
        private ComboBox cmbCor;
        private Label label4;
        private TextBox txtAno;
    }
}