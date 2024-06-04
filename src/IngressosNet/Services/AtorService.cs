using IngressosNet.Data;
using IngressosNet.Models;
using IngressosNet.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IngressosNet.Services;

public class AtorService(IngressosNetContext context) : IAtorService
{
    private readonly IngressosNetContext _context = context;

    public async Task<IEnumerable<Ator>> ObterTodosAsync()
    {
        return await _context.Atores.ToListAsync();
    }

    public async Task<Ator?> ObterPorIdAsync(int id)
    {
        return await _context.Atores.FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task AdicionarAsync(Ator ator)
    {
        await _context.Atores.AddAsync(ator);
        await _context.SaveChangesAsync();
    }

    public async Task<Ator> AtualizarAsync(int id, Ator novoAtor)
    {
        _context.Atores.Update(novoAtor);
        await _context.SaveChangesAsync();
        return novoAtor;
    }

    public async Task RemoverAsync(int id)
    {
        var ator = await ObterPorIdAsync(id);

        if (ator != null)
        {
            _context.Atores.Remove(ator);
            await _context.SaveChangesAsync();
        }
    }
}
