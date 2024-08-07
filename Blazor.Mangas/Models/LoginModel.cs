﻿using System.ComponentModel.DataAnnotations;

namespace Blazor.Mangas.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Informe o email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        public string? Password { get; set; }

    }
}
