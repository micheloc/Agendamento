using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services;
public class MarcaService : Service<Marca>, IMarcaService
{
    private readonly IMarcaRepository _marcaRepository;
    public MarcaService(IMarcaRepository repository)
        : base(repository)
    {
        _marcaRepository = repository;
    }
}
