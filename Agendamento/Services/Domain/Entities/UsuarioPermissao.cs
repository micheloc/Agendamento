namespace Agendamento.Services.Domain.Entities;

public class UsuarioPermissao
{
    public Guid objID { get; set; }  
    public Guid IdUsuario { get; set; } 
    public Guid IdPermissao { get; set; } 

    public virtual Usuario usuario { get; set; }    
    public virtual Permissao permissao { get; set; }    
}
