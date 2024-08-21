using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.UI.Cadastros;
using System.ComponentModel;

namespace Agendamento.UI.Navegacao;
public partial class frmNavCategoria : Form
{
    private readonly ICategoriaAppService _categoriaAppService;
    private Categoria oCategoria { get; set; }
    private List<Categoria> lstCategoria { get; set; }

    public frmNavCategoria(ICategoriaAppService categoriaAppService)
    {
        _categoriaAppService = categoriaAppService;
        InitializeComponent();
    }
    private void frmNavCategoria_Load(object sender, EventArgs e)
    {
        this.loading();
    }
    private void loading()
    {
        lstCategoria = new List<Categoria>();
        lstCategoria = _categoriaAppService.GetAll().ToList();

        BindingList<Categoria> bd_lst_saldo = new BindingList<Categoria>(lstCategoria);
        grdCategorias.DataSource = bd_lst_saldo;
    }
    private void grdCategorias_SelectionChanged(object sender, EventArgs e)
    {
        oCategoria = new Categoria();
        if (grdCategorias.SelectedRows.Count > 0)
        {
            oCategoria = ((Categoria)grdCategorias.SelectedRows[0].DataBoundItem);
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
        frmCadCategoria frm = new frmCadCategoria();
        frm.oCategoria = new Categoria();

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _categoriaAppService.Add(frm.oCategoria);
            if (result.IsValid)
                this.loading();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        frmCadCategoria frm = new frmCadCategoria();
        frm.oCategoria = new Categoria();
        frm.oCategoria = oCategoria;

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _categoriaAppService.Update(frm.oCategoria);
            if (result.IsValid)
                this.loading();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnRemover_Click(object sender, EventArgs e)
    {
        var message = MessageBox.Show("Deseja realmente apagar o item selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (message == DialogResult.Yes)
        {
            var result = _categoriaAppService.Remove(oCategoria);
            if (result.IsValid)
                this.loading();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


}
