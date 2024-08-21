using Agendamento.Services.Domain.Entities;

namespace Agendamento.UI.Cadastros
{
    public partial class frmCadMarca : Form
    {
        public Marca oMarca { get; set; }

        public frmCadMarca()
        {
            InitializeComponent();
        }

        private void frmCadMarca_Load(object sender, EventArgs e)
        {
            this.binding();
        }

        private void binding()
        {
            txtFabricante.Text = oMarca.fabricante;
        }

        private void update()
        {
            oMarca.fabricante = txtFabricante.Text;
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
