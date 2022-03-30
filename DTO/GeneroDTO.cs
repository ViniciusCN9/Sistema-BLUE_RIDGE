using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioMVC.DTO
{
    public class GeneroDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [MinLength(2, ErrorMessage ="Nome Inválido, insira um nome maior")]
        public string Nome { get; set; }
    }
}