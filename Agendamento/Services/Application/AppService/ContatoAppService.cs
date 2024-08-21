using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service;

namespace Agendamento.Services.Application.AppService;

public class ContatoAppService : AppService<Contato>, IContatoAppService
{
    private readonly IContatoService _contatoService;

    public ContatoAppService(IContatoService appService)
        : base(appService)
    {
        _contatoService = appService;
    }
}
