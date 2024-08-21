using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.Dto;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service;

namespace Agendamento.Services.Application.AppService;

public class UsuarioAppService : AppService<Usuario>, IUsuarioAppService
{
    private readonly IUsuarioService _usuarioServico;

    public UsuarioAppService(IUsuarioService appService)
        : base(appService)
    {
        _usuarioServico = appService;
    }

    public UsuarioDto verificar_login(string acesso, string senha)
    {
        return _usuarioServico.verificar_login(acesso, senha); 
    }

}
