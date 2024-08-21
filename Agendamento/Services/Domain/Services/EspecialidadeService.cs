using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services;

public class EspecialidadeService : Service<Especialidade>, IEspecialidadeService
{
    private readonly IEspecialidadeRepository _especialidadeRepository;
    public EspecialidadeService(IEspecialidadeRepository repository)
        : base(repository)
    {
        _especialidadeRepository = repository;
    }
}
