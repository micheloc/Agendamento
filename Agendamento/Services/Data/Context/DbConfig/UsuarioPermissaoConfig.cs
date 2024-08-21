using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agendamento.Services.Data.Context.DbConfig;

public class UsuarioPermissaoConfig : IEntityTypeConfiguration<UsuarioPermissao>
{

    public void Configure(EntityTypeBuilder<UsuarioPermissao> builder)
    {
        builder.HasKey(o => o.objID);


        builder.HasOne(o => o.usuario)
        .WithMany(o => o.UsuarioPermissao)
        .HasForeignKey(o => o.IdUsuario)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

        builder.HasOne(o => o.usuario)
        .WithMany(o => o.UsuarioPermissao)
        .HasForeignKey(o => o.IdPermissao)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);
    }
}
