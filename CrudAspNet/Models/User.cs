using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudAspNet.Models
{
    public class User
    {
        public int UserId { get; set; }
        [MaxLength(length:50), Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório"), RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$", ErrorMessage = "Formato inválido")]
        [MaxLength(length: 15)]
        public string Cpf { get; set; }
        [RegularExpression(@"^\(\d{2}\)\d{4}\-\d{4}$", ErrorMessage = "Formato  inválido")]
        [MaxLength(length: 15)]
        public string Telefone { get; set; }
    }

}