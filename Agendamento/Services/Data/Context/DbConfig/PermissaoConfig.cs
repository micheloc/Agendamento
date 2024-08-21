using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;
public class PermissaoConfig : IEntityTypeConfiguration<Permissao>
{
    public void Configure(EntityTypeBuilder<Permissao> builder)
    {
        builder.HasKey(o => o.objID);

        builder.HasIndex(o => o.display)
        .IsUnique();

        builder.HasIndex(o => o.elemento)
        .IsUnique();


        builder.Property(o => o.display)
        .IsRequired();

        builder.Property(o => o.elemento)
        .IsRequired();
    }
}
