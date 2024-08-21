using Agendamento.Services.Domain.Interfaces.Repository._Base;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Application.Auxiliar;

namespace Agendamento.Services.Domain.Interfaces.Repository;

public interface IVeiculoRepository : IRepository<Veiculo>
{
    List<VeiculoAux> GetAllVeiculos();
}
