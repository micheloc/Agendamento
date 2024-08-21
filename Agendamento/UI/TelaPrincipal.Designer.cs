namespace Agendamento.UI
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            toolStrip1 = new ToolStrip();
            lb_seja_bem_vindo = new ToolStripLabel();
            lb_nome_usuario = new ToolStripLabel();
            btnSairSistema = new ToolStripButton();
            btnAltearUsuario = new ToolStripButton();
            btnAjustarUsuario = new ToolStripButton();
            toolStrip2 = new ToolStrip();
            btnGroupCadastros = new ToolStripDropDownButton();
            btnClientes = new ToolStripMenuItem();
            btnVeiculos = new ToolStripMenuItem();
            btnMecanicos = new ToolStripMenuItem();
            btnServicos = new ToolStripMenuItem();
            btnAgendarServico = new ToolStripButton();
            btnUsuarios = new ToolStripButton();
            groupBox1 = new GroupBox();
            toolStrip3 = new ToolStrip();
            btnSuporteDev = new ToolStripButton();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            groupBox1.SuspendLayout();
            toolStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { lb_seja_bem_vindo, lb_nome_usuario, btnSairSistema, btnAltearUsuario, btnAjustarUsuario });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(5, 10, 1, 10);
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(1008, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // lb_seja_bem_vindo
            // 
            lb_seja_bem_vindo.BackColor = Color.Transparent;
            lb_seja_bem_vindo.Name = "lb_seja_bem_vindo";
            lb_seja_bem_vindo.Size = new Size(126, 36);
            lb_seja_bem_vindo.Text = "Seja Bem vindo : ";
            lb_seja_bem_vindo.Visible = false;
            // 
            // lb_nome_usuario
            // 
            lb_nome_usuario.BackColor = Color.Transparent;
            lb_nome_usuario.Name = "lb_nome_usuario";
            lb_nome_usuario.Size = new Size(51, 36);
            lb_nome_usuario.Text = "Nome";
            lb_nome_usuario.Visible = false;
            // 
            // btnSairSistema
            // 
            btnSairSistema.Alignment = ToolStripItemAlignment.Right;
            btnSairSistema.Image = (Image)resources.GetObject("btnSairSistema.Image");
            btnSairSistema.ImageScaling = ToolStripItemImageScaling.None;
            btnSairSistema.ImageTransparentColor = Color.Magenta;
            btnSairSistema.Name = "btnSairSistema";
            btnSairSistema.Size = new Size(147, 36);
            btnSairSistema.Text = "Fechar Sistema";
            btnSairSistema.Visible = false;
            btnSairSistema.Click += btnSairSistema_Click;
            // 
            // btnAltearUsuario
            // 
            btnAltearUsuario.Alignment = ToolStripItemAlignment.Right;
            btnAltearUsuario.Image = (Image)resources.GetObject("btnAltearUsuario.Image");
            btnAltearUsuario.ImageScaling = ToolStripItemImageScaling.None;
            btnAltearUsuario.ImageTransparentColor = Color.Magenta;
            btnAltearUsuario.Name = "btnAltearUsuario";
            btnAltearUsuario.Padding = new Padding(10, 0, 0, 0);
            btnAltearUsuario.Size = new Size(174, 36);
            btnAltearUsuario.Text = "Trocar de usuário";
            btnAltearUsuario.Visible = false;
            btnAltearUsuario.Click += btnAltearUsuario_Click;
            // 
            // btnAjustarUsuario
            // 
            btnAjustarUsuario.Alignment = ToolStripItemAlignment.Right;
            btnAjustarUsuario.Image = (Image)resources.GetObject("btnAjustarUsuario.Image");
            btnAjustarUsuario.ImageScaling = ToolStripItemImageScaling.None;
            btnAjustarUsuario.ImageTransparentColor = Color.Magenta;
            btnAjustarUsuario.Name = "btnAjustarUsuario";
            btnAjustarUsuario.Padding = new Padding(10, 0, 0, 0);
            btnAjustarUsuario.Size = new Size(142, 36);
            btnAjustarUsuario.Text = "Ajustar Perfil";
            btnAjustarUsuario.Visible = false;
            btnAjustarUsuario.Click += btnAjustarUsuario_Click;
            // 
            // toolStrip2
            // 
            toolStrip2.BackColor = Color.Transparent;
            toolStrip2.Dock = DockStyle.Left;
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnGroupCadastros, btnAgendarServico, btnUsuarios });
            toolStrip2.Location = new Point(0, 25);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.RenderMode = ToolStripRenderMode.System;
            toolStrip2.Size = new Size(97, 561);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnGroupCadastros
            // 
            btnGroupCadastros.DropDownItems.AddRange(new ToolStripItem[] { btnClientes, btnVeiculos, btnMecanicos, btnServicos });
            btnGroupCadastros.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGroupCadastros.Image = (Image)resources.GetObject("btnGroupCadastros.Image");
            btnGroupCadastros.ImageScaling = ToolStripItemImageScaling.None;
            btnGroupCadastros.ImageTransparentColor = Color.Magenta;
            btnGroupCadastros.Name = "btnGroupCadastros";
            btnGroupCadastros.Size = new Size(94, 53);
            btnGroupCadastros.Text = "Cadastros";
            btnGroupCadastros.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGroupCadastros.Visible = false;
            // 
            // btnClientes
            // 
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(139, 22);
            btnClientes.Text = "Clientes";
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVeiculos
            // 
            btnVeiculos.Name = "btnVeiculos";
            btnVeiculos.Size = new Size(139, 22);
            btnVeiculos.Text = "Veiculos";
            btnVeiculos.Click += btnVeiculos_Click;
            // 
            // btnMecanicos
            // 
            btnMecanicos.Name = "btnMecanicos";
            btnMecanicos.Size = new Size(139, 22);
            btnMecanicos.Text = "Mecânicos";
            btnMecanicos.Click += btnMecanicos_Click;
            // 
            // btnServicos
            // 
            btnServicos.Name = "btnServicos";
            btnServicos.Size = new Size(139, 22);
            btnServicos.Text = "Serviços";
            btnServicos.Click += btnServicos_Click;
            // 
            // btnAgendarServico
            // 
            btnAgendarServico.Image = (Image)resources.GetObject("btnAgendarServico.Image");
            btnAgendarServico.ImageScaling = ToolStripItemImageScaling.None;
            btnAgendarServico.ImageTransparentColor = Color.Magenta;
            btnAgendarServico.Margin = new Padding(0, 15, 0, 2);
            btnAgendarServico.Name = "btnAgendarServico";
            btnAgendarServico.Size = new Size(94, 51);
            btnAgendarServico.Text = "Agendar serviço";
            btnAgendarServico.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgendarServico.Visible = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Alignment = ToolStripItemAlignment.Right;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            btnUsuarios.ImageTransparentColor = Color.Magenta;
            btnUsuarios.Margin = new Padding(0, 15, 0, 2);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(94, 51);
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUsuarios.Visible = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(toolStrip3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(97, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(911, 561);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // toolStrip3
            // 
            toolStrip3.Dock = DockStyle.Bottom;
            toolStrip3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            toolStrip3.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip3.Items.AddRange(new ToolStripItem[] { btnSuporteDev });
            toolStrip3.Location = new Point(3, 533);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Padding = new Padding(5, 2, 1, 2);
            toolStrip3.RenderMode = ToolStripRenderMode.System;
            toolStrip3.Size = new Size(905, 25);
            toolStrip3.TabIndex = 1;
            toolStrip3.Text = "toolStrip3";
            // 
            // btnSuporteDev
            // 
            btnSuporteDev.Alignment = ToolStripItemAlignment.Right;
            btnSuporteDev.Image = (Image)resources.GetObject("btnSuporteDev.Image");
            btnSuporteDev.ImageScaling = ToolStripItemImageScaling.None;
            btnSuporteDev.ImageTransparentColor = Color.Magenta;
            btnSuporteDev.Name = "btnSuporteDev";
            btnSuporteDev.Padding = new Padding(10, 0, 0, 0);
            btnSuporteDev.Size = new Size(309, 36);
            btnSuporteDev.Text = "Contato/ suporte com desenvolvedor";
            btnSuporteDev.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSuporteDev.Visible = false;
            btnSuporteDev.Click += btnSuporteDev_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 586);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "TelaPrincipal";
            Text = "Tela principal";
            WindowState = FormWindowState.Maximized;
            Load += TelaPrincipal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel lb_seja_bem_vindo;
        private ToolStrip toolStrip2;
        private ToolStripLabel lb_nome_usuario;
        private ToolStripButton btnSairSistema;
        private ToolStripButton btnAltearUsuario;
        private ToolStripDropDownButton btnGroupCadastros;
        private ToolStripMenuItem btnClientes;
        private ToolStripMenuItem btnVeiculos;
        private ToolStripMenuItem btnMecanicos;
        private ToolStripMenuItem btnServicos;
        private ToolStripButton btnAjustarUsuario;
        private GroupBox groupBox1;
        private ToolStripButton btnAgendarServico;
        private ToolStrip toolStrip3;
        private ToolStripButton btnSuporteDev;
        private ToolStripButton btnUsuarios;
    }
}