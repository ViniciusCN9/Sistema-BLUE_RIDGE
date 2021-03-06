using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioMVC.Data;
using DesafioMVC.DTO;
using DesafioMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioMVC.Controllers
{
    public class GenerosController : Controller
    {
        private readonly ApplicationDbContext Database;

        public GenerosController(ApplicationDbContext database)
        {
            Database = database;
        }

        [HttpPost]
        public IActionResult Salvar(GeneroDTO novoGenero)
        {
            if(ModelState.IsValid)
            {
                Genero genero = new Genero();
                genero.Nome = novoGenero.Nome;
                genero.Status = true;

                Database.Add(genero);
                Database.SaveChanges();

                return RedirectToAction("Generos", "Admin");
            }
            return View("../Admin/CadastrarGenero");
        }

        [HttpPost]
        public IActionResult Atualizar(GeneroDTO novoGenero)
        {
            if(ModelState.IsValid)
            {
                Genero genero = Database.Generos.First(e => e.Id == novoGenero.Id);
                genero.Nome = novoGenero.Nome;

                Database.SaveChanges();
                return RedirectToAction("Generos", "Admin");
            }
            return View("../Admin/EditarGenero");
        }

        [HttpPost]
        public IActionResult Deletar(int id)
        {
            if(id > 0)
            {
                Genero genero = Database.Generos.First(e => e.Id == id);
                bool eventoCadastrado = Database.Eventos.Any(e => e.Genero.Equals(genero));
                if (!eventoCadastrado)
                {
                    genero.Status = false;
                    Database.SaveChanges();
                }
                else
                {
                    var generos = Database.Generos.Where(e => e.Status).ToList();
                    ViewBag.Mensagem = "Não é possível deletar gêneros com eventos cadastrados.";
                    return View("../Admin/Generos" , generos);
                }
            }
            return RedirectToAction("Generos", "Admin"); 
        }
    }
}