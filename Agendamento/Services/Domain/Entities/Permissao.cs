namespace Agendamento.Services.Domain.Entities;
public class Permissao
{
    public Guid objID { get; set; } 
    public string display { get; set; } /// Representa a tela onde a ação será realizada. 'Tela principal'. 
    public string elemento { get; set; }  /// Representa o elemento ex: 'bt_grupo_cadastro' .... 

    public virtual ICollection<UsuarioPermissao> UsuarioPermissao { get; set; }
}
