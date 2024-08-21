using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Service;

namespace Agendamento.Services.Application.AppService;


public class CategoriaAppService : AppService<Categoria>, ICategoriaAppService
{
    private readonly ICategoriaService _categoriaService;

    public CategoriaAppService(ICategoriaService appService)
        : base(appService)
    {
        _categoriaService = appService;
    }
}
