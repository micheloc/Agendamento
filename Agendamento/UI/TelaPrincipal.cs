using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.UI.Cadastros;
using Agendamento.UI.Navegacao;

namespace Agendamento.UI
{
    public partial class TelaPrincipal : Form
    {
        private readonly IClienteAppService _clienteAppService;
        private readonly IContatoAppService _contatoAppService;
        private readonly IEnderecoAppService _enderecoAppService;
        private readonly IUsuarioAppService _usuarioAppService;

        private readonly IServicoAppService _servicoAppService;
        private readonly ICategoriaAppService _categoriaAppService;
        private readonly IEspecialidadeAppService _especialidadeAppService;
        private readonly IMecanicoAppService _mecanicoAppService;

        public readonly ICorAppService _corAppService;
        public readonly IMarcaAppService _marcaAppService;
        public readonly IModeloAppService _modeloAppService;
        public readonly IVeiculoAppService _veiculoAppService;

        public TelaPrincipal(IUsuarioAppService usuarioAppService, IClienteAppService clienteAppService, IEnderecoAppService enderecoAppService, IContatoAppService contatoAppService, IServicoAppService servicoAppService, ICategoriaAppService categoriaAppService, IEspecialidadeAppService especialidadeAppService, IMecanicoAppService mecanicoAppService, ICorAppService corAppService, IMarcaAppService marcaAppService, IModeloAppService modeloAppService, IVeiculoAppService veiculoAppService)
        {
            InitializeComponent();
            this._categoriaAppService = categoriaAppService;
            this._clienteAppService = clienteAppService;
            this._contatoAppService = contatoAppService;
            this._enderecoAppService = enderecoAppService;
            this._usuarioAppService = usuarioAppService;
            this._servicoAppService = servicoAppService;
            this._especialidadeAppService = especialidadeAppService;
            this._mecanicoAppService = mecanicoAppService;
            this._corAppService = corAppService;
            this._marcaAppService = marcaAppService;
            this._modeloAppService = modeloAppService;
            this._veiculoAppService = veiculoAppService;
        }

        public TelaPrincipal()
        {
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            this.loading_login();
        }

        private void loading_login()
        {
            Login frm = new Login(_usuarioAppService);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.btnGroupCadastros.Visible = true;

                this.btnAltearUsuario.Visible = true;
                this.btnSairSistema.Visible = true;
                this.btnAjustarUsuario.Visible = true;
                this.btnAgendarServico.Visible = true;   
                this.btnUsuarios.Visible = true;        

                this.btnSuporteDev.Visible = true;

                this.lb_seja_bem_vindo.Visible = true;
                this.lb_nome_usuario.Visible = true;

                lb_nome_usuario.Text = UsuarioAx.user.nome_usuario;
            }
        }

        private void btnAltearUsuario_Click(object sender, EventArgs e)
        {
            this.btnGroupCadastros.Visible = false;

            this.btnAltearUsuario.Visible = false;
            this.btnSairSistema.Visible = false;
            this.btnAjustarUsuario.Visible = false;
            this.btnAgendarServico.Visible = false;
            this.btnUsuarios.Visible = false;

            this.btnSuporteDev.Visible = false;

            this.lb_seja_bem_vindo.Visible = false;
            this.lb_nome_usuario.Visible = false;

            this.loading_login();
        }

        private void btnSairSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmNavCliente frm = new frmNavCliente(_clienteAppService, _enderecoAppService, _contatoAppService);
            frm.ShowDialog();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            frmNavServico frm = new frmNavServico(_categoriaAppService, _servicoAppService);
            frm.ShowDialog();
        }

        private void btnMecanicos_Click(object sender, EventArgs e)
        {
            frmNavMecanico frm = new frmNavMecanico(_especialidadeAppService, _mecanicoAppService);
            frm.ShowDialog();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            frmNavVeiculos frm = new frmNavVeiculos(_corAppService, _marcaAppService, _modeloAppService, _veiculoAppService);
            frm.ShowDialog();
        }

        private void btnSuporteDev_Click(object sender, EventArgs e)
        {
            var url = "https://api.whatsapp.com/send?phone=5561999386695";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            System.Diagnostics.Process.Start(psi);
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmCadUsuario frm = new frmCadUsuario();
            frm.ShowDialog(this); 
        }
        private void btnAjustarUsuario_Click(object sender, EventArgs e)
        {
            frmCadAdjustUser frm = new frmCadAdjustUser();
            frm.oUsuario = new Usuario();
            frm.oUsuario = _usuarioAppService.Find(UsuarioAx.user.objID);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var result = _usuarioAppService.Update(frm.oUsuario);
                if (result.IsValid)
                {
                    UsuarioAx.user = _usuarioAppService.verificar_login(frm.oUsuario.acesso, frm.oUsuario.senha);
                    lb_nome_usuario.Text = UsuarioAx.user.nome_usuario;

                    MessageBox.Show("Os dados do usuário foi atualizado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Não foi possivel realizar a atualização das informações do usuário!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

  
    }
}
