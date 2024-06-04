using IngressosNet.Models;
using IngressosNet.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IngressosNet.Controllers;

public class AtoresController(IAtorService service) : Controller
{
    private readonly IAtorService _service = service;

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var atores = await _service.ObterTodosAsync();
        return View(atores);
    }

    [HttpGet]
    public IActionResult Criar()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Criar(Ator ator)
    {
        if (!ModelState.IsValid)
        {
            return View(ator);
        }

        await _service.AdicionarAsync(ator);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Detalhes(int id)
    {
        var ator = await _service.ObterPorIdAsync(id);
        if (ator is null) return View("NaoEncontrado");
        return View(ator);
    }

    [HttpGet]
    public async Task<IActionResult> Editar(int id)
    {
        var ator = await _service.ObterPorIdAsync(id);
        if (ator is null) return View("NaoEncontrado");
        return View(ator);
    }

    [HttpPost]
    public async Task<IActionResult> Editar(int id, Ator novoAtor)
    {
        if (!ModelState.IsValid)
        {
            return View(novoAtor);
        }

        await _service.AtualizarAsync(id, novoAtor);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Remover(int id)
    {
        var ator = await _service.ObterPorIdAsync(id);
        if (ator is null) return View("NaoEncontrado");
        return View(ator);
    }

    [HttpPost, ActionName("Remover")]
    public async Task<IActionResult> RemoverConfirmado(int id)
    {
        var ator = await _service.ObterPorIdAsync(id);
        if (ator is null) return View("NaoEncontrado");

        await _service.RemoverAsync(id);
        return RedirectToAction(nameof(Index));
    }
}
