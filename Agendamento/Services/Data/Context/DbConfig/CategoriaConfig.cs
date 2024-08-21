using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;

public class CategoriaConfig : IEntityTypeConfiguration<Categoria>
{ 
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.HasKey(o => o.objID);

        builder.Property(o => o.descricao)
           .IsRequired(false)
           .HasMaxLength(100);
    }
}

