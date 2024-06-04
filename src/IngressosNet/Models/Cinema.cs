using System.ComponentModel.DataAnnotations;

namespace IngressosNet.Models;

public sealed class Cinema : Entity
{
    [Display(Name = "Logo")]
    public string Logo { get; set; } = string.Empty;

    [Display(Name = "Nome")]
    public string Nome { get; set; } = string.Empty;

    [Display(Name = "Descrição")]
    public string Descricao { get; set; } = string.Empty;

    // Relacionamentos
    public List<Filme> Filmes { get; set; } = [];
}
