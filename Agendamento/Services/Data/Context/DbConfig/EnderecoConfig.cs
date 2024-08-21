using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;

public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
        builder.HasKey(o => o.objID);

        builder.HasOne(o => o.Cliente)
        .WithMany(o => o.Enderecos)
        .HasForeignKey(o => o.IdCliente)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

        builder.Property(o => o.numero)
        .IsRequired(false);

        builder.Property(o => o.logradouro)
        .IsRequired(false)
        .HasMaxLength(100);

        builder.Property(o => o.bairro)
        .IsRequired(false)
        .HasMaxLength(50);

        builder.Property(o => o.cep)
        .IsRequired(false)
        .HasMaxLength(12);
    }
}