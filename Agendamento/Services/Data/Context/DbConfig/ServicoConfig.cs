using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;
public class ServicoConfig : IEntityTypeConfiguration<Servico>
{
    public void Configure(EntityTypeBuilder<Servico> builder)
    {
        builder.HasKey(o => o.objID);

        builder.HasOne(o => o.Categoria)
        .WithMany(o => o.Servicos)
        .HasForeignKey(o => o.IdCategoria)
        .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

        builder.Property(o => o.custo)
        .HasColumnType("numeric(10, 2)");

        builder.Property(o => o.tempo)
        .IsRequired(false);
    }
}
