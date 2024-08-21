using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository._Base;

namespace Agendamento.Services.Domain.Interfaces.Repository;

public interface IMecanicoRepository : IRepository<Mecanico>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="IdEspecialidade"></param>
    /// <returns></returns>
    List<MecanicoAux> GetAllByEspecialidade(Guid IdEspecialidade);
}
