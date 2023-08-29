using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using w5i.Data; // Certifique-se de que esse using aponta para o namespace correto
using w5i.Models; // Certifique-se de que esse using aponta para o namespace correto

namespace w5i.Controllers
{
    public class ControleAcessoController : Controller
    {
        private readonly ControleAcessoContext _context; // Certifique-se de que o contexto esteja corretamente referenciado

        public ControleAcessoController(ControleAcessoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastroPessoa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarPessoa(Pessoa pessoa) // Certifique-se de que "Pessoa" seja a classe correta
        {
            if (ModelState.IsValid)
            {
                _context.Pessoas.Add(pessoa); // Certifique-se de que "Pessoas" seja o DbSet correto no contexto
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("CadastroPessoa", pessoa);
        }

        // ... outras ações aqui ...
    }
}