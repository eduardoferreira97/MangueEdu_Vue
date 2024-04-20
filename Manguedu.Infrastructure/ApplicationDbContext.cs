using Manguedu.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Manguedu.Infrastructure;

public class ApplicationDbContext: IdentityDbContext<UsuarioApp, IdentityRole, string>
{
    //Quando estabelecemos que o construtor recebe esse parâmetro options,
    //podemos customizar as opções do DbContext no Program.cs
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    //Esse método vai carregar todas as configurações do assembly do Manguedu.Infrastructure/Configurations
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Precisamos chamar esse método da classe pai primeiro já que as chaves do ASP.NET Identity
        //são mapeadas no OnModelCreating: https://stackoverflow.com/questions/40703615/the-entity-type-identityuserloginstring-requires-a-primary-key-to-be-defined
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}