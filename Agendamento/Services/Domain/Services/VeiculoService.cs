using Agendamento.Services.Application.Auxiliar;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services;

public class VeiculoService : Service<Veiculo>, IVeiculoService
{
    private readonly IVeiculoRepository _veiculoRepository;
    public VeiculoService(IVeiculoRepository repository)
        : base(repository)
    {
        _veiculoRepository = repository;
    }

    public List<VeiculoAux> GetAllVeiculos()
    {
        return _veiculoRepository.GetAllVeiculos(); 
    }
}
