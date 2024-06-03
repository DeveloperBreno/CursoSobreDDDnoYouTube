using System.ComponentModel.DataAnnotations.Schema;
using Endidades.Enums;
using Enditades.Notificacoes;

namespace Endidades.Entidades;

[Table("TB_NOTICIA")]
public class Noticia : Notifica
{
    public string Titulo { get; set; }
    public string Informacao { get; set; }
    public bool Ativo { get; set; }
}
