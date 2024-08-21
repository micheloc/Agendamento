using Microsoft.EntityFrameworkCore;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Data.Context.DbConfig;
using Agendamento.Services.Data.Context.Common;

namespace Agendamento.Services.Data.Context;

public class MyDbContext : AppDbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //optionsBuilder.UseNpgsql("Host=localhost;Database=Agendamentos;Username=postgres;Password=M!chelOliveira;");
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }

    public DbSet<AgendarServico> AgendarServico { get; set; }
    public DbSet<Categoria> Categoria { get; set; }
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<ClienteVeiculo> ClienteVeiculo { get; set; }
    public DbSet<Contato> Contato { get; set; }
    public DbSet<Cor> Cor { get; set; }
    public DbSet<Endereco> Endereco { get; set; }
    public DbSet<Especialidade> Especialidade { get; set; }
    public DbSet<Marca> Marca { get; set; }
    public DbSet<Mecanico> Mecanico { get; set; }
    public DbSet<Modelo> Modelo { get; set; }
    public DbSet<Servico> Servico { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Veiculo> Veiculo { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new AgendarServicoConfig());
        modelBuilder.ApplyConfiguration(new CategoriaConfig());
        modelBuilder.ApplyConfiguration(new ClienteConfig());
        modelBuilder.ApplyConfiguration(new ClienteVeiculoConfig());
        modelBuilder.ApplyConfiguration(new ContatoConfig());
        modelBuilder.ApplyConfiguration(new CorConfig());
        modelBuilder.ApplyConfiguration(new EnderecoConfig());
        modelBuilder.ApplyConfiguration(new EspecialidadeConfig());
        modelBuilder.ApplyConfiguration(new MarcaConfig());
        modelBuilder.ApplyConfiguration(new MecanicoConfig());
        modelBuilder.ApplyConfiguration(new ModeloConfig());
        modelBuilder.ApplyConfiguration(new VeiculoConfig());
        modelBuilder.ApplyConfiguration(new ServicoConfig());
        modelBuilder.ApplyConfiguration(new PermissaoConfig());
        modelBuilder.ApplyConfiguration(new UsuarioConfig());
        modelBuilder.ApplyConfiguration(new UsuarioPermissaoConfig());
    }
}

/// EntityFrameworkCore\Add-Migration GenerateDB -Context MyDbContext
/// EntityFrameworkCore\Update-Database -verbose -Context MyDbContext
/// EntityFrameworkCore\Remove-Migration -Context MyDbContext