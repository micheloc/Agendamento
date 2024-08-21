using Agendamento.Services.Application.Dto;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.UI.Cadastros;
using System.ComponentModel;

namespace Agendamento.UI.Navegacao;

public partial class frmNavCor : Form
{
    private readonly ICorAppService _corAppService;
    private Cor oCor { get; set; }
    private List<Cor> lstCor { get; set; }


    public frmNavCor(ICorAppService corAppService)
    {
        _corAppService = corAppService;
        InitializeComponent();
    }

    private void frmNavCor_Load(object sender, EventArgs e)
    {
        this.loading();
    }

    private void loading()
    {
        lstCor = new List<Cor>();
        lstCor = _corAppService.GetAll().ToList();

        if (lstCor.Count == 0)
            return; 

        BindingList<Cor> bd_lst_saldo = new BindingList<Cor>(lstCor);
        grdCor.DataSource = bd_lst_saldo;
    }
    private void grdCor_SelectionChanged(object sender, EventArgs e)
    {
        oCor = new Cor();
        if (grdCor.SelectedRows.Count > 0)
        {
            oCor = ((Cor)grdCor.SelectedRows[0].DataBoundItem);
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
        frmCadCor frm = new frmCadCor();
        frm.oCor = new Cor();

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _corAppService.Add(frm.oCor);
            if (result.IsValid)
                this.loading();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        frmCadCor frm = new frmCadCor();
        frm.oCor = new Cor();
        frm.oCor = oCor;

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _corAppService.Update(frm.oCor);
            if (result.IsValid)
                this.loading();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnRemover_Click(object sender, EventArgs e)
    {
        var message = MessageBox.Show("Deseja realmente apagar o item selecionado?","Alerta",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (message == DialogResult.Yes)
        {
            var result = _corAppService.Remove(oCor);
            if (result.IsValid)
                this.loading();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
