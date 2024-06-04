namespace IngressosNet.Models;

public class Cinema : Entity
{
    public string Logo { get; set; } = string.Empty;    
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;

    // Relacionamentos
    public List<Filme> Filmes { get; set; } = [];
}
