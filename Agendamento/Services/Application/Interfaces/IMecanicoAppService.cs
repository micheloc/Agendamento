using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Application.Interfaces._Base;
using Agendamento.Services.Domain.Entities;

namespace Agendamento.Services.Application.Interfaces;

public interface IMecanicoAppService : IAppService<Mecanico>
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="IdEspecialidade"></param>
    /// <returns></returns>
    List<MecanicoAux> GetAllByEspecialidade(Guid IdEspecialidade); 
}
