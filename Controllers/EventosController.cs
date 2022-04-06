using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DesafioMVC.Data;
using DesafioMVC.DTO;
using DesafioMVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioMVC.Controllers
{
    public class EventosController : Controller
    {
        private readonly ApplicationDbContext Database;
        private readonly IWebHostEnvironment HostEnvironment;

        public EventosController(ApplicationDbContext database, IWebHostEnvironment hostEnvironment)
        {
            Database = database;
            HostEnvironment = hostEnvironment;
        }

        [HttpPost]
        public IActionResult Salvar(EventoDTO novoEvento)
        {
            if(ModelState.IsValid)
            {
                string caminhoImagem = SalvarImagem(novoEvento);

                Evento evento = new Evento();
                evento.Nome = novoEvento.Nome;
                evento.Capacidade = novoEvento.Capacidade;
                evento.QuantidadeIngressos = novoEvento.Capacidade;
                evento.Data = novoEvento.Data;
                evento.ValorIngresso = float.Parse(novoEvento.ValorIngressoString, CultureInfo.InvariantCulture.NumberFormat);
                evento.Estabelecimento = Database.Estabelecimentos.First(e => e.Id == novoEvento.EstabelecimentoId);
                evento.Genero = Database.Generos.First(e => e.Id == novoEvento.GeneroId);
                evento.ImagemUrl = caminhoImagem;
                evento.Status = true;

                Database.Eventos.Add(evento);
                Database.SaveChanges();
                return RedirectToAction("Eventos", "Admin");
            }
            return RedirectToAction("CadastrarEvento","Admin");
        }

        [HttpPost]
        public IActionResult Atualizar(EventoDTO novoEvento)
        {
            if(ModelState.IsValid)
            {
                string caminhoImagem = AtualizarImagem(novoEvento);

                Evento evento = Database.Eventos.First(e => e.Id == novoEvento.Id);
                evento.Nome = novoEvento.Nome;
                evento.Capacidade = novoEvento.Capacidade;
                evento.Data = novoEvento.Data;
                evento.ValorIngresso = novoEvento.ValorIngresso;
                evento.Estabelecimento = Database.Estabelecimentos.First(e => e.Id == novoEvento.EstabelecimentoId);
                evento.Genero = Database.Generos.First(e => e.Id == novoEvento.GeneroId);
                evento.ImagemUrl = caminhoImagem;

                Database.SaveChanges();
                return RedirectToAction("Eventos", "Admin");
            }
            return View("../Admin/EditarEvento");
        }

        [HttpPost]
        public IActionResult Deletar(int id)
        {
            if(ModelState.IsValid)
            {
                Evento evento = Database.Eventos.First(e => e.Id == id);
                evento.Status = false;

                Database.SaveChanges();
            }
            return RedirectToAction("Eventos", "Admin");
        }

        [HttpPost]
        public IActionResult Evento(int id)
        {
            if (id > 0)
            {
                Evento evento = Database.Eventos.Include(e => e.Estabelecimento).Include(e => e.Genero).First(e => e.Id == id);
                if (evento != null)
                {
                    Response.StatusCode = 200;
                    return Json(evento);
                }
            }
            Response.StatusCode = 404;
            return Json(null);
        }

        // Manipulação das imagens

        private string SalvarImagem(EventoDTO evento)
        {

            if (evento.ImagemUrl != null)
            {
                return SalvarArquivoBanco(evento);
            }
           return "default";
        }

        private string AtualizarImagem(EventoDTO evento)
        {

            if (evento.ImagemUrl != null)
            {
                return SalvarArquivoBanco(evento);
            }
           return evento.ImagemUrlString;
        }

        private string SalvarArquivoBanco(EventoDTO evento)
        {
            string caminhoImagem = Guid.NewGuid().ToString().Substring(0,9) + evento.ImagemUrl.FileName;
            string caminhoAssets = Path.Combine(HostEnvironment.WebRootPath, "Assets/img");
            string caminhoArquivo = Path.Combine(caminhoAssets, caminhoImagem);
            using (var fileStream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                evento.ImagemUrl.CopyTo(fileStream);
            }
             return caminhoImagem;
        }
    }
}