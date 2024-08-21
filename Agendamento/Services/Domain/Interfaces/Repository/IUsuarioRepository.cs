using Agendamento.Services.Application.Dto;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository._Base;

namespace Agendamento.Services.Domain.Interfaces.Repository;

public interface IUsuarioRepository : IRepository<Usuario>
{
    /// <summary> Este método tem como objetivo carregar os dados referente ao usuário a partir do acesso e senha.   </summary>
    /// <param name="acesso">Refere-se ao dado de entrada ("LOGIN")</param>
    /// <param name="senha">Refere-se ao dado de entrada ("Senha informada pelo usuário")</param>
    /// <returns>Retorna um objeto do tipo usuário. </returns>
    public UsuarioDto verificar_login(string acesso, string senha);
}

