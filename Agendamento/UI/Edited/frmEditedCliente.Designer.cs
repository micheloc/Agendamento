namespace Agendamento.UI.Edited
{
    partial class frmEditedCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditedCliente));
            txtRegistro = new MaskedTextBox();
            rdPJ = new RadioButton();
            rdPF = new RadioButton();
            txtNome = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            btnCancelar = new ToolStripButton();
            btnCadastrar = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRegistro
            // 
            txtRegistro.Location = new Point(259, 26);
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(225, 23);
            txtRegistro.TabIndex = 15;
            // 
            // rdPJ
            // 
            rdPJ.AutoSize = true;
            rdPJ.Location = new Point(306, 2);
            rdPJ.Name = "rdPJ";
            rdPJ.Size = new Size(35, 19);
            rdPJ.TabIndex = 14;
            rdPJ.TabStop = true;
            rdPJ.Text = "PJ";
            rdPJ.UseVisualStyleBackColor = true;
            rdPJ.CheckedChanged += rdPJ_CheckedChanged;
            // 
            // rdPF
            // 
            rdPF.AutoSize = true;
            rdPF.Location = new Point(263, 2);
            rdPF.Name = "rdPF";
            rdPF.Size = new Size(38, 19);
            rdPF.TabIndex = 13;
            rdPF.TabStop = true;
            rdPF.Text = "PF";
            rdPF.UseVisualStyleBackColor = true;
            rdPF.CheckedChanged += rdPF_CheckedChanged;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Location = new Point(3, 26);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(253, 23);
            txtNome.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome : ";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCancelar, btnCadastrar });
            toolStrip1.Location = new Point(0, 59);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(489, 25);
            toolStrip1.TabIndex = 16;
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
            btnCadastrar.Size = new Size(70, 22);
            btnCadastrar.Text = "Finalizar";
            btnCadastrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmEditedCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 84);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(txtRegistro);
            Controls.Add(rdPJ);
            Controls.Add(rdPF);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEditedCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar cliente";
            Load += frmEditedCliente_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtRegistro;
        private RadioButton rdPJ;
        private RadioButton rdPF;
        private TextBox txtNome;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnCadastrar;
    }
}