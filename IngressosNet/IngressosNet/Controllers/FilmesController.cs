using IngressosNet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IngressosNet.Controllers;

public class FilmesController(IngressosNetContext context) : Controller
{
    private readonly IngressosNetContext _context = context;

    public async Task<IActionResult> Index()
    {
        var filmes = await _context.Filmes.ToListAsync();
        return View(filmes);
    }
}
