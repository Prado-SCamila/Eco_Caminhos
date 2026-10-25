using System.ComponentModel.DataAnnotations;
using EcocaminhosApi.Data;
using EcocaminhosApi.Interfaces;
using EcocaminhosApi.Models;
using Microsoft.EntityFrameworkCore;


namespace EcocaminhosApi.DTOs
{
    public class AlocacaoVoluntarioDto
    {
        public string Nome { get; set; } = null!;
        public int? IdCasa { get; set; }
        public int? IdQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
    }
}

