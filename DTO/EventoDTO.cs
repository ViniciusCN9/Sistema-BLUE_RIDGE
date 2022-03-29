using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioMVC.DTO
{
    public class EventoDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [MinLength(2, ErrorMessage ="Nome Inválido, insira um nome maior")]
        public string Nome { get; set; }

        [Required]
        [Range(0,2147483647)]
        public int Capacidade { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Data { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float ValorIngresso { get; set; }

        [Required]
        public int EstabalecimentoId { get; set; }

        [Required]
        public int GeneroId { get; set; }

        [Required]
        [DataType(DataType.Url)]
        public string ImagemUrl { get; set; }        
    }
}