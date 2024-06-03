using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using Endidades.Enums;

namespace Endidades.Entidades;
public class ApplicationUser : IdentityUser
{
    [Column("USR_NASCIMENTO")]
    public DateTime DataDeNascimento { get; set; }

    [Column("USR_CELULAR")]
    public string Celular { get; set; }

    [Column("USR_TIPO")]
    public TipoUsuario Tipo { get; set; }
}
