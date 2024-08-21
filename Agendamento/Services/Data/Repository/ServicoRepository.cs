using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Data.Context.Interfaces;
using Agendamento.Services.Data.Repository._Base;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;

namespace Agendamento.Services.Data.Repository;

public class ServicoRepository : RepositoryBase<Servico>, IServicoRepository
{
    public ServicoRepository(IDbContext dbContext) : base(dbContext)
    {
    }

    public List<ServicoAux> GetLstServicoByCategoria(Guid IdCategoria)
    {
        var result = (from s in Context.Set<Servico>()
                      join c in Context.Set<Categoria>() on s.IdCategoria equals c.objID
                      where s.IdCategoria == IdCategoria
                      select new ServicoAux
                      {
                          objID = s.objID,
                          IdCategoria = c.objID,
                          categoriaDesc = c.descricao,
                          custo = s.custo,
                          tempo = s.tempo
                      }).ToList();

        return result;
    }

}
