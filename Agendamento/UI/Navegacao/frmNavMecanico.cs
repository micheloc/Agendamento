using Agendamento.Services.Application.AppService;
using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.UI.Cadastros;
using System.ComponentModel;

namespace Agendamento.UI.Navegacao;

public partial class frmNavMecanico : Form
{
    private readonly IEspecialidadeAppService _especialidadeAppService;
    private readonly IMecanicoAppService _mecanicoAppService;

    public frmNavMecanico(IEspecialidadeAppService especialidadeAppService, IMecanicoAppService mecanicoAppService)
    {
        InitializeComponent();
        this._especialidadeAppService = especialidadeAppService;
        this._mecanicoAppService = mecanicoAppService;
    }

    private MecanicoAux oMecanico { get; set; } = new MecanicoAux();

    private List<Especialidade> lstEspecialidade { get; set; }
    private List<MecanicoAux> lstMecanicos { get; set; }

    private void frmNavMecanico_Load(object sender, EventArgs e)
    {
        this.loadingEspecializacao();
        if (this.cmbEspecializacao.ComboBox.Items.Count > 0)
            this.cmbEspecializacao.ComboBox.SelectedIndex = 0;

        this.loading();
    }

    private void loadingEspecializacao()
    {
        lstEspecialidade = new List<Especialidade>();
        lstEspecialidade = _especialidadeAppService.GetAll().ToList();

        this.cmbEspecializacao.ComboBox.DataSource = lstEspecialidade.OrderBy(o => o.descricao).ToList();
        this.cmbEspecializacao.ComboBox.DisplayMember = "descricao";
        this.cmbEspecializacao.ComboBox.ValueMember = "objID";
    }

    private void loading()
    {
        if (cmbEspecializacao.ComboBox.Items.Count == 0)
            return;

        lstMecanicos = new List<MecanicoAux>();
        lstMecanicos = _mecanicoAppService.GetAllByEspecialidade(((Especialidade)cmbEspecializacao.ComboBox.SelectedItem).objID).ToList();

        BindingList<MecanicoAux> lst = new BindingList<MecanicoAux>(lstMecanicos);
        grdMecanico.DataSource = lst;
    }
    private void grdMecanico_SelectionChanged(object sender, EventArgs e)
    {
        oMecanico = new MecanicoAux();
        if (grdMecanico.SelectedRows.Count > 0)
        {
            oMecanico = ((MecanicoAux)grdMecanico.SelectedRows[0].DataBoundItem);
            btnEditarMecanico.Enabled = true;
            btnRemoverMecanico.Enabled = true;
        }
        else
        {
            btnEditarMecanico.Enabled = false;
            btnRemoverMecanico.Enabled = false;
        }
    }

    private void btnRegistrarMecanico_Click(object sender, EventArgs e)
    {
        frmCadMecanico frm = new frmCadMecanico(_especialidadeAppService);
        frm.oMecanico = new Mecanico();
        frm.oMecanico.objID = Guid.NewGuid();

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _mecanicoAppService.Add(frm.oMecanico);
            if (result.IsValid)
            {
                this.loadingEspecializacao();
                this.cmbEspecializacao.ComboBox.SelectedValue = frm.oMecanico.IdEspecialidade;

                this.loading();
            }
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEditarMecanico_Click(object sender, EventArgs e)
    {
        frmCadMecanico frm = new frmCadMecanico(_especialidadeAppService);
        frm.oMecanico = new Mecanico();
        frm.oMecanico = _mecanicoAppService.Find(oMecanico.objID);

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _mecanicoAppService.Update(frm.oMecanico);
            if (result.IsValid)
            {
                this.loadingEspecializacao();
                this.cmbEspecializacao.ComboBox.SelectedValue = frm.oMecanico.IdEspecialidade;

                this.loading();
            }
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnRemoverMecanico_Click(object sender, EventArgs e)
    {
        var message = MessageBox.Show("Deseja realmente apagar o item selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (message == DialogResult.Yes)
        {
            var mecanico = _mecanicoAppService.Find(oMecanico.objID);
            var result = _mecanicoAppService.Remove(mecanico);
            if (result.IsValid)
                this.loading();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        loading(); 
    }

    private void cmbEspecializacao_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.loading(); 
    }
}
