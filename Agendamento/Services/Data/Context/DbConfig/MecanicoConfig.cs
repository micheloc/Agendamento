using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;
public class MecanicoConfig : IEntityTypeConfiguration<Mecanico>
{
    public void Configure(EntityTypeBuilder<Mecanico> builder)
    {
        builder.HasKey(o => o.objID);

        builder.HasOne(o => o.Especialidade)
        .WithMany(o => o.Mecanicos)
        .HasForeignKey(o => o.IdEspecialidade)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

        builder.Property(o => o.nome)
        .IsRequired(false)
        .HasMaxLength(100);
    }
}
