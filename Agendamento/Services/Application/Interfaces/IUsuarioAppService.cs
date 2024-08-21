﻿using Agendamento.Services.Application.Dto;
using Agendamento.Services.Application.Interfaces._Base;
using Agendamento.Services.Domain.Entities;

namespace Agendamento.Services.Application.Interfaces;

public interface IUsuarioAppService : IAppService<Usuario>
{
    /// <summary> Este método tem como objetivo carregar os dados referente ao usuário a partir do acesso e senha.   </summary>
    /// <param name="acesso">Refere-se ao dado de entrada ("LOGIN")</param>
    /// <param name="senha">Refere-se ao dado de entrada ("Senha informada pelo usuário")</param>
    /// <returns>Retorna um objeto do tipo usuário. </returns>
    public UsuarioDto verificar_login(string acesso, string senha); 
}


