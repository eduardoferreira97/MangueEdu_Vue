using Manguedu.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manguedu.Infrastructure.Configurations;

public class RespostaConfiguration: IEntityTypeConfiguration<Resposta>
{
    public void Configure(EntityTypeBuilder<Resposta> builder)
    {
        builder.HasKey(r => r.Id);

        builder
            .HasOne(r => r.Escola)
            .WithMany()
            .IsRequired();

        builder
            .HasOne(r => r.Aluno)
            .WithMany()
            .IsRequired();

        builder.Property(r => r.Modulo).IsRequired();
    }
}