using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services;

public class ClienteService : Service<Cliente>, IClienteService
{
    private readonly IClienteRepository _clienteRepository;
    public ClienteService(IClienteRepository repository)
        : base(repository)
    {
         _clienteRepository = repository;
    }
}

