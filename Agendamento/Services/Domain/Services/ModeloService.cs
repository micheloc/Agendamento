using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services;

public class ModeloService : Service<Modelo>, IModeloService
{
    private readonly IModeloRepository _modeloRepository;
    public ModeloService(IModeloRepository repository)
        : base(repository)
    {
        _modeloRepository = repository;
    }
}
