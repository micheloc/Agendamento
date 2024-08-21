namespace Agendamento.UI.Cadastros
{
    partial class frmCadEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadEndereco));
            toolStrip1 = new ToolStrip();
            btnCancelar = new ToolStripButton();
            btnCadastrar = new ToolStripButton();
            label1 = new Label();
            txtLogradouro = new TextBox();
            txtCep = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            txtBairro = new TextBox();
            label4 = new Label();
            txtNumero = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCancelar, btnCadastrar });
            toolStrip1.Location = new Point(0, 56);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(843, 25);
            toolStrip1.TabIndex = 4;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 3);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "CEP : ";
            // 
            // txtLogradouro
            // 
            txtLogradouro.CharacterCasing = CharacterCasing.Upper;
            txtLogradouro.Location = new Point(106, 21);
            txtLogradouro.MaxLength = 100;
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(311, 23);
            txtLogradouro.TabIndex = 1;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(4, 21);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(96, 23);
            txtCep.TabIndex = 0;
            txtCep.TextChanged += txtCep_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 3);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 7;
            label2.Text = "Logradouro: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(423, 3);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 9;
            label3.Text = "Bairro : ";
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Location = new Point(423, 21);
            txtBairro.MaxLength = 25;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(311, 23);
            txtBairro.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(739, 2);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 11;
            label4.Text = "Nº :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(739, 21);
            txtNumero.MaxLength = 25;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(96, 23);
            txtNumero.TabIndex = 3;
            // 
            // frmCadEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 81);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(txtNumero);
            Controls.Add(label3);
            Controls.Add(txtBairro);
            Controls.Add(label2);
            Controls.Add(txtCep);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Controls.Add(txtLogradouro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadEndereco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro endereço";
            Load += frmCadEndereco_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnCadastrar;
        private Label label1;
        private TextBox txtLogradouro;
        private MaskedTextBox txtCep;
        private Label label2;
        private Label label3;
        private TextBox txtBairro;
        private Label label4;
        private TextBox txtNumero;
    }
}