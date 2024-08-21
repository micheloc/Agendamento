using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository._Base;

namespace Agendamento.Services.Domain.Interfaces.Repository;

public interface IServicoRepository : IRepository<Servico>
{
    List<ServicoAux> GetLstServicoByCategoria(Guid IdCategoria);
}
