using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.UI.Cadastros;
using System.ComponentModel;

namespace Agendamento.UI.Navegacao;

public partial class frmNavMarca : Form
{
    private readonly IMarcaAppService _marcaAppService;
    private Marca oMarca { get; set; }
    private List<Marca> lstMarca { get; set; }

    public frmNavMarca(IMarcaAppService marcaAppService)
    {
        _marcaAppService = marcaAppService;
        InitializeComponent();
    }

    private void Marca_Load(object sender, EventArgs e)
    {
        this.loading();
    }

    private void loading()
    {
        lstMarca = new List<Marca>();
        lstMarca = _marcaAppService.GetAll().ToList();

        BindingList<Marca> bd_lst_saldo = new BindingList<Marca>(lstMarca);
        grdMarca.DataSource = bd_lst_saldo;
    }
    private void grdMarca_SelectionChanged_1(object sender, EventArgs e)
    {
        oMarca = new Marca();
        if (grdMarca.SelectedRows.Count > 0)
        {
            oMarca = ((Marca)grdMarca.SelectedRows[0].DataBoundItem);
            btnEditar.Enabled = true;
            btnRemover.Enabled = true;
        }
        else
        {
            btnEditar.Enabled = false;
            btnRemover.Enabled = false;
        }
    }
    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        frmCadMarca frm = new frmCadMarca();
        frm.oMarca = new Marca();

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _marcaAppService.Add(frm.oMarca);
            if (result.IsValid)
                this.loading();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnEditar_Click_1(object sender, EventArgs e)
    {
        frmCadMarca frm = new frmCadMarca();
        frm.oMarca = new Marca();
        frm.oMarca = oMarca;

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _marcaAppService.Update(frm.oMarca);
            if (result.IsValid)
                this.loading();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnRemover_Click_1(object sender, EventArgs e)
    {
        var message = MessageBox.Show("Deseja realmente apagar o item selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (message == DialogResult.Yes)
        {
            var result = _marcaAppService.Remove(oMarca);
            if (result.IsValid)
                this.loading();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
