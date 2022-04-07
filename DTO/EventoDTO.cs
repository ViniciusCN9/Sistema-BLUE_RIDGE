using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

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
        [Range(1,2147483647)]
        public int Capacidade { get; set; }

        public int QuantidadeIngressos { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        // [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime Data { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0,c}")]
        public float ValorIngresso { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0,c}")]
        public string ValorIngressoString { get; set; }

        [Required]
        public int EstabelecimentoId { get; set; }

        [Required]
        public int GeneroId { get; set; }

        public IFormFile ImagemUrl { get; set; }        
        public string ImagemUrlString { get; set; }        
    }
}