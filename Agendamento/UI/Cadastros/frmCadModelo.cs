using Agendamento.Services.Domain.Entities;

namespace Agendamento.UI.Cadastros;
public partial class frmCadModelo : Form
{

    public Modelo oModelo { get; set; } = new Modelo();

    public frmCadModelo()
    {
        InitializeComponent();
    }

    private void frmCadModelo_Load(object sender, EventArgs e)
    {
        this.binding();
    }
    private void binding()
    {
        txtFabricante.Text = oModelo.descricao;
    }
    private void update()
    {
        oModelo.descricao = txtFabricante.Text;
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
