using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services;

public class MecanicoService : Service<Mecanico>, IMecanicoService
{
    private readonly IMecanicoRepository _mecanicoRepository;
    public MecanicoService(IMecanicoRepository repository)
        : base(repository)
    {
        _mecanicoRepository = repository;
    }

    public List<MecanicoAux> GetAllByEspecialidade(Guid IdEspecialidade)
    {
        return _mecanicoRepository.GetAllByEspecialidade(IdEspecialidade);
    }
}
