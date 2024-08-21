using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service;

namespace Agendamento.Services.Application.AppService;

public class ClienteAppService : AppService<Cliente>, IClienteAppService
{
    private readonly IClienteService _clienteService;

    public ClienteAppService(IClienteService appService)
        : base(appService)
    {
        _clienteService = appService;
    }
}