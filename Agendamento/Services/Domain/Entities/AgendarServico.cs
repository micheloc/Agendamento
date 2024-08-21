namespace Agendamento.Services.Domain.Entities;
public class AgendarServico
{
    public Guid objID { get; set; } 
    public Guid IdServico { get; set; }     
    public Guid IdMecanico { get; set; }    
    public Guid IdUsuario { get; set; }
    public DateTime DataAgendamento { get; set; }

    public virtual Servico Servicos { get; set; }   
    public virtual Mecanico Mecanicos { get; set;  }    
    public virtual Usuario Usuarios { get; set; }       
}
