using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;

public class AgendarServicoConfig : IEntityTypeConfiguration<AgendarServico>
{
    public void Configure(EntityTypeBuilder<AgendarServico> builder)
    {
        builder.HasKey(o => o.objID);

        builder.HasOne(o => o.Servicos)
        .WithMany(o => o.AgendarServicos)
        .HasForeignKey(o => o.IdServico)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

        builder.HasOne(o => o.Mecanicos)
        .WithMany(o => o.AgendarServicos)
        .HasForeignKey(o => o.IdMecanico)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

        builder.HasOne(o => o.Usuarios)
        .WithMany(o => o.AgendarServicos)
        .HasForeignKey(o => o.IdUsuario)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

        builder.Property(o => o.DataAgendamento)
        .HasColumnType("timestamp");
    }
}
