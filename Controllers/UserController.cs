using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioMVC.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioMVC.Controllers
{
    [Authorize(policy: "User")]
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> UserManager;
        private readonly ApplicationDbContext Database;

        public UserController(ApplicationDbContext database, UserManager<IdentityUser> userManager)
        {
            UserManager = userManager;
            Database = database;
        }

        public IActionResult Index()
        {
            var eventos = Database.Eventos.Where(e => e.Status).Include(e => e.Estabelecimento).OrderBy(e => e.Data);
            return View(eventos);
        }

        public IActionResult Eventos()
        {
            var eventos = Database.Eventos.Include(e => e.Estabelecimento).Include(e => e.Genero).OrderBy(e => e.Data);
            return View(eventos);
        }

        public async Task<IActionResult> Historico()
        {
            var user = await UserManager.GetUserAsync(User);
            var vendas = Database.Vendas.Where(e => e.UserId.Equals(user.Id)).Include(e => e.Evento).OrderBy(e => e.Data);
            return View(vendas);
        }
    }
}