using Manguedu.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manguedu.Infrastructure.Configurations;

public class AlunoHistoricoConfiguration: IEntityTypeConfiguration<AlunoHistorico>
{
    public void Configure(EntityTypeBuilder<AlunoHistorico> builder)
    {
        builder.HasKey(a => a.Id);

        builder
            .HasOne(a => a.Aluno)
            .WithMany()
            .IsRequired();

        builder.Property(a => a.Serie)
            .HasConversion<string>()
            .IsRequired();

        builder.Property(a => a.Ano).IsRequired();
    }
}