using Agendamento.Services.Application.Dto;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services;

public class UsuarioService : Service<Usuario>, IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;
    public UsuarioService(IUsuarioRepository repository)
        : base(repository)
    {
        _usuarioRepository = repository;
    }

    public UsuarioDto verificar_login(string acesso, string senha)
    {
       return _usuarioRepository.verificar_login(acesso, senha);
    }
}
