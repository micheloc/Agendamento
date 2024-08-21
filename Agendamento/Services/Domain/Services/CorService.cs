using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services;

public class CorService : Service<Cor>, ICorService
{
    private readonly ICorRepository _corRepository;
    public CorService(ICorRepository repository)
        : base(repository)
    {
        _corRepository = repository;
    }
}
