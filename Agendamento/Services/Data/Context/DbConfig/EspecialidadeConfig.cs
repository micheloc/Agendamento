using Agendamento.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Services.Data.Context.DbConfig;
public class EspecialidadeConfig : IEntityTypeConfiguration<Especialidade>
{
    public void Configure(EntityTypeBuilder<Especialidade> builder)
    {
        builder.HasKey(o => o.objID);

        builder.Property(o => o.descricao)
        .IsRequired(false)
        .HasMaxLength(100);
    }
}
