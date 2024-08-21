using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.UI.Cadastros;
using Agendamento.UI.Edited;
using System.ComponentModel;

namespace Agendamento.UI.Navegacao;

public partial class frmNavCliente : Form
{
    private readonly IClienteAppService _clienteAppService;
    private readonly IEnderecoAppService _enderecoAppService;
    private readonly IContatoAppService _contatoAppService;

    private Cliente oCliente { get; set; } = new Cliente();
    private Endereco oEndereco { get; set; } = new Endereco();
    private Contato oContato { get; set; } = new Contato();

    private List<Cliente> oLstCliente { get; set; } = new List<Cliente>();
    private List<Endereco> oLstEndereco { get; set; } = new List<Endereco>();
    private List<Contato> oLstContatos { get; set; } = new List<Contato>();

    public frmNavCliente(IClienteAppService clienteAppService, IEnderecoAppService enderecoAppService, IContatoAppService contatoAppService)
    {
        InitializeComponent();
        this._clienteAppService = clienteAppService;
        this._contatoAppService = contatoAppService;
        this._enderecoAppService = enderecoAppService;
    }

    private void frmNavCliente_Load(object sender, EventArgs e)
    {
        this.loading_cliente();
    }
    private void loading_cliente()
    {
        oLstCliente = new List<Cliente>();
        oLstCliente = _clienteAppService.GetAll().ToList();

        BindingList<Cliente> lst = new BindingList<Cliente>(oLstCliente);
        grdCliente.DataSource = lst;
    }
    private void grdCliente_SelectionChanged(object sender, EventArgs e)
    {
        oCliente = new Cliente();
        if (grdCliente.SelectedRows.Count > 0)
        {
            oCliente = ((Cliente)grdCliente.SelectedRows[0].DataBoundItem);

            btnEditarCliente.Enabled = true;
            btnRemoverCliente.Enabled = true;

            btnRegistrarEndereco.Enabled = true;
            btnRegistrarContato.Enabled = true;

            this.loading_endereco();
            this.loading_contato();
        }
        else
        {
            btnEditarCliente.Enabled = false;
            btnRemoverCliente.Enabled = false;

            btnRegistrarEndereco.Enabled = false;
            btnRegistrarContato.Enabled = false;

            oCliente = null;
        }
    }
    private void grdEnderecos_SelectionChanged(object sender, EventArgs e)
    {
        oEndereco = new Endereco();
        if (grdEnderecos.SelectedRows.Count > 0)
        {
            oEndereco = ((Endereco)grdEnderecos.SelectedRows[0].DataBoundItem);

            btnEditarEnderecos.Enabled = true;
            btnRemoverEnderecos.Enabled = true;
        }
        else
        {
            btnEditarEnderecos.Enabled = false;
            btnRemoverEnderecos.Enabled = false;
            oEndereco = null;
        }
    }
    private void grdContatos_SelectionChanged(object sender, EventArgs e)
    {
        oContato = new Contato(); 
        if (grdContatos.SelectedRows.Count > 0)
        {
            oContato = ((Contato)grdContatos.SelectedRows[0].DataBoundItem);
            btnEditarContatos.Enabled = true;
            btnRemoverContatos.Enabled = true;
        }
        else
        {
            oContato = null; 
            btnEditarContatos.Enabled = false;
            btnRemoverContatos.Enabled = false;
        }
    }

    private void loading_endereco()
    {
        oLstEndereco = new List<Endereco>();
        oLstEndereco = _enderecoAppService.GetAll().Where(o => o.IdCliente.ToString().ToUpper().Equals(oCliente.objID.ToString().ToUpper())).ToList();

        BindingList<Endereco> lst = new BindingList<Endereco>(oLstEndereco);
        grdEnderecos.DataSource = lst;
    }
    private void loading_contato()
    {
        oLstContatos = new List<Contato>();
        oLstContatos = _contatoAppService.GetAll().Where(o => o.IdCliente.ToString().ToUpper().Equals(oCliente.objID.ToString().ToUpper())).ToList();

        BindingList<Contato> lst = new BindingList<Contato>(oLstContatos);
        grdContatos.DataSource = lst;
    }

