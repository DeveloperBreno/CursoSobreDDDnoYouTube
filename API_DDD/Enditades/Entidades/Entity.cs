using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Endidades.Enums;

namespace Endidades.Entidades;

public abstract class Entity 
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Column("CriadoEm")]
    public DateTime CriadoEm { get; set; }

    [Required]
    [Column("CriadoPor")]
    public string CriadoPor { get; set; }


    [Column("AlteradoEm")]
    public DateTime? AlteradoEm { get; set; }

    [Column("AlteradoEm")]
    public string? AlteradoPor { get; set; }


    [Column("ExcluidoEm")]
    public DateTime? ExcluidoEm { get; set; }
    
    [Column("ExcluidoPor")]
    public string? ExcluidoPor { get; set; }
}
