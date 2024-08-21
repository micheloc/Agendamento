using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Application.Dto;
using Agendamento.Services.Data.Context.Interfaces;
using Agendamento.Services.Data.Repository._Base;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using System.Text;

namespace Agendamento.Services.Data.Repository;

public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(IDbContext dbContext) : base(dbContext)
    {
    }

    public UsuarioDto verificar_login(string acesso, string senha)
    {
        return Context.Set<Usuario>()
        .Where(u => u.acesso == acesso && u.senha == senha)
        .Select(u => new UsuarioDto { objID = u.objID, nome_usuario = u.nome })
        .SingleOrDefault();
    }
}
