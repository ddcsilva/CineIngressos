using IngressosNet.Models;

namespace IngressosNet.Services.Interfaces;

public interface IAtorService
{
    IEnumerable<Ator> ObterTodos();
    Ator ObterPorId(int id);
    void Adicionar(Ator ator);
    Ator Atualizar(int id, Ator novoAtor);
    void Remover(int id);
}
