using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioMVC.DTO
{
    public class EstabelecimentoDTO
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="Insira o nome do estabelecimento")]
        [StringLength(100)]
        [MinLength(2, ErrorMessage ="Nome inválido, insira um nome maior")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Informe o endereço do estabelecimento")]
        [StringLength(100)]
        [MinLength(2, ErrorMessage ="Endereço inválido")]
        public string Endereco { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Telefone { get; set; }
    }
}