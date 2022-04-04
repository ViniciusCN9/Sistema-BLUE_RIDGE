using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioMVC.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public Evento Evento { get; set; }
        public float ValorTotal { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
    }
}