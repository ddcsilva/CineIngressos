using System.ComponentModel.DataAnnotations;

namespace IngressosNet.Models;

public class Ator : Entity
{
    [Display(Name = "Foto do Perfil")]
    public string FotoDoPerfil { get; set; } = string.Empty;

    [Display(Name = "Nome Completo")]
    public string NomeCompleto { get; set; } = string.Empty;

    [Display(Name = "Biografia")]
    public string Biografia { get; set; } = string.Empty;

    // Relacionamentos
    public List<AtorFilme> AtoresFilmes { get; set; } = [];
}
