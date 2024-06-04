namespace IngressosNet.Models;

public sealed class AtorFilme
{
    public int AtorId { get; set; }
    public Ator Ator { get; set; } = null!;

    public int FilmeId { get; set; }
    public Filme Filme { get; set; } = null!;
}
