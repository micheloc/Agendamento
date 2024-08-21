using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;

public class CorConfig : IEntityTypeConfiguration<Cor>
{
    public void Configure(EntityTypeBuilder<Cor> builder)
    {
        builder.HasKey(o => o.objID);
        
        builder.HasIndex(o => o.descricao)
        .IsUnique();

        builder.Property(o => o.descricao)
        .IsRequired(false)
        .HasMaxLength(25);
    }
}