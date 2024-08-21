namespace Agendamento.UI.Cadastros
{
    partial class frmCadCor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCor));
            txtDescricao = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            btnCancelar = new ToolStripButton();
            btnCadastrar = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.CharacterCasing = CharacterCasing.Upper;
            txtDescricao.Location = new Point(3, 23);
            txtDescricao.MaxLength = 25;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(311, 23);
            txtDescricao.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 5);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Informe a cor : ";
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
            toolStrip1.Size = new Size(318, 25);
            toolStrip1.TabIndex = 2;
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
            // frmCadCor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 81);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Controls.Add(txtDescricao);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadCor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de cor";
            Load += frmCadCor_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescricao;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnCadastrar;
    }
}