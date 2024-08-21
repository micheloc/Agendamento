using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;
public class ContatoConfig : IEntityTypeConfiguration<Contato> { 
    public void Configure(EntityTypeBuilder<Contato> builder)
    {
        builder.HasKey(o => o.objID);

        builder.HasOne(o => o.Cliente)
        .WithMany(o => o.Contatos)
        .HasForeignKey(o => o.IdCliente)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

        builder.Property(o => o.telefone)
        .IsRequired(false)
        .HasMaxLength(25);


        builder.Property(o => o.celular)
        .IsRequired(false)
        .HasMaxLength(25);

        builder.Property(o => o.email)
        .IsRequired(false)
        .HasMaxLength(100);
    }
}