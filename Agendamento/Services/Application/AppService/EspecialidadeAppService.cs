using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service;

namespace Agendamento.Services.Application.AppService;
public class EspecialidadeAppService : AppService<Especialidade>, IEspecialidadeAppService
{
    private readonly IEspecialidadeService _especialidadeService;

    public EspecialidadeAppService(IEspecialidadeService appService)
        : base(appService)
    {
        _especialidadeService = appService;
    }
}
