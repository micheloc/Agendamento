using Agendamento.Services.Application.AppService._Base;
using Agendamento.Services.Application.AppService;
using Agendamento.Services.Application.Interfaces._Base;
using Agendamento.Services.Application.Interfaces;
using Agendamento.Services.Data.Repository._Base;
using Agendamento.Services.Data.Repository;
using Agendamento.Services.Domain.Interfaces.Repository._Base;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service._Base;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;
using Agendamento.Services.Domain.Services;
using Unity;
using Agendamento.Services.Data.Context.Interfaces;
using Agendamento.Services.Data.Context;

public static class UnityConfig
{
    public static IUnityContainer RegisterComponents()
    {
        var container = new UnityContainer();

        // Registrar tipos genéricos
        container.RegisterType<IDbContext, MyDbContext>();

        container.RegisterType(typeof(IAppService<>), typeof(AppService<>));
        container.RegisterType(typeof(IRepository<>), typeof(RepositoryBase<>));
        container.RegisterType(typeof(IService<>), typeof(Service<>));

        // Registrar tipos específicos
        container.RegisterType<IAgendarServicoAppService, AgendaAppService>();
        container.RegisterType<ICategoriaAppService, CategoriaAppService>();
        container.RegisterType<IClienteAppService, ClienteAppService>();
        container.RegisterType<IContatoAppService, ContatoAppService>();
        container.RegisterType<ICorAppService, CorAppService>();
        container.RegisterType<IEnderecoAppService, EnderecoAppService>();  
        container.RegisterType<IEspecialidadeAppService, EspecialidadeAppService>();
        container.RegisterType<IMarcaAppService, MarcaAppService>();
        container.RegisterType<IMecanicoAppService, MecanicoAppService>();
        container.RegisterType<IModeloAppService, ModeloAppService>();
        container.RegisterType<IServicoAppService, ServicoAppService>();
        container.RegisterType<IUsuarioAppService, UsuarioAppService>();
        container.RegisterType<IVeiculoAppService, VeiculoAppService>();

        container.RegisterType<IAgendarServicoService, AgendarServicoService>();
        container.RegisterType<ICategoriaService, CategoriaService>();
        container.RegisterType<IClienteService, ClienteService>();
        container.RegisterType<IContatoService, ContatoService>();
        container.RegisterType<ICorService, CorService>();
        container.RegisterType<IEnderecoService, EnderecoService>();    
        container.RegisterType<IEspecialidadeService, EspecialidadeService>();
        container.RegisterType<IMarcaService, MarcaService>();
        container.RegisterType<IMecanicoService, MecanicoService>();
        container.RegisterType<IModeloService, ModeloService>();
        container.RegisterType<IServicoService, ServicoService>();
        container.RegisterType<IUsuarioService, UsuarioService>();
        container.RegisterType<IVeiculoService, VeiculoService>();

        container.RegisterType<IAgendarServicoRepository, AgendarServicoRepository>();
        container.RegisterType<ICategoriaRepository, CategoriaRepository>();
        container.RegisterType<IClienteRepository, ClienteRepository>();
        container.RegisterType<IContatoRepository, ContatoRepository>();
        container.RegisterType<ICorRepository, CorRepository>();
        container.RegisterType<IEnderecoRepository, EnderecoRepository>();  
        container.RegisterType<IEspecialidadeRepository, EspecialidadeRepository>();
        container.RegisterType<IMarcaRepository, MarcaRepository>();
        container.RegisterType<IMecanicoRepository, MecanicoRepository>();
        container.RegisterType<IModeloRepository, ModeloRepository>();
        container.RegisterType<IServicoRepository, ServicoRepository>();
        container.RegisterType<IUsuarioRepository, UsuarioRepository>();
        container.RegisterType<IVeiculoRepository, VeiculoRepository>();

        return container;
    }
}
