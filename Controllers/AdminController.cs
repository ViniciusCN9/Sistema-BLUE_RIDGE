using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioMVC.Data;
using DesafioMVC.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DesafioMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext Database;

        public AdminController(ApplicationDbContext database)
        {
            this.Database = database;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Generos()
        {
            var generos = Database.Generos.Where(e => e.Status).ToList();
            return View(generos);
        }
        
        public IActionResult CadastrarGenero()
        {
            return View();
        }

        public IActionResult EditarGenero(int id)
        {
            var genero = Database.Generos.First(e => e.Id == id);

            GeneroDTO generoView = new GeneroDTO();
            generoView.Id = genero.Id;
            generoView.Nome = genero.Nome;

            return View(generoView);
        }

        public IActionResult Estabelecimentos()
        {
            var estabelecimentos = Database.Estabelecimentos.Where(e => e.Status).ToList();
            return View(estabelecimentos);
        }

        public IActionResult CadastrarEstabelecimento()
        {
            return View();
        }

        public IActionResult EditarEstabelecimento(int id)
        {
            var estabelecimento = Database.Estabelecimentos.First(e => e.Id == id);

            EstabelecimentoDTO estabelecimentoView = new EstabelecimentoDTO();
            estabelecimentoView.Id = estabelecimento.Id;
            estabelecimentoView.Nome = estabelecimento.Nome;
            estabelecimentoView.Endereco = estabelecimento.Endereco;
            estabelecimentoView.Email = estabelecimento.Email;
            estabelecimentoView.Telefone = estabelecimento.Telefone;

            return View(estabelecimentoView);
        }

        public IActionResult Eventos()
        {
            var eventos = Database.Eventos.Where(e => e.Status);
            return View(eventos);
        }

        public IActionResult CadastrarEvento()
        {
            ViewBag.DataAtual = DateTime.Now.ToString("s").Substring(0,16);
            return View();
        }

        public IActionResult EditarEvento()
        {
            return View();
        }
    }
}