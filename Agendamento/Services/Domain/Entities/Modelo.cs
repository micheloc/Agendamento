namespace Agendamento.Services.Domain.Entities;
public class Modelo
{
    public Guid objID { get; set; } 
    public string descricao { get; set; }   

    public virtual ICollection<Veiculo> Veiculos { get; set; }
}
