using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EcocaminhosApi.Models;

[Table("Casa")]
public partial class Casa
{
    [Key]
    [Column("idCasa")]
    public int IdCasa { get; set; }

    [Column("nomeCasa")]
    [StringLength(100)]
    [Unicode(false)]
    public string NomeCasa { get; set; } = null!;

    [Column("num_quartos")]
    public int NumQuartos { get; set; }

    [InverseProperty("IdCasaNavigation")]
    public virtual ICollection<Quarto> Quartos { get; set; } = new List<Quarto>();

    [InverseProperty("IdCasaNavigation")]
    public virtual ICollection<Voluntario> Voluntarios { get; set; } = new List<Voluntario>();
}
