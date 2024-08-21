using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service;

namespace Agendamento.Services.Application.AppService;
public class MarcaAppService : AppService<Marca>, IMarcaAppService
{
    private readonly IMarcaService _MarcaService;

    public MarcaAppService(IMarcaService marcaService)
        : base(marcaService)
    {
        _MarcaService = marcaService;
    }
}
