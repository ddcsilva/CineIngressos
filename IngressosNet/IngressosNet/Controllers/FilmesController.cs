using IngressosNet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IngressosNet.Controllers;

public class FilmesController(IngressosNetContext context) : Controller
{
    private readonly IngressosNetContext _context = context;

    public async Task<IActionResult> Index()
    {
        var filmes = await _context.Filmes.Include(f => f.Cinema).OrderBy(f => f.Nome).ToListAsync();
        return View(filmes);
    }
}
