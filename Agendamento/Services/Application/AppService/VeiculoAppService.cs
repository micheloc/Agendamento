using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service;

namespace Agendamento.Services.Application.AppService;

public class VeiculoAppService : AppService<Veiculo>, IVeiculoAppService
{
    private readonly IVeiculoService _veiculoService;

    public VeiculoAppService(IVeiculoService appService)
        : base(appService)
    {
        _veiculoService = appService;
    }

    public List<VeiculoAux> GetAllVeiculos()
    {
        return _veiculoService.GetAllVeiculos();
    }
}
