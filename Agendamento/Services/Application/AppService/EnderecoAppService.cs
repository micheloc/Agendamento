using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service;

namespace Agendamento.Services.Application.AppService;

public class EnderecoAppService : AppService<Endereco>, IEnderecoAppService
{
    private readonly IEnderecoService _enderecoService;

    public EnderecoAppService(IEnderecoService appService)
        : base(appService)
    {
        _enderecoService = appService;
    }
}
