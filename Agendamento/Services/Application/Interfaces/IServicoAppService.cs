using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Application.Interfaces._Base;
using Agendamento.Services.Domain.Entities;

namespace Agendamento.Services.Application.Interfaces;

public interface IServicoAppService : IAppService<Servico>
{
    List<ServicoAux> GetLstServicoByCategoria(Guid IdCategoria); 
}


