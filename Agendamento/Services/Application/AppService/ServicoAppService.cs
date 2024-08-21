using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service;

namespace Agendamento.Services.Application.AppService;

public class ServicoAppService : AppService<Servico>, IServicoAppService
{
    private readonly IServicoService _servicoService;

    public ServicoAppService(IServicoService appService)
        : base(appService)
    {
        _servicoService = appService;
    }

    public List<ServicoAux> GetLstServicoByCategoria(Guid IdCategoria)
    {
        return _servicoService.GetLstServicoByCategoria(IdCategoria); 
    }
}
