using IngressosNet.Models.Enums;

namespace IngressosNet.Models;

public class Filme : Entity
{
    public string Nome { get; set; } = string.Empty;
    public string Sinopse { get; set; } = string.Empty;
    public double Preco { get; set; }
    public string UrlDaImagem { get; set; } = string.Empty;
    public DateTime DataDeLancamento { get; set; }
    public DateTime DataDeEncerramento { get; set; }
    public ECategoriaFilme Categoria { get; set; }

    // Relacionamentos
    public List<AtorFilme> AtoresFilmes { get; set; } = [];

    public int CinemaId { get; set; }
    public Cinema Cinema { get; set; } = null!;

    public int ProdutorId { get; set; }
    public Produtor Produtor { get; set; } = null!;
}
