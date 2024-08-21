namespace Agendamento.Services.Domain.Entities;
public class Cor
{
    public Guid objID { get; set; } 
    public string descricao { get; set; }   

    public virtual ICollection<Veiculo> Veiculos { get; set; }      
}
