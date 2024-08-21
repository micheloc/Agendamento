using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;
public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.HasKey(o => o.objID);

        builder.HasIndex(o => o.acesso)
        .IsUnique();    

        builder.Property(o => o.nome)
        .IsRequired();

        builder.Property(o => o.senha)
        .IsRequired();

        builder.Property(o => o.acesso)
        .IsRequired();
    }
}
