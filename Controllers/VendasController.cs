using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioMVC.Data;
using DesafioMVC.DTO;
using DesafioMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DesafioMVC.Controllers
{
    public class VendasController : Controller
    {
        private readonly UserManager<IdentityUser> UserManager;
        private readonly ApplicationDbContext Database;

        public VendasController(ApplicationDbContext database, UserManager<IdentityUser> userManager)
        {
            UserManager = userManager;
            Database = database;
        }

        [HttpPost]
        public async Task<IActionResult> Gerar ([FromBody] VendaDTO novaVenda)
        {  
            var dataAtual = DateTime.Now;
            var user = await UserManager.GetUserAsync(User);

            Evento evento = Database.Eventos.First(e => e.Id == novaVenda.EventoId);
            evento.QuantidadeIngressos = (evento.QuantidadeIngressos - novaVenda.Quantidade);

            Venda venda = new Venda();
            venda.UserId = user.Id;
            venda.Evento = evento;
            venda.Quantidade = novaVenda.Quantidade;
            venda.ValorTotal = (venda.Quantidade * evento.ValorIngresso);
            venda.Data = dataAtual;
            
            Database.Vendas.Add(venda);
            Database.SaveChanges();
            return Ok(new{msg="Venda processada com sucesso!"});
        }
    }
}