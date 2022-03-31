using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioMVC.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        public DateTime Data { get; set; }
        public float ValorIngresso { get; set; }
        public Estabelecimento Estabelecimento { get; set; }
        public Genero Genero { get; set; }
        public string ImagemUrl { get; set; }
        public bool Status { get; set; }
    }
}