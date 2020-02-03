using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoa.Models
{
    public class Pessoa
    {
        [Key]
        [Display(Name = "ID")]
        public int IdPessoa { get; set; }
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Display(Name = "Sobrenome")]
        public string sobrenome { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name= "Nascimento")]
        [DataType(DataType.Date)]
        public DateTime idade { get; set; }

        [Phone]
        [Required]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }
        [Required]
        [Display(Name = "Localizacao")]
        public string localizacao { get; set; }

        [Display(Name = "Cpf")]
        public string cpf { get; set; }

        [Display(Name = "Hobby")]
        public string hobby { get; set; }
    }
}
