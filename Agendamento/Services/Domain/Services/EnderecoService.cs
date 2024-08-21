using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services;

public class EnderecoService : Service<Endereco>, IEnderecoService
{
    private readonly IEnderecoRepository _enderecoRepository;
    public EnderecoService(IEnderecoRepository repository)
        : base(repository)
    {
        _enderecoRepository = repository;
    }
}

