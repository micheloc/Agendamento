using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using System.Windows.Forms;

namespace Agendamento.UI.Cadastros;
public partial class frmCadVeiculo : Form
{
    public Veiculo oVeiculo { get; set; } = new Veiculo();

    private List<Cor> lstCor { get; set; } = new List<Cor>();
    private List<Marca> lstMarca { get; set; } = new List<Marca>();
    private List<Modelo> lstModelos { get; set; } = new List<Modelo>();

    private readonly IMarcaAppService _marcaAppService;
    private readonly IModeloAppService _modeloAppService;
    private readonly ICorAppService _corAppService;

    public frmCadVeiculo(IMarcaAppService marcaAppService, IModeloAppService modeloAppService, ICorAppService corAppService)
    {
        InitializeComponent();
        this._marcaAppService = marcaAppService;
        this._modeloAppService = modeloAppService;
        this._corAppService = corAppService;
    }
    private void frmCadVeiculo_Load(object sender, EventArgs e)
    {
        this.loadingModelo();

        if (this.cmbModelo.Items.Count > 0)
            this.cmbModelo.SelectedIndex = 0;

        this.loadingMarca();

        if (this.cmbMarca.Items.Count > 0)
            this.cmbMarca.SelectedIndex = 0;

        this.loadingCor();

        if (this.cmbCor.Items.Count > 0)
            this.cmbCor.SelectedIndex = 0;

        this.binding();
    }

    private void loadingModelo()
    {
        lstModelos = new List<Modelo>();
        lstModelos = _modeloAppService.GetAll().ToList();

        this.cmbModelo.DataSource = lstModelos.OrderBy(o => o.descricao).ToList();
        this.cmbModelo.DisplayMember = "descricao";
        this.cmbModelo.ValueMember = "objID";
    }

    private void loadingMarca()
    {
        lstMarca = new List<Marca>();
        lstMarca = _marcaAppService.GetAll().ToList();

        this.cmbMarca.DataSource = lstMarca.OrderBy(o => o.fabricante).ToList();
        this.cmbMarca.DisplayMember = "fabricante";
        this.cmbMarca.ValueMember = "objID";
    }

    private void loadingCor()
    {
        lstCor = new List<Cor>();
        lstCor = _corAppService.GetAll().ToList();

        this.cmbCor.DataSource = lstCor.OrderBy(o => o.descricao).ToList();
        this.cmbCor.DisplayMember = "descricao";
        this.cmbCor.ValueMember = "objID";
    }

    public void binding()
    {
        if (oVeiculo.IdModelo != Guid.Empty)
            cmbModelo.SelectedValue = oVeiculo.IdModelo;

        if (oVeiculo.IdMArca != Guid.Empty)
            cmbMarca.SelectedValue = oVeiculo.IdMArca;

        if (oVeiculo.IdCor != Guid.Empty)
            cmbCor.SelectedValue = oVeiculo.IdCor;

        txtAno.Text = oVeiculo.ano;
    }
    public void update()
    {
        oVeiculo.IdModelo = ((Modelo)cmbModelo.SelectedItem).objID;
        oVeiculo.IdMArca = ((Marca)cmbMarca.SelectedItem).objID;
        oVeiculo.IdCor = ((Cor)cmbCor.SelectedItem).objID;
        oVeiculo.ano = txtAno.Text;
    }

    #region CRUD referente ao combo box modelo
    private void btnAdicionarModelo_Click(object sender, EventArgs e)
    {
        frmCadModelo frm = new frmCadModelo();
        frm.oModelo = new Modelo();
        frm.oModelo.objID = Guid.NewGuid();

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _modeloAppService.Add(frm.oModelo);
            if (result.IsValid)
            {
                this.loadingModelo();
                this.cmbModelo.SelectedValue = frm.oModelo.objID;
            }
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnEditarModelo_Click(object sender, EventArgs e)
    {
        frmCadModelo frm = new frmCadModelo();
        frm.oModelo = new Modelo();
        frm.oModelo = ((Modelo)cmbModelo.SelectedItem);

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _modeloAppService.Update(frm.oModelo);
            if (result.IsValid)
            {
                this.loadingModelo();
                this.cmbModelo.SelectedValue = frm.oModelo.objID;
            }
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnRemoverModelo_Click(object sender, EventArgs e)
    {
        var message = MessageBox.Show("Deseja realmente apagar o item selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (message == DialogResult.Yes)
        {
            var result = _modeloAppService.Remove(((Modelo)cmbModelo.SelectedItem));
            if (result.IsValid)
                this.loadingModelo();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    #endregion

    #region CRUD referente ao combo box cor.
    private void btnAdicionarCor_Click(object sender, EventArgs e)
    {
        frmCadCor frm = new frmCadCor();
        frm.oCor = new Cor();
        frm.oCor.objID = Guid.NewGuid();

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _corAppService.Add(frm.oCor);
            if (result.IsValid)
            {
                this.loadingCor();
                this.cmbCor.SelectedValue = frm.oCor.objID;
            }
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnEditarCor_Click(object sender, EventArgs e)
    {
        frmCadCor frm = new frmCadCor();
        frm.oCor = new Cor();
        frm.oCor = ((Cor)cmbCor.SelectedItem);

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _corAppService.Update(frm.oCor);
            if (result.IsValid)
            {
                this.loadingCor();
                this.cmbCor.SelectedValue = frm.oCor.objID;
            }
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnRemoverCor_Click(object sender, EventArgs e)
    {
        var message = MessageBox.Show("Deseja realmente apagar o item selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (message == DialogResult.Yes)
        {
            var result = _corAppService.Remove(((Cor)cmbCor.SelectedItem));
            if (result.IsValid)
            {
                this.loadingCor();
            }
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    #endregion

    #region  CRUD referente ao combo box marca.
    private void btnAdicionarMarca_Click(object sender, EventArgs e)
    {
        frmCadMarca frm = new frmCadMarca();
        frm.oMarca = new Marca();
        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _marcaAppService.Add(frm.oMarca);
            if (result.IsValid)
            {
                this.loadingMarca();
                this.cmbMarca.SelectedValue = frm.oMarca.objID;
            }
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEditarMarca_Click(object sender, EventArgs e)
    {
        frmCadMarca frm = new frmCadMarca();
        frm.oMarca = new Marca();
        frm.oMarca = ((Marca)cmbMarca.SelectedItem);

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _marcaAppService.Update(frm.oMarca);
            if (result.IsValid)
            {
                this.loadingMarca();
                this.cmbMarca.SelectedValue = frm.oMarca.objID;
            }
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnRemoverMarca_Click(object sender, EventArgs e)
    {
        var message = MessageBox.Show("Deseja realmente apagar o item selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (message == DialogResult.Yes)
        {
            var result = _marcaAppService.Remove(((Marca)cmbMarca.SelectedItem));
            if (result.IsValid)
                this.loadingMarca();
            else
                MessageBox.Show("Ocorreu algum erro na transação, contate o administrador!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    #endregion

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        this.update();
        this.DialogResult = DialogResult.OK;
    }
    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }


}
