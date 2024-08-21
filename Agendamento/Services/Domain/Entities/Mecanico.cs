namespace Agendamento.Services.Domain.Entities;
public class Mecanico
{
    public Guid objID { get; set; }  
    public Guid IdEspecialidade { get; set; }   
    public string nome { get; set; }        

    public virtual Especialidade Especialidade { get; set; }
    public virtual ICollection<AgendarServico> AgendarServicos { get; set;}  
}
