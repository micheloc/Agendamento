namespace Agendamento.Services.Domain.Entities;
public class Cliente
{
    public Cliente()
    {
        objID = Guid.NewGuid();         
    }
    
    public Guid objID { get; set;}   
    public string nome { get; set; }    
    public Boolean tipo { get; set; }  
    public string cpf_cnpj { get; set; }    
 
    public virtual ICollection<Endereco> Enderecos { get; set; }    
    public virtual ICollection<Contato> Contatos { get; set; }
    public virtual ICollection<ClienteVeiculo> ClienteVeiculos { get; set; }
}
