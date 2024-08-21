using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;

public class ModeloConfig : IEntityTypeConfiguration<Modelo>
{
    public void Configure(EntityTypeBuilder<Modelo> builder)
    {
        builder.HasKey(o => o.objID);

        builder.HasIndex(o => o.descricao)
        .IsUnique();

        builder.Property(o => o.descricao)
        .IsRequired(false)
        .HasMaxLength(100);
    }
}
