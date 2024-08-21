using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services;

public class CategoriaService : Service<Categoria>, ICategoriaService
{
    private readonly ICategoriaRepository _categoriaRepository;
    public CategoriaService(ICategoriaRepository repository)
        : base(repository)
    {
        _categoriaRepository = repository;
    }
}
