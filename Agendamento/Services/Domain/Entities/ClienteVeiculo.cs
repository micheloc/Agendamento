namespace Agendamento.Services.Domain.Entities;
public class ClienteVeiculo
{
    public Guid objID { get; set; }   
    public Guid IdCliente { get; set; } 
    public Guid IdVeiculo { get; set;  }    
    public string placa_veiculo { get; set; }     

    public virtual Cliente Clientes { get; set; }   
    public virtual Veiculo Veiculos { get; set; }       
}
