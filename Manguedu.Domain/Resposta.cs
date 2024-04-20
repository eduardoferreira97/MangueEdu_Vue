namespace Manguedu.Domain;

public class Resposta: Entidade
{
    public Escola Escola { get; set; }
    public AlunoHistorico Aluno { get; set; }
    public int Modulo { get; set; }
    public DateTime Timestamp { get; set; }
    public string PrimeiraPergunta { get; set; } = string.Empty;
    public string SegundaPergunta { get; set; } = string.Empty;
    public string TerceiraPergunta { get; set; } = string.Empty;
    public string QuartaPergunta { get; set; } = string.Empty;
}