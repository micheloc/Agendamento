using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;
public class VeiculoConfig : IEntityTypeConfiguration<Veiculo>
{
    public void Configure(EntityTypeBuilder<Veiculo> builder)
    {
        builder.HasKey(o => o.objID);

        builder.HasOne(o => o.Marca)
        .WithMany(o => o.Veiculos)
        .HasForeignKey(o => o.IdMArca)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

        builder.HasOne(o => o.Modelo)
        .WithMany(o => o.Veiculos)
        .HasForeignKey(o => o.IdModelo)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

        builder.HasOne(o => o.Cor)
        .WithMany(o => o.Veiculos)
        .HasForeignKey(o => o.IdCor)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

        builder.Property(o => o.ano)
        .IsRequired(false);
    }
}
