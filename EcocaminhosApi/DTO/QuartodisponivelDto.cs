using EcocaminhosApi.Data;
using EcocaminhosApi.Interfaces;
using EcocaminhosApi.Models;
using Microsoft.EntityFrameworkCore;

public class QuartoDisponivelDto
{
    public string NomeCasa { get; set; } = null!;
    public string NomeQuarto { get; set; } = null!;
    public int Capacidade { get; set; }
    public int TotalVoluntarios { get; set; }
    public int VagasDisponiveis { get; set; }
}