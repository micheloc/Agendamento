using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;

namespace Agendamento.UI.Cadastros;
public partial class frmCadAdjustUser : Form
{
    public Usuario oUsuario { get; set; }

    private readonly IUsuarioAppService _usuarioAppService;

    public frmCadAdjustUser()
    {
        InitializeComponent();
    }

    private void frmCadAdjustUser_Load(object sender, EventArgs e)
    {
        this.binding();
    }

    private void binding()
    {
        txtNome.Text = oUsuario.nome;
        txtAcesso.Text = oUsuario.acesso;
        txtSenha.Text = oUsuario.senha;
    }

    private void update()
    {
        oUsuario.nome = txtNome.Text;
        oUsuario.acesso = txtAcesso.Text;
        oUsuario.senha = txtSenha.Text;
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        this.update();
        this.DialogResult = DialogResult.OK; 
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.DialogResult= DialogResult.Cancel;     
    }
}
