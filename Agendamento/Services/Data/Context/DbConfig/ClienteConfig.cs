using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;
public class ClienteConfig : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.HasKey(o => o.objID);

        builder.Property(o => o.nome)
           .IsRequired(false)
           .HasMaxLength(100);

        builder.Property(o => o.tipo);

        builder.Property(o => o.cpf_cnpj)
           .IsRequired(false)
           .HasMaxLength(25);
    }
}