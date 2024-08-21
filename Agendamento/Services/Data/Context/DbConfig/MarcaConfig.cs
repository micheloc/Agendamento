using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agendamento.Services.Data.Context.DbConfig;
public class MarcaConfig : IEntityTypeConfiguration<Marca>
{
    public void Configure(EntityTypeBuilder<Marca> builder)
    {
        builder.HasKey(o => o.objID);

        builder.HasIndex(o => o.fabricante)
        .IsUnique();

        builder.Property(o => o.fabricante)
            .IsRequired()
            .HasMaxLength(100);
    }
}
