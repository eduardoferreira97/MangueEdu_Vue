namespace Manguedu.Domain;

public class ProfessorHistorico: Entidade
{
    //TODO: Procurar um workaround pra isso. Nada da Infrastructure deveria estar no Domain
    public UsuarioApp Professor { get; set; }
    public Serie Serie { get; set; }
    public DateOnly Ano { get; set; }
}