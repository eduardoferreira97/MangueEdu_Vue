using Manguedu.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manguedu.Infrastructure.Configurations;

public class EscolaConfiguration: IEntityTypeConfiguration<Escola>
{
    public void Configure(EntityTypeBuilder<Escola> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Nome).IsRequired().HasMaxLength(100);
    }
}