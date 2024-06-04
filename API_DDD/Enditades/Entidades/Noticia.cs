using System.ComponentModel.DataAnnotations.Schema;
using Entidades.Notificacoes;

namespace Entidades.Entidades;

[Table("TB_NOTICIA")]
public class Noticia : Notifica
{
    public string Titulo { get; set; }
    public string Informacao { get; set; }
    public bool Ativo { get; set; }
}
