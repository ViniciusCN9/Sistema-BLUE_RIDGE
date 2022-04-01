using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioMVC.Data;
using DesafioMVC.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext Database;

        public AdminController(ApplicationDbContext database)
        {
            Database = database;
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
            var eventos = Database.Eventos.Where(e => e.Status).Include(e => e.Estabelecimento).Include(e => e.Genero);
            ViewBag.VerificaEstabelecimentos = Database.Estabelecimentos.Where(e => e.Status).Count();
            ViewBag.VerificaGeneros = Database.Generos.Where(e => e.Status).Count();
            return View(eventos);
        }

        public IActionResult CadastrarEvento()
        {
            ViewBag.DataAtual = DateTime.Now.ToString("s").Substring(0,16);
            ViewBag.Estabelecimentos = Database.Estabelecimentos.Where(e => e.Status).ToList();
            ViewBag.Generos = Database.Generos.Where(e => e.Status).ToList();
            return View();
        }

        public IActionResult EditarEvento(int id)
        {
            var evento = Database.Eventos.Include(e => e.Estabelecimento).Include(e => e.Genero).First(e => e.Id == id);

            EventoDTO eventoView = new EventoDTO();
            eventoView.Id = evento.Id;
            eventoView.Nome = evento.Nome;
            eventoView.Capacidade = evento.Capacidade;
            eventoView.Data = evento.Data;
            eventoView.ValorIngresso = evento.ValorIngresso;
            eventoView.EstabelecimentoId = evento.Estabelecimento.Id;
            eventoView.GeneroId = evento.Genero.Id;
            eventoView.ImagemUrlString = evento.ImagemUrl; 

            ViewBag.Estabelecimentos = Database.Estabelecimentos.Where(e => e.Status).ToList();
            ViewBag.Generos = Database.Generos.Where(e => e.Status).ToList(); 
            return View(eventoView);
        }

        public IActionResult Opcoes()
        {
            var usuariosAdmin = Database.UserClaims.Where(e => e.ClaimType == "Role" && e.ClaimValue == "admin").ToList();
            var usuariosAdminNomes = new List<IdentityUserClaim<string>>(); 
            foreach(var usuarioAdmin in usuariosAdmin)
            {
                var usuarioAdminNome = Database.UserClaims.First(e => e.Id == (usuarioAdmin.Id -1));
                usuariosAdminNomes.Add(usuarioAdminNome);
            }
            return View(usuariosAdminNomes);
        }

        public IActionResult Promover()
        {
            return View();
        }
    }
}