using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext Database;

        public UserController(ApplicationDbContext database)
        {
            Database = database;
        }

        public IActionResult Index()
        {
            var eventos = Database.Eventos.Where(e => e.Status).Include(e => e.Estabelecimento);
            return View(eventos);
        }
    }
}