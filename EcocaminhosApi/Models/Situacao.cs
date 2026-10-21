using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EcocaminhosApi.Models;

[Table("Situacao")]
public partial class Situacao
{
    [Key]
    [Column("idSituacaoFinanceira")]
    public int IdSituacaoFinanceira { get; set; }

    [Column("nomeSituacao")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomeSituacao { get; set; } = null!;

    [InverseProperty("IdSituacaoFinanceiraNavigation")]
    public virtual ICollection<Voluntario> Voluntarios { get; set; } = new List<Voluntario>();
}
