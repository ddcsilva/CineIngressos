using IngressosNet.Models;

namespace IngressosNet.Services.Interfaces;

public interface IAtorService
{
    Task<IEnumerable<Ator>> ObterTodosAsync();
    Task<Ator?> ObterPorIdAsync(int id);
    Task AdicionarAsync(Ator ator);
    Task<Ator> AtualizarAsync(int id, Ator novoAtor);
    Task RemoverAsync(int id);
}
