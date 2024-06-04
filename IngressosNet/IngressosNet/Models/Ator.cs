namespace IngressosNet.Models;

public sealed class Ator : Pessoa
{
    // Relacionamentos
    public List<AtorFilme> AtoresFilmes { get; set; } = [];
}
