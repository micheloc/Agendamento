namespace Agendamento.UI.Cadastros
{
    partial class frmCadModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadModelo));
            toolStrip1 = new ToolStrip();
            btnCancelar = new ToolStripButton();
            btnCadastrar = new ToolStripButton();
            label2 = new Label();
            txtFabricante = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCancelar, btnCadastrar });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new Point(0, 56);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(294, 25);
            toolStrip1.TabIndex = 24;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 3);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 23;
            label2.Text = "Fabricante : ";
            // 
            // txtFabricante
            // 
            txtFabricante.CharacterCasing = CharacterCasing.Upper;
            txtFabricante.Location = new Point(5, 21);
            txtFabricante.MaxLength = 100;
            txtFabricante.Name = "txtFabricante";
            txtFabricante.Size = new Size(283, 23);
            txtFabricante.TabIndex = 22;
            txtFabricante.TextAlign = HorizontalAlignment.Center;
            // 
            // frmCadModelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 81);
            Controls.Add(toolStrip1);
            Controls.Add(label2);
            Controls.Add(txtFabricante);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadModelo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro modelo";
            Load += frmCadModelo_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnCadastrar;
        private Label label2;
        private TextBox txtFabricante;
    }
}