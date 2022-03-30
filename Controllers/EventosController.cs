using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace DesafioMVC.Controllers
{
    public class EventosController : Controller
    {
        private readonly ApplicationDbContext Database;

        public EventosController(ApplicationDbContext database)
        {
            this.Database = database;
        }

        [HttpPost]
        public IActionResult Salvar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Deletar()
        {
            return RedirectToAction("Eventos", "Admin");
        }
    }
}