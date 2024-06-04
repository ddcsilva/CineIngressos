using System.ComponentModel.DataAnnotations;

namespace IngressosNet.Models;

public class Produtor : Entity
{
    [Display(Name = "Foto do Perfil")]
    public string FotoDoPerfil { get; set; } = string.Empty;

    [Display(Name = "Nome Completo")]
    public string NomeCompleto { get; set; } = string.Empty;

    [Display(Name = "Biografia")]
    public string Biografia { get; set; } = string.Empty;

    // Relacionamentos
    public List<Filme> Filmes { get; set; } = [];
}
