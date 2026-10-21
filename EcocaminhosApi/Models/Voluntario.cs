using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EcocaminhosApi.Models;

public partial class Voluntario
{
    [Key]
    [Column("idVoluntario")]
    public int IdVoluntario { get; set; }

    [Column("nome")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [Column("dataNascimento", TypeName = "datetime")]
    public DateTime DataNascimento { get; set; }

    [Column("email")]
    [StringLength(100)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("nacionalidade")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nacionalidade { get; set; } = null!;

    [Column("valorAdevolver", TypeName = "decimal(10, 2)")]
    public decimal? ValorAdevolver { get; set; }

    [Column("idCasa")]
    public int? IdCasa { get; set; }

    [Column("idQuarto")]
    public int? IdQuarto { get; set; }

    [Column("idSituacaoFinanceira")]
    public int? IdSituacaoFinanceira { get; set; }

    [Column("dataEntrada", TypeName = "datetime")]
    public DateTime DataEntrada { get; set; }

    [Column("dataSaida", TypeName = "datetime")]
    public DateTime DataSaida { get; set; }

    [Column("idTipoPrograma")]
    public int IdTipoPrograma { get; set; }

    [ForeignKey("IdCasa")]
    [InverseProperty("Voluntarios")]
    public virtual Casa? IdCasaNavigation { get; set; }

    [ForeignKey("IdQuarto")]
    [InverseProperty("Voluntarios")]
    public virtual Quarto? IdQuartoNavigation { get; set; }

    [ForeignKey("IdSituacaoFinanceira")]
    [InverseProperty("Voluntarios")]
    public virtual Situacao? IdSituacaoFinanceiraNavigation { get; set; }

    [ForeignKey("IdTipoPrograma")]
    [InverseProperty("Voluntarios")]
    public virtual TipoPrograma IdTipoProgramaNavigation { get; set; } = null!;
}
