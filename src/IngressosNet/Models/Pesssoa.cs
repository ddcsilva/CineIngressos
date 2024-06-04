using System.ComponentModel.DataAnnotations;

namespace IngressosNet.Models;

public abstract class Pessoa : Entity
{
    [Display(Name = "Foto do Perfil")]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string FotoDoPerfil { get; set; } = string.Empty;

    [Display(Name = "Nome Completo")]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres")]
    public string NomeCompleto { get; set; } = string.Empty;

    [Display(Name = "Biografia")]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Biografia { get; set; } = string.Empty;
}