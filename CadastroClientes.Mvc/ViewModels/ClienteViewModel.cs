using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CadastroClientes.Mvc.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        [MaxLength(150, ErrorMessage = "Max is {0} characters.")]
        [MinLength(3, ErrorMessage = "Min {0} characters.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        [MaxLength(150, ErrorMessage = "Max is {0} characters.")]
        [MinLength(3, ErrorMessage = "Min {0} characters.")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        [MaxLength(100, ErrorMessage = "Max is {0} characters.")]
        [EmailAddress(ErrorMessage = "Invalid e-mail address.")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}