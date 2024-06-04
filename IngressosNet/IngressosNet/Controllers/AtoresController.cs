using IngressosNet.Data;
using Microsoft.AspNetCore.Mvc;

namespace IngressosNet.Controllers;

public class AtoresController(IngressosNetContext context) : Controller
{
    private readonly IngressosNetContext _context = context;

    public IActionResult Index()
    {
        var atores = _context.Atores.ToList();
        return View(atores);
    }
}
