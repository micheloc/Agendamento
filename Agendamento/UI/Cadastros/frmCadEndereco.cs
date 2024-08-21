using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Domain.Entities;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Agendamento.UI.Cadastros;
public partial class frmCadEndereco : Form
{
    public Endereco oEndereco { get; set; }
    public frmCadEndereco()
    {
        InitializeComponent();
    }
    private void frmCadEndereco_Load(object sender, EventArgs e)
    {
        this.txtCep.Culture = new System.Globalization.CultureInfo("en-US");
        this.txtCep.Mask = "00.000-000";

        this.bind();
    }
    private void bind()
    {
        txtCep.Text = oEndereco.cep;
        txtLogradouro.Text = oEndereco.logradouro;
        txtBairro.Text = oEndereco.bairro;
        txtNumero.Text = oEndereco.numero;
    }

    private void update()
    {
        oEndereco.cep = txtCep.Text;
        oEndereco.logradouro = txtLogradouro.Text;
        oEndereco.bairro = txtBairro.Text;
        oEndereco.numero = txtNumero.Text;
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        this.update();
        this.DialogResult = DialogResult.OK;
    }
    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }

    private void txtCep_TextChanged(object sender, EventArgs e)
    {
        this.cep_changed(); 
    }

    private async Task cep_changed()
    {
        string cep = RemoveSpecialCharacters(txtCep.Text);
        if (cep.Length == 8)
        {
            // Cria uma instância do HttpClient
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://viacep.com.br/ws/" + cep + "/json/");

            var content = await response.Content.ReadAsStringAsync();
            if (content.ToString().Contains("erro"))
                MessageBox.Show("CEP não foi localizado na base do 'viacep.com'. ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                EnderecoAux endereco = JsonSerializer.Deserialize<EnderecoAux>(content);
                txtLogradouro.Text = endereco.logradouro.ToUpper();
                txtBairro.Text = endereco.bairro.ToUpper();
            }
        }
    } 

    private string RemoveSpecialCharacters(string input)
    {
        return Regex.Replace(input, @"[^0-9]", string.Empty);
    }
}
