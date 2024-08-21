using Agendamento.Services.Domain.Entities;

namespace Agendamento.UI.Cadastros;
public partial class frmCadContato : Form
{
    public Contato oContato { get; set; }

    public frmCadContato()
    {
        InitializeComponent();
    }

    private void frmCadContato_Load(object sender, EventArgs e)
    {
        this.binding();
    }

    private void binding()
    {
        txtEmail.Text = oContato.email;
        txtCelular.Text = oContato.celular;
        txtTelefone.Text = oContato.telefone;
    }

    private void update()
    {
        oContato.email = txtEmail.Text;
        oContato.celular = txtCelular.Text;
        oContato.telefone = txtTelefone.Text;
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
