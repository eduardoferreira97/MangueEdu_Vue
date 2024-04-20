namespace Manguedu.Domain;

public class AlunoHistorico: Entidade
{
    public Aluno Aluno { get; set; }
    public Serie Serie { get; set; }
    public DateOnly Ano { get; set; }
}