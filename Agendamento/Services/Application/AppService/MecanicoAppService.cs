using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service;

namespace Agendamento.Services.Application.AppService;

public class MecanicoAppService : AppService<Mecanico>, IMecanicoAppService
{
    private readonly IMecanicoService _mecanicoService;

    public MecanicoAppService(IMecanicoService appService)
        : base(appService)
    {
        _mecanicoService = appService;
    }

    public List<MecanicoAux> GetAllByEspecialidade(Guid IdEspecialidade)
    {
        return _mecanicoService.GetAllByEspecialidade(IdEspecialidade);
    }
}
