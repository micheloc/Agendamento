using Agendamento.Services.Domain.Entities;

namespace Agendamento.UI.Edited;
public partial class frmEditedCliente : Form
{
    public Cliente oCliente { get; set; }

    public frmEditedCliente()
    {
        InitializeComponent();
    }
    private void frmEditedCliente_Load(object sender, EventArgs e)
    {
        this.binding();
    }
    private void binding()
    {
        txtNome.Text = oCliente.nome;
        txtRegistro.Text = oCliente.cpf_cnpj;

        if (oCliente.tipo)
        {
            rdPF.Checked = true;
            rdPJ.Checked = false;
        }
        else
        {
            rdPF.Checked = false;
            rdPJ.Checked = true;
        }
    }
    private void update()
    {
        oCliente.nome = txtNome.Text;
        oCliente.cpf_cnpj = txtRegistro.Text;

        if (rdPF.Checked)
            oCliente.tipo = true;

        if (rdPJ.Checked)
            oCliente.tipo = false;
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
    private void rdPF_CheckedChanged(object sender, EventArgs e)
    {
        this.txtRegistro.Culture = new System.Globalization.CultureInfo("en-US");
        this.txtRegistro.Mask = "000.000.000-00";
    }
    private void rdPJ_CheckedChanged(object sender, EventArgs e)
    {
        this.txtRegistro.Culture = new System.Globalization.CultureInfo("en-US");
        this.txtRegistro.Mask = "00.000.000/0000-00";
    }
}
