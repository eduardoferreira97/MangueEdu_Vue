using Microsoft.AspNetCore.Identity;

namespace Manguedu.Domain;

public class UsuarioApp: IdentityUser
{
    public string Nome { get; set; }
    public Escola? Escola { get; set; }
}