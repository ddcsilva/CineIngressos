using IngressosNet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IngressosNet.Controllers;

public class ProdutoresController(IngressosNetContext context) : Controller
{
    private readonly IngressosNetContext _context = context;

    public async Task<IActionResult> Index()
    {
        var produtores = await _context.Produtores.ToListAsync();
        return View(produtores);
    }
}
