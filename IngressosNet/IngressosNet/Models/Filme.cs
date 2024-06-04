using IngressosNet.Models.Enums;

namespace IngressosNet.Models;

public class Filme
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;
    public string Sinopse { get; set; } = string.Empty;
    public double Preco { get; set; }
    public string UrlDaImagem { get; set; } = string.Empty;
    public DateTime DataDeLancamento { get; set; }
    public DateTime DataDeEncerramento { get; set; }
    public ECategoriaFilme Categoria { get; set; }
}
