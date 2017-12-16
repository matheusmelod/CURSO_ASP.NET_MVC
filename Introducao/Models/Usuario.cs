using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome é obrigatorio")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma observação de 5 a 50 caracteres.")]
        public string Observacoes { get; set; }

        [Range(18,70, ErrorMessage = "Idade invalida. De 18 a 70 anos.")]
        public int Idade { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Digite um e-mail valido.")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras. 5 a 15 caracteres.")]
        [Required(ErrorMessage = "O Login é obrigatorio")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Esse login já existe.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A senha é obrigatorio")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas não se coincidem.")]
        public string ConfirmarSenha { get; set; }
    }
}