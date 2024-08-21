using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Application.AppService;

namespace Agendamento.UI.Cadastros;
public partial class frmCadMecanico : Form
{
    private readonly IEspecialidadeAppService _especialidadeAppService;

    private List<Especialidade> lstEspecialidade { get; set; }

    public Mecanico oMecanico { get; set; } = new Mecanico();

    public frmCadMecanico(IEspecialidadeAppService especialidadeAppService)
    {
        InitializeComponent();
        this._especialidadeAppService = especialidadeAppService;
    }

    private void frmCadMecanico_Load(object sender, EventArgs e)
    {
        this.loadingEspecialidade();
        if (cmbEspecialidade.Items.Count > 0)
            cmbEspecialidade.SelectedIndex = 0;

        this.binding();
    }
    private void binding()
    {
        txtNomeMecanico.Text = oMecanico.nome;
        if (oMecanico.IdEspecialidade != null)
            cmbEspecialidade.SelectedItem = oMecanico.IdEspecialidade;

    }
    private void update()
    {
        oMecanico.nome = txtNomeMecanico.Text;
        oMecanico.IdEspecialidade = ((Especialidade)cmbEspecialidade.SelectedItem).objID;
    }
    private void loadingEspecialidade()
    {
        lstEspecialidade = new List<Especialidade>();
        lstEspecialidade = _especialidadeAppService.GetAll().ToList();

        this.cmbEspecialidade.DataSource = lstEspecialidade.OrderBy(o => o.descricao).ToList();
        this.cmbEspecialidade.DisplayMember = "descricao";
        this.cmbEspecialidade.ValueMember = "objID";
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
    private void btnRegistrarCategoria_Click(object sender, EventArgs e)
    {
        frmCadEspecialidade frm = new frmCadEspecialidade();
        frm.oEspecialidade = new Especialidade();
        frm.oEspecialidade.objID = Guid.NewGuid();

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _especialidadeAppService.Add(frm.oEspecialidade);
            if (result.IsValid)
            {
                this.loadingEspecialidade();
                this.cmbEspecialidade.SelectedValue = frm.oEspecialidade.objID; 
            }
            else
                MessageBox.Show("Não foi possivel realizar o cadastro da especialidade!", "Alerta", MessageBoxButtons.OK);

        }
    }
    private void btnEditarEspecialidade_Click(object sender, EventArgs e)
    {
        frmCadEspecialidade frm = new frmCadEspecialidade();
        frm.oEspecialidade = new Especialidade();
        frm.oEspecialidade = ((Especialidade)this.cmbEspecialidade.SelectedItem);
        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _especialidadeAppService.Update(frm.oEspecialidade);
            if (result.IsValid)
            {
                this.loadingEspecialidade();
                this.cmbEspecialidade.SelectedValue = frm.oEspecialidade.objID;
            }
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnRemoverEspecialidade_Click(object sender, EventArgs e)
    {
        var message = MessageBox.Show("Deseja realmente apagar o item selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (message == DialogResult.Yes)
        {
            var categoria = ((Especialidade)this.cmbEspecialidade.SelectedItem);

            var result = _especialidadeAppService.Remove(categoria);
            if (result.IsValid)
                this.loadingEspecialidade();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
