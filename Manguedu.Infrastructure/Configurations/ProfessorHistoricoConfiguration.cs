using Manguedu.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manguedu.Infrastructure.Configurations;

public class ProfessorHistoricoConfiguration: IEntityTypeConfiguration<ProfessorHistorico>
{
    public void Configure(EntityTypeBuilder<ProfessorHistorico> builder)
    {
        builder.HasKey(p => p.Id);

        builder
            .HasOne(p => p.Professor)
            .WithMany()
            .IsRequired();

        builder
            .Property(p => p.Serie)
            .HasConversion<string>()
            .IsRequired();

        builder
            .Property(p => p.Ano)
            .IsRequired();
    }
}