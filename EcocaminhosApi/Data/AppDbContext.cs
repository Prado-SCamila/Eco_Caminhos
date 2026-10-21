using System;
using System.Collections.Generic;
using EcocaminhosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EcocaminhosApi.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Casa> Casas { get; set; }

    public virtual DbSet<Quarto> Quartos { get; set; }

    public virtual DbSet<Situacao> Situacaos { get; set; }

    public virtual DbSet<TipoPrograma> TipoProgramas { get; set; }

    public virtual DbSet<Voluntario> Voluntarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:Default");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Casa>(entity =>
        {
            entity.HasKey(e => e.IdCasa).HasName("PK__Casa__8BA3F09399CB0B08");
        });

        modelBuilder.Entity<Quarto>(entity =>
        {
            entity.HasKey(e => e.IdQuarto).HasName("PK__Quarto__BCCFA29862294D5A");

            entity.HasOne(d => d.IdCasaNavigation).WithMany(p => p.Quartos).HasConstraintName("FK__Quarto__idCasa__6383C8BA");
        });

        modelBuilder.Entity<Situacao>(entity =>
        {
            entity.HasKey(e => e.IdSituacaoFinanceira).HasName("PK__Situacao__3E7C6275E5F152F2");
        });

        modelBuilder.Entity<TipoPrograma>(entity =>
        {
            entity.HasKey(e => e.IdTipoPrograma).HasName("PK__TipoProg__ADE3CFA2308DF68C");
        });

        modelBuilder.Entity<Voluntario>(entity =>
        {
            entity.HasKey(e => e.IdVoluntario).HasName("PK__Voluntar__0BF2AA360F36DCE0");

            entity.HasOne(d => d.IdCasaNavigation).WithMany(p => p.Voluntarios).HasConstraintName("FK__Voluntari__idCas__6FE99F9F");

            entity.HasOne(d => d.IdQuartoNavigation).WithMany(p => p.Voluntarios).HasConstraintName("FK__Voluntari__idQua__70DDC3D8");

            entity.HasOne(d => d.IdSituacaoFinanceiraNavigation).WithMany(p => p.Voluntarios).HasConstraintName("FK__Voluntari__idSit__71D1E811");

            entity.HasOne(d => d.IdTipoProgramaNavigation).WithMany(p => p.Voluntarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Voluntarios_TipoPrograma");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
