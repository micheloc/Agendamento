using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Data.Context.Interfaces;
using Agendamento.Services.Data.Repository._Base;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;

namespace Agendamento.Services.Data.Repository;

public class MecanicoRepository : RepositoryBase<Mecanico>, IMecanicoRepository
{
    public MecanicoRepository(IDbContext dbContext) : base(dbContext)
    {
    }

    public List<MecanicoAux> GetAllByEspecialidade(Guid IdEspecialidade)
    {
        var result = (from m in Context.Set<Mecanico>()
                      join e in Context.Set<Especialidade>() on m.IdEspecialidade equals e.objID
                      where m.IdEspecialidade == IdEspecialidade
                      select new MecanicoAux
                      {
                          objID = m.objID,
                          IdEspecialidade = m.IdEspecialidade,
                          nome = m.nome,
                          especialidade = e.descricao
                      }).ToList();

        return result;
    }
}
