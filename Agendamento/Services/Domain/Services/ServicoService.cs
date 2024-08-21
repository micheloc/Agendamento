using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services;

public class ServicoService : Service<Servico>, IServicoService
{
    private readonly IServicoRepository _servicoRepository;
    public ServicoService(IServicoRepository repository)
        : base(repository)
    {
        _servicoRepository = repository;
    }

    public List<ServicoAux> GetLstServicoByCategoria(Guid IdCategoria)
    {
        return _servicoRepository.GetLstServicoByCategoria(IdCategoria);
    }
}

