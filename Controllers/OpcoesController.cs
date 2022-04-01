using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioMVC.Data;
using DesafioMVC.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DesafioMVC.Controllers
{
    public class OpcoesController : Controller
    {
        private readonly SignInManager<IdentityUser> SignInManager;
        private readonly UserManager<IdentityUser> UserManager;
        private readonly ApplicationDbContext Database;

        public OpcoesController(ApplicationDbContext database, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            SignInManager = signInManager;
            UserManager = userManager;
            Database = database;
        }

        [HttpPost]
        public IActionResult Promover(PromoverDTO opcoes)
        {

            if(ModelState.IsValid)
            {
                var user = Database.Users.First(e => e.Email == opcoes.Email);
                var usuarioNome = Database.UserClaims.First(e => e.UserId == user.Id 
                                                            && e.ClaimType.Equals("Name")
                                                            && e.ClaimValue.Equals(opcoes.Nome));
                var usuarioAdmin = Database.UserClaims.First(e => e.Id == (usuarioNome.Id + 1));
                usuarioAdmin.ClaimValue = "admin";

                Database.SaveChanges();
            }
            return RedirectToAction("Opcoes", "Admin");
        }

        [HttpPost]
        public async Task<IActionResult> Remover(int id)
        {
            var user = await UserManager.GetUserAsync(User);
            if(id > 0)
            {
                var usuarioAdmin = Database.UserClaims.First(e => e.Id == (id + 1));
                usuarioAdmin.ClaimValue = "user";

                Database.SaveChanges();
                if(user.Id == usuarioAdmin.UserId)
                {
                    await SignInManager.SignOutAsync();
                    return RedirectToAction("Index", "Home");;
                }
            }
            return RedirectToAction("Opcoes", "Admin");
        }
    }
}