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
    public class EstabelecimentosController : Controller
    {
        private readonly ApplicationDbContext Database;

        public EstabelecimentosController(ApplicationDbContext database)
        {
            Database = database;
        }

        [HttpPost]
        public IActionResult Salvar(EstabelecimentoDTO novoEstabelecimento)
        {
            if(ModelState.IsValid)
            {
                Estabelecimento estabelecimento = new Estabelecimento();
                estabelecimento.Nome = novoEstabelecimento.Nome;
                estabelecimento.Endereco = novoEstabelecimento.Endereco;
                estabelecimento.Email = novoEstabelecimento.Email;
                estabelecimento.Telefone = novoEstabelecimento.Telefone;
                estabelecimento.Status = true;

                Database.Estabelecimentos.Add(estabelecimento);
                Database.SaveChanges();

                return RedirectToAction("Estabelecimentos", "Admin");
            }
            return View("../Admin/CadastrarEstabelecimento");
        }

        [HttpPost]
        public IActionResult Atualizar(EstabelecimentoDTO novoEstabelecimento)
        {
            if(ModelState.IsValid)
            {
                Estabelecimento estabelecimento = Database.Estabelecimentos.First(e => e.Id == novoEstabelecimento.Id);
                estabelecimento.Nome = novoEstabelecimento.Nome;
                estabelecimento.Endereco = novoEstabelecimento.Endereco;
                estabelecimento.Email = novoEstabelecimento.Email;
                estabelecimento.Telefone = novoEstabelecimento.Telefone;

                Database.SaveChanges();
                return RedirectToAction("Estabelecimentos", "Admin");
            }
            return View("../Admin/EditarEstabelecimento");
        }

        [HttpPost]
        public IActionResult Deletar(int id)
        {
            if(id > 0)
            {
                Estabelecimento estabelecimento = Database.Estabelecimentos.First(e => e.Id == id);
                bool eventoCadastrado = Database.Eventos.Any(e => e.Estabelecimento.Equals(estabelecimento));
                if (!eventoCadastrado)
                {
                    estabelecimento.Status = false;
                    Database.SaveChanges();
                }   
            }
            return RedirectToAction("Estabelecimentos", "Admin");
        }
    }
}