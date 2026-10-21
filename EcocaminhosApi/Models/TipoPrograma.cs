using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EcocaminhosApi.Models;

[Table("TipoPrograma")]
public partial class TipoPrograma
{
    [Key]
    [Column("idTipoPrograma")]
    public int IdTipoPrograma { get; set; }

    [Column("nomePrograma")]
    [StringLength(100)]
    [Unicode(false)]
    public string NomePrograma { get; set; } = null!;

    [InverseProperty("IdTipoProgramaNavigation")]
    public virtual ICollection<Voluntario> Voluntarios { get; set; } = new List<Voluntario>();
}
