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
        public IActionResult Promover(PromoverDTO usuario)
        {

            if(ModelState.IsValid)
            {
                IdentityUser user;
                IdentityUserClaim<string> usuarioNome;
                
                //Busca e verifica se existe um usuário com o email informado
                try
                {
                    user = Database.Users.First(e => e.Email.Equals(usuario.Email));
                }
                catch
                {
                    user = null;
                }

                //Busca e verifica se existe uma claim "Name" com o nome informado
                try
                {
                    usuarioNome = Database.UserClaims.First(e => e.UserId == user.Id 
                                                                && e.ClaimType.Equals("Name")
                                                                && e.ClaimValue.Equals(usuario.Nome));
                }
                catch
                {
                    usuarioNome = null;
                }
                
                //Altera a claim "Role" do usuário para "admin".
                if (user != null && usuarioNome != null)
                {
                    var usuarioAdmin = Database.UserClaims.First(e => e.Id == (usuarioNome.Id + 1));
                    usuarioAdmin.ClaimValue = "admin";
                    Database.SaveChanges();

                    return RedirectToAction("Opcoes","Admin");
                }
                else
                {
                    ViewBag.Mensagem = "Usuário não encontrado.";
                    return View("../Admin/Promover", usuario);
                }
            }
            else
            {
                ViewBag.Mensagem = "Preecha corretamente os campos.";
                return View("../Admin/Promover", usuario);
            }
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
                if(user.Id == usuarioAdmin.UserId) //Se o usuário excluido estiver logado ele será deslogado
                {
                    await SignInManager.SignOutAsync();
                    return RedirectToAction("Index", "Home");;
                }
            }
            return RedirectToAction("Opcoes", "Admin");
        }
    }
}