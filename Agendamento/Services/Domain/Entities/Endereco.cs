namespace Agendamento.Services.Domain.Entities;
public class Endereco
{
    public Guid objID { get; set; } 
    public Guid IdCliente { get; set; }
    public string numero { get; set; }  
    public string logradouro { get; set; }  
    public string bairro { get; set; }  
    public string cep { get; set; } 
    public virtual Cliente Cliente { get; set; }    
}
