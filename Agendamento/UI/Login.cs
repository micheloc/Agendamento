using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Application.Interfaces;

namespace Agendamento.UI;
public partial class Login : Form
{
    private readonly IUsuarioAppService _usuarioAppService;

    // Construtor com o parâmetro opcional
    public Login(IUsuarioAppService usuarioAppService)
    {
        _usuarioAppService = usuarioAppService;
        InitializeComponent();
    }
    private bool checked_user()
    {
        UsuarioAx.user = _usuarioAppService.verificar_login(txtAcesso.Text, txtSenha.Text);
        if (UsuarioAx.user != null)
            return true;
        else
            return false;
    }
    private void onStarted()
    {
        if (checked_user())
            this.DialogResult = DialogResult.OK;
        else
            MessageBox.Show("O Usuário ou senha inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    private void onExit()
    {
        Application.Exit();
    }
    private void btnAcessar_Click(object sender, EventArgs e)
    {
        this.onStarted();
    }
    private void btnSair_Click(object sender, EventArgs e)
    {
        this.onExit();
    }
    private void txtAcesso_Enter(object sender, EventArgs e)
    {
        this.txtAcesso.Text = "";
        this.txtAcesso.ForeColor = Color.Black;
    }
    private void txtSenha_Enter(object sender, EventArgs e)
    {
        this.txtSenha.Text = "";
        this.txtSenha.ForeColor = Color.Black;
    }
    private void Login_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Convert.ToInt32(e.KeyChar) == 13)
            this.onStarted();

        if (Convert.ToInt32(e.KeyChar) == 27)
            this.onExit();
    }
}
