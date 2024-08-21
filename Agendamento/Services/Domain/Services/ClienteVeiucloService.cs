using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services
{
    public class ClienteVeiucloService : Service<ClienteVeiculo>, IClienteVeiculoService
    {
        private readonly IClienteVeiculoRepository _clienteVeiculoRepository;
        public ClienteVeiucloService(IClienteVeiculoRepository repository)
            : base(repository)
        {
            _clienteVeiculoRepository = repository;
        }
    }

}
