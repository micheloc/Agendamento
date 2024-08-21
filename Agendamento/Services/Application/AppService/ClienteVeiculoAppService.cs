using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service;

namespace Agendamento.Services.Application.AppService;

public class ClienteVeiculoAppService : AppService<ClienteVeiculo>, IClienteVeiculoAppService
{
    private readonly IClienteVeiculoService _clienteVeiculoAppService;

    public ClienteVeiculoAppService(IClienteVeiculoService appService)
        : base(appService)
    {
        _clienteVeiculoAppService = appService;
    }
}

