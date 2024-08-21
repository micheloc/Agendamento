using Agendamento.Services.Application.AppService;
using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.UI.Cadastros;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Agendamento.UI.Navegacao;

public partial class frmNavServico : Form
{
    private readonly ICategoriaAppService _categoriaAppService;
    private readonly IServicoAppService _servicoAppService;

    private ServicoAux oServico { get; set; } = new ServicoAux();  

    private List<Categoria> lstCategoria { get; set; }
    private List<ServicoAux> lstServico { get; set; }

    public frmNavServico(ICategoriaAppService categoriaAppService, IServicoAppService servicoAppService)
    {
        this._categoriaAppService = categoriaAppService;
        this._servicoAppService = servicoAppService;
        InitializeComponent();
    }

    private void frmNavServico_Load(object sender, EventArgs e)
    {
        this.loadingCategoria();
        this.cmbCategoria.ComboBox.SelectedIndex = 0;

        this.loadingServico();
    }

    private void loadingCategoria()
    {
        lstCategoria = new List<Categoria>();
        lstCategoria = _categoriaAppService.GetAll().ToList();

        this.cmbCategoria.ComboBox.DataSource = lstCategoria.OrderBy(o => o.descricao).ToList();
        this.cmbCategoria.ComboBox.DisplayMember = "descricao";
        this.cmbCategoria.ComboBox.ValueMember = "objID";
    }

    private void loadingServico()
    {
        if (this.cmbCategoria.Items.Count == 0)
            return;

        lstServico = new List<ServicoAux>();
        lstServico = _servicoAppService.GetLstServicoByCategoria(((Categoria)this.cmbCategoria.ComboBox.SelectedItem).objID);

        BindingList<ServicoAux> lst = new BindingList<ServicoAux>(lstServico);
        grdServico.DataSource = lst;
    }
    private void grdServico_SelectionChanged(object sender, EventArgs e)
    {
        oServico = new ServicoAux();
        if (grdServico.SelectedRows.Count > 0)
        {
            oServico = ((ServicoAux)grdServico.SelectedRows[0].DataBoundItem);
            btnEditarServico.Enabled = true;
            btnRemoverServico.Enabled = true;
        }
        else
        {
            btnEditarServico.Enabled = false;
            btnRemoverServico.Enabled = false;
        }
    }
    private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.loadingServico();
    }
    private void btnRegistrarCliente_Click(object sender, EventArgs e)
    {
        frmCadServico frm = new frmCadServico(_categoriaAppService);
        frm.oServico = new Servico();
        frm.oServico.objID = Guid.NewGuid();

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _servicoAppService.Add(frm.oServico);
            if (result.IsValid)
                this.loadingServico();
            else
                MessageBox.Show("Não foi possivel registrar o serviço!", "Alerta", MessageBoxButtons.OK);
        }
    }
    private void btnEditarServico_Click(object sender, EventArgs e)
    {
        frmCadServico frm = new frmCadServico(_categoriaAppService);
        frm.oServico = _servicoAppService.Find(oServico.objID);

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _servicoAppService.Update(frm.oServico);
            if (result.IsValid)
                this.loadingServico();
            else
                MessageBox.Show("Não foi possivel registrar o serviço!", "Alerta", MessageBoxButtons.OK);
        }
    }
    private void btnRemoverServico_Click(object sender, EventArgs e)
    {
        var message = MessageBox.Show("Deseja realmente apagar o item selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (message == DialogResult.Yes)
        {
            var servico = _servicoAppService.Find(oServico.objID);

            var result = _servicoAppService.Remove(servico);
            if (result.IsValid)
                this.loadingServico();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


}
