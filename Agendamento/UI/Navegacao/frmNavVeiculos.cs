using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.UI.Cadastros;
using System.ComponentModel;

namespace Agendamento.UI.Navegacao;

public partial class frmNavVeiculos : Form
{
    public readonly ICorAppService _corAppService;
    public readonly IMarcaAppService _marcaAppService;
    public readonly IModeloAppService _modeloAppService;
    public readonly IVeiculoAppService _veiculoAppService;

    private VeiculoAux oVeiculo { get; set; }
    private List<VeiculoAux> lstVeiculo { get; set; }

    public frmNavVeiculos(
        ICorAppService corAppService,
        IMarcaAppService marcaAppService,
        IModeloAppService modeloAppService,
        IVeiculoAppService veiculoAppService
    )
    {
        InitializeComponent();
        this._corAppService = corAppService;
        this._marcaAppService = marcaAppService;
        this._modeloAppService = modeloAppService;
        this._veiculoAppService = veiculoAppService;
    }
    private void frmNavVeiculos_Load(object sender, EventArgs e)
    {
        this.loading();
    }
    private void loading()
    {
        lstVeiculo = new List<VeiculoAux>();
        lstVeiculo = _veiculoAppService.GetAllVeiculos().ToList();

        BindingList<VeiculoAux> bd_lst_saldo = new BindingList<VeiculoAux>(lstVeiculo);
        grdVeiculo.DataSource = bd_lst_saldo;
    }
    private void grdVeiculo_SelectionChanged(object sender, EventArgs e)
    {
        oVeiculo = new VeiculoAux();
        if (grdVeiculo.SelectedRows.Count > 0)
        {
            oVeiculo = ((VeiculoAux)grdVeiculo.SelectedRows[0].DataBoundItem);
            btnEditarVeiculo.Enabled = true;
            btnRemoverVeiculo.Enabled = true;
        }
        else
        {
            btnEditarVeiculo.Enabled = false;
            btnRemoverVeiculo.Enabled = false;
        }
    }
    private void btnRegistrarVeiculo_Click(object sender, EventArgs e)
    {
        frmCadVeiculo frm = new frmCadVeiculo(_marcaAppService, _modeloAppService, _corAppService);
        frm.oVeiculo = new Veiculo();
        frm.oVeiculo.objID = Guid.NewGuid();

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _veiculoAppService.Add(frm.oVeiculo);
            if (result.IsValid)
                this.loading();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnEditarVeiculo_Click(object sender, EventArgs e)
    {
        frmCadVeiculo frm = new frmCadVeiculo(_marcaAppService, _modeloAppService, _corAppService);
        frm.oVeiculo = new Veiculo();
        frm.oVeiculo = _veiculoAppService.Find(oVeiculo.objID);

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _veiculoAppService.Update(frm.oVeiculo);
            if (result.IsValid)
                this.loading();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnRemoverVeiculo_Click(object sender, EventArgs e)
    {
        var message = MessageBox.Show("Deseja realmente apagar o item selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (message == DialogResult.Yes)
        {
            var veiculo = _veiculoAppService.Find(oVeiculo.objID);

            var result = _veiculoAppService.Remove(veiculo);
            if (result.IsValid)
                this.loading();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


}
