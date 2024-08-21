using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services;

public class AgendarServicoService : Service<AgendarServico>, IAgendarServicoService
{
    private readonly IAgendarServicoRepository _agendarServicoRepository;
    public AgendarServicoService(IAgendarServicoRepository repository)
        : base(repository)
    {
        _agendarServicoRepository = repository;
    }
}
