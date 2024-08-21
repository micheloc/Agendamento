using Agendamento.Services.Domain.Entities;

namespace Agendamento.UI.Cadastros
{
    public partial class frmCadCategoria : Form
    {
        public Categoria oCategoria { get; set; }

        public frmCadCategoria()
        {
            InitializeComponent();
        }

        private void frmCadCategoria_Load(object sender, EventArgs e)
        {
            this.binding();
        }

        private void binding()
        {
            txtDescricao.Text = oCategoria.descricao;
        }
        private void update()
        {
            oCategoria.descricao = txtDescricao.Text;
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            this.update();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
