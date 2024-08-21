namespace Agendamento.UI.Cadastros
{
    partial class frmCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUsuario));
            txtSenha = new TextBox();
            label3 = new Label();
            txtAcesso = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            btnCancelar = new ToolStripButton();
            btnCadastrar = new ToolStripButton();
            txtNome = new TextBox();
            label2 = new Label();
            btnAjustePermissao = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(10, 64);
            txtSenha.MaxLength = 100;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(279, 23);
            txtSenha.TabIndex = 32;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 46);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 31;
            label3.Text = "Senha : ";
            // 
            // txtAcesso
            // 
            txtAcesso.CharacterCasing = CharacterCasing.Upper;
            txtAcesso.Location = new Point(295, 20);
            txtAcesso.MaxLength = 100;
            txtAcesso.Name = "txtAcesso";
            txtAcesso.Size = new Size(279, 23);
            txtAcesso.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 2);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 29;
            label1.Text = "Acesso : ";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCancelar, btnCadastrar });
            toolStrip1.Location = new Point(0, 100);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(586, 25);
            toolStrip1.TabIndex = 28;
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
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Location = new Point(10, 20);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(279, 23);
            txtNome.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 2);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 26;
            label2.Text = "Nome : ";
            // 
            // btnAjustePermissao
            // 
            btnAjustePermissao.Location = new Point(295, 64);
            btnAjustePermissao.Name = "btnAjustePermissao";
            btnAjustePermissao.Size = new Size(279, 23);
            btnAjustePermissao.TabIndex = 33;
            btnAjustePermissao.Text = "Ajustar Permissões";
            btnAjustePermissao.UseVisualStyleBackColor = true;
            btnAjustePermissao.Click += btnAjustePermissao_Click;
            // 
            // frmCadUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 125);
            Controls.Add(btnAjustePermissao);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(txtAcesso);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(txtNome);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de usuário";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private Label label3;
        private TextBox txtAcesso;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnCadastrar;
        private TextBox txtNome;
        private Label label2;
        private Button btnAjustePermissao;
    }
}