namespace Agendamento.Services.Domain.Entities;
public class Categoria
{
    public Guid objID { get; set; } 
    public string descricao { get; set; }   
    public virtual ICollection<Servico> Servicos { get; set; }
}
