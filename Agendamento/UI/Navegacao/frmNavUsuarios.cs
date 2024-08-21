using Agendamento.UI.Cadastros;

namespace Agendamento.UI.Navegacao;

public partial class frmNavUsuarios : Form
{
    public frmNavUsuarios()
    {
        InitializeComponent();
    }

    private void btnRegistrarUsuario_Click(object sender, EventArgs e)
    {
        frmCadUsuario frm = new frmCadUsuario();
        frm.ShowDialog();
    }

    private void btnEditarUsuario_Click(object sender, EventArgs e)
    {
        frmCadUsuario frm = new frmCadUsuario();
        frm.ShowDialog();
    }

    private void btnRemoverUsuario_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Deseja realmente remover o registro selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {


        }
    }

    private void frmNavUsuarios_Load(object sender, EventArgs e)
    {

    }
}
