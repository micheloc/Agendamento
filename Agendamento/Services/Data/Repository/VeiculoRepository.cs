using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Data.Context.Interfaces;
using Agendamento.Services.Data.Repository._Base;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;

namespace Agendamento.Services.Data.Repository;
public class VeiculoRepository : RepositoryBase<Veiculo>, IVeiculoRepository
{
    public VeiculoRepository(IDbContext dbContext) : base(dbContext)
    {
    }

    public List<VeiculoAux> GetAllVeiculos()
    {
        var result = (from vc in Context.Set<Veiculo>()
                      join mo in Context.Set<Modelo>() on vc.IdModelo equals mo.objID
                      join ma in Context.Set<Marca>() on vc.IdMArca equals ma.objID
                      join cr in Context.Set<Cor>() on vc.IdCor equals cr.objID
                      select new VeiculoAux
                      {
                          objID = vc.objID,
                          ano = vc.ano, 
                          cor = cr.descricao, 
                          modelo = mo.descricao, 
                          marca = ma.fabricante, 
                      }).ToList();
        return result;
    }
}