namespace IngressosNet.Models;

public class Produtor : Entity
{
    public string FotoDoPerfil { get; set; } = string.Empty;
    public string NomeCompleto { get; set; } = string.Empty;
    public string Biografia { get; set; } = string.Empty;

    // Relacionamentos
    public List<Filme> Filmes { get; set; } = [];
}
