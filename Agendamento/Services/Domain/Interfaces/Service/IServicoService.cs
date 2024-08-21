using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service._Base;

namespace Agendamento.Services.Domain.Interfaces.Service;

public interface IServicoService : IService<Servico>
{
    List<ServicoAux> GetLstServicoByCategoria(Guid IdCategoria);
}

