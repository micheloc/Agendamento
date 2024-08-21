using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service;

namespace Agendamento.Services.Application.AppService;

public class AgendaAppService : AppService<AgendarServico>, IAgendarServicoAppService
{
    private readonly IAgendarServicoService _agendarServico;

    public AgendaAppService(IAgendarServicoService appService)
        : base(appService)
    {
        _agendarServico = appService;
    }
}
