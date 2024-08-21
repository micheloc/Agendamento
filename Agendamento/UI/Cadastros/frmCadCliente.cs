using Agendamento.Services.Domain.Entities;
using System.ComponentModel;

namespace Agendamento.UI.Cadastros;
public partial class frmCadCliente : Form
{
    public Cliente oCliente { get; set; } = new Cliente();
    public Contato oContato { get; set; } = new Contato();
    public Endereco oEndereco { get; set; } = new Endereco();

    public List<Contato> lstContato { get; set; } = new List<Contato>();
    public List<Endereco> lstEndereco { get; set; } = new List<Endereco>();

    private List<Contato> oLstContato { get; set; } = new List<Contato>();
    private List<Endereco> oLstEndereco { get; set; } = new List<Endereco>();

    public frmCadCliente()
    {
        InitializeComponent();
    }
    private void frmCadCliente_Load_1(object sender, EventArgs e)
    {
        this.rdPF.Checked = true;
    }
    private void Update()
    {
        oCliente.nome = txtNome.Text;
        oCliente.cpf_cnpj = txtRegistro.Text;
        oCliente.tipo = this.rdPF.Checked ? true : false;


        lstEndereco = new List<Endereco>();
        lstEndereco.AddRange(oLstEndereco);

        lstContato = new List<Contato>();
        lstContato.AddRange(oLstContato);
    }

    private void grdEnderecos_SelectionChanged(object sender, EventArgs e)
    {
        oEndereco = new Endereco();
        if (grdEnderecos.SelectedRows.Count > 0)
            oEndereco = ((Endereco)grdEnderecos.SelectedRows[0].DataBoundItem);
    }

    private void grdContatos_SelectionChanged(object sender, EventArgs e)
    {
        oContato = new Contato();
        if (grdContatos.SelectedRows.Count > 0)
            oContato = ((Contato)grdContatos.SelectedRows[0].DataBoundItem);
    }

    private void loading_endereco()
    {
        BindingList<Endereco> lst = new BindingList<Endereco>(oLstEndereco);
        grdEnderecos.DataSource = lst;
    }
    private void loading_contato()
    {
        BindingList<Contato> lst = new BindingList<Contato>(oLstContato);
        grdContatos.DataSource = lst;
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        this.Update();
        this.DialogResult = DialogResult.OK;
    }
    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }

    #region CRUD Endereço
    private void btnAdicionarEndereco_Click(object sender, EventArgs e)
    {
        frmCadEndereco frm = new frmCadEndereco();
        frm.oEndereco = new Endereco();
        frm.oEndereco.objID = Guid.NewGuid();

        if (frm.ShowDialog() == DialogResult.OK)
        {
            oLstEndereco.Add(frm.oEndereco);
            this.loading_endereco();
        }
    }

    private void btnEditarEndereco_Click(object sender, EventArgs e)
    {
        frmCadEndereco frm = new frmCadEndereco();
        frm.oEndereco = new Endereco();
        frm.oEndereco = oEndereco;

        if (frm.ShowDialog() == DialogResult.OK)
        {
            Endereco end = oLstEndereco.FirstOrDefault(o => o.objID == oEndereco.objID);

            end.objID = frm.oEndereco.objID;
            end.IdCliente = frm.oEndereco.IdCliente;
            end.numero = frm.oEndereco.numero;
            end.logradouro = frm.oEndereco.logradouro;
            end.bairro = frm.oEndereco.bairro;
            end.cep = frm.oEndereco.cep;

            this.loading_endereco();
        }
    }

    private void btnRemoverEndereco_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Deseja realmente apagar o endereço informado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (DialogResult.Yes == result)
        {
            Endereco remove = oLstEndereco.FirstOrDefault(o => o.objID == oEndereco.objID);
            oLstEndereco.Remove(remove);

            this.oEndereco = null;

            this.loading_endereco();
        }
    }
    #endregion

    #region CRUD Contato
    private void btnAdicionarContato_Click(object sender, EventArgs e)
    {
        frmCadContato frm = new frmCadContato();
        frm.oContato = new Contato();
        frm.oContato.objID = Guid.NewGuid();

        if (frm.ShowDialog() == DialogResult.OK)
        {
            oLstContato.Add(frm.oContato);
            this.loading_contato();
        }
    }

    private void btnEditarContato_Click(object sender, EventArgs e)
    {
        frmCadContato frm = new frmCadContato();
        frm.oContato = oContato;

        if (frm.ShowDialog() == DialogResult.OK)
        {
            Contato end = oLstContato.FirstOrDefault(o => o.objID == oContato.objID);

            end.objID = frm.oContato.objID;
            end.IdCliente = frm.oContato.IdCliente;
            end.telefone = frm.oContato.telefone;
            end.celular = frm.oContato.celular;
            end.email = frm.oContato.email;

            this.loading_contato();
        }
    }

    private void btnRemoverContato_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Deseja realmente apagar o contato informado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (DialogResult.Yes == result)
        {
            Contato remove = oLstContato.FirstOrDefault(o => o.objID == oContato.objID);
            oLstContato.Remove(remove);

            this.oContato = null;
            this.loading_contato();
        }
    }

    #endregion

    private void rdPF_CheckedChanged(object sender, EventArgs e)
    {
        this.txtRegistro.Mask = "000.000.000-00";
    }

    private void rdPJ_CheckedChanged(object sender, EventArgs e)
    {
        this.txtRegistro.Mask = "00.000.000/0000-00";
    }
}
