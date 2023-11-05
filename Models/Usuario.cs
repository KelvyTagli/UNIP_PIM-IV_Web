using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PIM_IV_Web.Models;

public class Usuario
{
    public int UsuarioId { get; set; }
    public string? NomeUsuario { get; set; }
    [Required(ErrorMessage = "Digite a Senha")]
    public string? Senha { get; set; }
    [Required(ErrorMessage = "Digite o Email")]
    public string? Email { get; set; }
    public DateTime? DataCriacao { get; set; }

    public bool ValidatePassword(string? password)
    {
        return password == Senha;
    }
}
