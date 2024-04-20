using Manguedu.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manguedu.Infrastructure.Configurations;

public class UsuarioAppConfiguration: IEntityTypeConfiguration<UsuarioApp>
{
    public void Configure(EntityTypeBuilder<UsuarioApp> builder)
    {
        builder.Property(u => u.Nome).IsRequired().HasMaxLength(150);
        builder
            .HasOne(u => u.Escola)
            .WithMany();
    }
}