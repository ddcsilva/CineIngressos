namespace IngressosNet.Models;

public sealed class Produtor : Pessoa
{
    // Relacionamentos
    public List<Filme> Filmes { get; set; } = [];
}
