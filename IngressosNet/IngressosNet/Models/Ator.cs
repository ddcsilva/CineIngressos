namespace IngressosNet.Models;

public class Ator : Entity
{
    public string FotoDoPerfil { get; set; } = string.Empty;
    public string NomeCompleto { get; set; } = string.Empty;
    public string Biografia { get; set; } = string.Empty;

    // Relacionamentos
    public List<AtorFilme> AtoresFilmes { get; set; } = [];
}
