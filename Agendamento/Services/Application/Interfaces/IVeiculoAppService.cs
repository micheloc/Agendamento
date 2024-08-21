using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Application.Interfaces._Base;
using Agendamento.Services.Domain.Entities;

namespace Agendamento.Services.Application.Interfaces;

public interface IVeiculoAppService : IAppService<Veiculo>
{
    List<VeiculoAux> GetAllVeiculos(); 
}
