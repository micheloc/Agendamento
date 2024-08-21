using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service._Base;

namespace Agendamento.Services.Domain.Interfaces.Service;
public interface IMecanicoService : IService<Mecanico>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="IdEspecialidade"></param>
    /// <returns></returns>
    List<MecanicoAux> GetAllByEspecialidade(Guid IdEspecialidade);
}
