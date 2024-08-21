using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;

public class ClienteVeiculoConfig : IEntityTypeConfiguration<ClienteVeiculo>
{
    public void Configure(EntityTypeBuilder<ClienteVeiculo> builder)
    {
        builder.HasKey(o => o.objID);

        builder.HasOne(o => o.Clientes)
        .WithMany(o => o.ClienteVeiculos)
        .HasForeignKey(o => o.IdCliente)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

        builder.HasOne(o => o.Veiculos)
        .WithMany(o => o.ClienteVeiculos)
        .HasForeignKey(o => o.IdVeiculo)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

        builder.Property(o => o.placa_veiculo)
        .IsRequired(false)
        .HasMaxLength(100);
    }
}