    #region CRUD cliente. 
    private void btnRegistrarCliente_Click(object sender, EventArgs e)
    {
        frmCadCliente frm = new frmCadCliente();
        if (frm.ShowDialog() == DialogResult.OK)
        {
            var cliente_result = _clienteAppService.Add(frm.oCliente);
            if (cliente_result.IsValid)
            {
                foreach (var item in frm.lstEndereco)
                {
                    item.IdCliente = frm.oCliente.objID;

                    var endereco_result = _enderecoAppService.Add(item);
                    if (endereco_result.IsValid)
                        Console.WriteLine("endereço registrado");
                }

                foreach (var item in frm.lstContato)
                {
                    item.IdCliente = frm.oCliente.objID;
                    var contato_result = _contatoAppService.Add(item);
                    if (contato_result.IsValid)
                        Console.WriteLine("contato registrado");
                }
            }

            this.loading_cliente();
        }
    }
    private void btnEditarCliente_Click(object sender, EventArgs e)
    {
        frmEditedCliente frm = new frmEditedCliente();
        frm.oCliente = new Cliente();
        frm.oCliente = oCliente;

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _clienteAppService.Update(frm.oCliente);

            if (result.IsValid)
            {
                this.loading_cliente();
            }
        }
    }
    private void btnRemoverCliente_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Deseja realmente excluir o dado selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            var remove_result = _clienteAppService.Remove(oCliente);

            if (remove_result.IsValid)
            {
                MessageBox.Show("O Cliente foi excluido com sucesso!", "Alerta", MessageBoxButtons.OK);
                this.loading_cliente();
            }
            else
                MessageBox.Show("Não foi possível remover o registro, pois ele contem dados vinculado.");
        }
    }
    #endregion

    #region Crud endereço
    private void btnRegistrarEndereco_Click(object sender, EventArgs e)
    {
        frmCadEndereco frm = new frmCadEndereco();
        frm.oEndereco = new Endereco();
        frm.oEndereco.objID = Guid.NewGuid();

        if (frm.ShowDialog() == DialogResult.OK)
        {
            frm.oEndereco.IdCliente = oCliente.objID;

            var result = _enderecoAppService.Add(frm.oEndereco);
            if (result.IsValid)
                this.loading_endereco();
            else
                MessageBox.Show("Não foi possível realizar o cadastro do endereço!");
        }
    }
    private void btnEditarEnderecos_Click(object sender, EventArgs e)
    {
        frmCadEndereco frm = new frmCadEndereco();
        frm.oEndereco = new Endereco();
        frm.oEndereco = oEndereco;

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _enderecoAppService.Update(frm.oEndereco);
            if (result.IsValid)
                this.loading_endereco();
            else
                MessageBox.Show("Não foi possível realizar a atualização do endereço!");

        }
    }
    private void btnRemoverEnderecos_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Deseja realmente apagar o registro selecionado? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (DialogResult.Yes == result)
        {
            var remove_result = _enderecoAppService.Remove(oEndereco);
            if (remove_result.IsValid)
                this.loading_endereco();
            else
                MessageBox.Show("Não foi possível excluir do endereço!");

        }
    }
    #endregion

    #region CRUD Contato
    private void btnRegistrarContato_Click(object sender, EventArgs e)
    {
        frmCadContato frm = new frmCadContato();
        frm.oContato = new Contato();
        frm.oContato.objID = Guid.NewGuid();
        frm.oContato.IdCliente = oCliente.objID;

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var result = _contatoAppService.Add(frm.oContato);
            if (result.IsValid)
                this.loading_contato();
            else
                MessageBox.Show("Não foi possível realizar o cadastro do contato!");
        }
    }

    private void btnEditarContatos_Click(object sender, EventArgs e)
    {
        frmCadContato frm = new frmCadContato();
        frm.oContato = oContato;

        if (frm.ShowDialog() == DialogResult.OK)
        {
            var remove_result = _contatoAppService.Remove(frm.oContato);
            if (remove_result.IsValid)
                this.loading_contato();
            else
                MessageBox.Show("Não foi possível realizar a edição do contato!");
        }
    }

    private void btnRemoverContatos_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Deseja realmente apagar o contato informado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (DialogResult.Yes == result)
        {
            var remove_result = _contatoAppService.Remove(oContato);
            if (remove_result.IsValid)
                this.loading_contato();
            else
                MessageBox.Show("Não foi possível excluir o contato!");

        }
    }
    #endregion
}
