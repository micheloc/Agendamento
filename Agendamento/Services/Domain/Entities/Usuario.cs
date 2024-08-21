namespace Agendamento.Services.Domain.Entities;
public class Usuario
{
    public Guid objID { get; set; } 
    public string nome { get; set; }    
    public string senha { get; set; }   
    public string acesso { get; set; }      

    public virtual ICollection<AgendarServico> AgendarServicos { get; set; }    
    public virtual ICollection<UsuarioPermissao> UsuarioPermissao { get; set;  }    
}
