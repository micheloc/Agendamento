using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;

namespace Agendamento.UI.Cadastros;

public partial class frmCadCor : Form
{
    public Cor oCor { get; set; }

    public frmCadCor()
    {
        InitializeComponent();
    }

    private void frmCadCor_Load(object sender, EventArgs e)
    {
        this.binding();
    }

    private void binding()
    {
        txtDescricao.Text = oCor.descricao;
    }

    private void update()
    {
        oCor.descricao = txtDescricao.Text;
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
