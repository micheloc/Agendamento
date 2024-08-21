namespace Agendamento.Services.Domain.Entities;
public class Veiculo
{
    public Guid objID { get; set; } 
    public Guid IdCor { get; set;  }    
    public Guid IdMArca { get; set; }   
    public Guid IdModelo { get; set; }  
    public string ano { get; set; } 

    public virtual Cor Cor { get; set; }    
    public virtual Modelo Modelo { get; set; }      
    public virtual Marca Marca { get; set; }    
    public virtual ICollection<ClienteVeiculo> ClienteVeiculos { get; set; }    
}
