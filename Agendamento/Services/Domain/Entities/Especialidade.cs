namespace Agendamento.Services.Domain.Entities;
public class Especialidade
{
    public Guid objID { get; set; } 
    public string descricao { get; set; }       

    public virtual ICollection<Mecanico> Mecanicos { get; set; } 
}
