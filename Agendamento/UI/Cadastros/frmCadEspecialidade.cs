using Agendamento.Services.Domain.Entities;

namespace Agendamento.UI.Cadastros;

public partial class frmCadEspecialidade : Form
{
    public Especialidade oEspecialidade { get; set; }

    public frmCadEspecialidade()
    {
        InitializeComponent();
    }

    private void frmCadEspecialidade_Load(object sender, EventArgs e)
    {
        this.binding();
    }
    private void binding()
    {
        this.txtEspecialidade.Text = this.oEspecialidade.descricao;
    }
    private void update()
    {
        this.oEspecialidade.descricao = this.txtEspecialidade.Text;
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        this.update();
        this.DialogResult = DialogResult.OK;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel; 
    }
}
