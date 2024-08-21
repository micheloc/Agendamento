namespace Agendamento.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            groupBox1 = new GroupBox();
            btnSair = new Button();
            btnAcessar = new Button();
            txtSenha = new TextBox();
            txtAcesso = new TextBox();
            groupBox2 = new GroupBox();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(btnSair);
            groupBox1.Controls.Add(btnAcessar);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtAcesso);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 421);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.IndianRed;
            btnSair.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor = SystemColors.ButtonFace;
            btnSair.Location = new Point(163, 380);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(202, 29);
            btnSair.TabIndex = 3;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = Color.MediumBlue;
            btnAcessar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcessar.ForeColor = SystemColors.ButtonFace;
            btnAcessar.Location = new Point(163, 347);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(202, 31);
            btnAcessar.TabIndex = 2;
            btnAcessar.Text = "ACESSAR";
            btnAcessar.UseVisualStyleBackColor = false;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = SystemColors.ScrollBar;
            txtSenha.Location = new Point(163, 321);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(202, 23);
            txtSenha.TabIndex = 1;
            txtSenha.Text = "123456";
            txtSenha.TextAlign = HorizontalAlignment.Center;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.Enter += txtSenha_Enter;
            // 
            // txtAcesso
            // 
            txtAcesso.CharacterCasing = CharacterCasing.Upper;
            txtAcesso.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAcesso.ForeColor = SystemColors.ScrollBar;
            txtAcesso.Location = new Point(163, 292);
            txtAcesso.Name = "txtAcesso";
            txtAcesso.Size = new Size(202, 23);
            txtAcesso.TabIndex = 0;
            txtAcesso.Text = "USUÁRIO";
            txtAcesso.TextAlign = HorizontalAlignment.Center;
            txtAcesso.Enter += txtAcesso_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(toolStrip1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(535, 471);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Black;
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2 });
            toolStrip1.Location = new Point(3, 443);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(529, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.ForeColor = SystemColors.Control;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(269, 22);
            toolStripLabel1.Text = "Product by © Kings Software / SYS Agendamento";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.ForeColor = SystemColors.ButtonFace;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(68, 22);
            toolStripLabel2.Text = "Versão 0.0.1";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 471);
            ControlBox = false;
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            KeyPress += Login_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private TextBox txtSenha;
        private TextBox txtAcesso;
        private Button btnSair;
        private Button btnAcessar;
        private ToolStripLabel toolStripLabel2;
    }
}