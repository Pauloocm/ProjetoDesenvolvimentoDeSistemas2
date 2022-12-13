using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_DS2.Models;
using PROJETO_DS22.Models;
using PROJETODS22.repositorio;

namespace Projeto_DS2.Controllers;

public class HomeController : Controller
{
    private readonly IUsuarioRepositorio contatoRep;
    public HomeController(IUsuarioRepositorio contatoRepositorio)
    {
        contatoRep = contatoRepositorio;
    }
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Cadastro()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public IActionResult Criar(UsuarioModel usuario)
    {
        contatoRep.adicionar(usuario);
        
        return RedirectToAction("Index");
    }
}
