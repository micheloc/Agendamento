using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service;

namespace Agendamento.Services.Application.AppService;

public class CorAppService : AppService<Cor >, ICorAppService
{
    private readonly ICorService _corService;

    public CorAppService(ICorService appService)
        : base(appService)
    {
        _corService = appService;
    }
}

