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
            this.Database = database;
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
                genero.Status = false;
                
                Database.SaveChanges();
            }
            return RedirectToAction("Generos", "Admin"); 
        }
    }
}