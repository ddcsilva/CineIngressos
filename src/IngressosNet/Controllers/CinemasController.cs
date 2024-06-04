using IngressosNet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IngressosNet.Controllers;

public class CinemasController(IngressosNetContext context) : Controller
{
    private readonly IngressosNetContext _context = context;

    public async Task<IActionResult> Index()
    {
        var cinemas = await _context.Cinemas.ToListAsync();
        return View(cinemas);
    }
}
