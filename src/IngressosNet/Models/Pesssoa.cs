using System.ComponentModel.DataAnnotations;

namespace IngressosNet.Models;

public abstract class Pessoa : Entity
{
    [Display(Name = "Foto do Perfil")]
    public string FotoDoPerfil { get; set; } = string.Empty;

    [Display(Name = "Nome Completo")]
    public string NomeCompleto { get; set; } = string.Empty;

    [Display(Name = "Biografia")]
    public string Biografia { get; set; } = string.Empty;
}