namespace Agendamento.Services.Domain.Entities;
public class Contato
{
    public Contato()
    {
        objID = Guid.NewGuid();         
    }

    public Guid objID { get; set; } 
    public Guid IdCliente { get; set; } 
    public string telefone { get; set; }    
    public string celular { get; set; } 
    public string email { get; set; } 

    public virtual Cliente Cliente { get; set; }    
}
