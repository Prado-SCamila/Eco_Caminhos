using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EcocaminhosApi.Models;

[Table("Quarto")]
public partial class Quarto
{
    [Key]
    [Column("idQuarto")]
    public int IdQuarto { get; set; }

    [Column("idCasa")]
    public int? IdCasa { get; set; }

    [Column("capacidade")]
    public int Capacidade { get; set; }

    [Column("nomeQuarto")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NomeQuarto { get; set; }

    [ForeignKey("IdCasa")]
    [InverseProperty("Quartos")]
    public virtual Casa? IdCasaNavigation { get; set; }

    [InverseProperty("IdQuartoNavigation")]
    public virtual ICollection<Voluntario> Voluntarios { get; set; } = new List<Voluntario>();
}
