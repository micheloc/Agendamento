using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using System.Data;

namespace Agendamento.UI.Cadastros;

public partial class frmCadServico : Form
{
    public Servico oServico { get; set; } = new Servico(); 

    private ICategoriaAppService _categoriaAppService;
    private List<Categoria> lstCategoria { get; set; } = new List<Categoria>();

    public frmCadServico(ICategoriaAppService categoriaAppService)
    {
        InitializeComponent();
        _categoriaAppService = categoriaAppService;
    }

    private void frmCadServico_Load(object sender, EventArgs e)
    {
        this.loadingCategoria();
        this.binding(); 
    }

    private void loadingCategoria()
    {
        lstCategoria = new List<Categoria>();
        lstCategoria = _categoriaAppService.GetAll().ToList();

        this.cmbCategoria.DataSource = lstCategoria.OrderBy(o => o.descricao).ToList();
        this.cmbCategoria.DisplayMember = "descricao";
        this.cmbCategoria.ValueMember = "objID";
    }

    private void binding()
    {
        this.cmbCategoria.SelectedValue = oServico.IdCategoria;
        this.txtCusto.Text = oServico.custo.ToString();
        if (oServico.tempo != null)
            this.dtTimeService.Text = oServico.tempo.ToString();
    }
    private void update()
    {
        this.oServico.IdCategoria = Guid.Parse(this.cmbCategoria.SelectedValue.ToString());
        this.oServico.custo = decimal.Parse(this.txtCusto.Text);
        this.oServico.tempo = this.dtTimeService.Text;
    }

    private void btnEditarCategoria_Click(object sender, EventArgs e)
    {
        frmCadCategoria frm = new frmCadCategoria();
        frm.oCategoria = new Categoria();
        frm.oCategoria = ((Categoria)this.cmbCategoria.SelectedItem);
        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _categoriaAppService.Update(frm.oCategoria);
            if (result.IsValid)
                this.loadingCategoria();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnRemoverCategoria_Click(object sender, EventArgs e)
    {
        var message = MessageBox.Show("Deseja realmente apagar o item selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (message == DialogResult.Yes)
        {
            var categoria = ((Categoria)this.cmbCategoria.SelectedItem);

            var result = _categoriaAppService.Remove(categoria);
            if (result.IsValid)
                this.loadingCategoria();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnRegistrarCategoria_Click(object sender, EventArgs e)
    {
        frmCadCategoria frm = new frmCadCategoria();
        frm.oCategoria = new Categoria();
        frm.oCategoria.objID = Guid.NewGuid(); 

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _categoriaAppService.Add(frm.oCategoria);
            if (result.IsValid)
            {
                this.loadingCategoria();
                this.cmbCategoria.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnCadastrar_Click_1(object sender, EventArgs e)
    {
        this.update();
        this.DialogResult = DialogResult.OK;
    }
    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }

 
}
