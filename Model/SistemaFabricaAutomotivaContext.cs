using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjetoEstacionamento.Model;

public partial class SistemaFabricaAutomotivaContext : DbContext
{
    public SistemaFabricaAutomotivaContext()
    {
    }

    public SistemaFabricaAutomotivaContext(DbContextOptions<SistemaFabricaAutomotivaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alocacao> Alocacaos { get; set; }

    public virtual DbSet<Automovei> Automoveis { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Concessionaria> Concessionarias { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=;Initial Catalog=SistemaFabricaAutomotiva;Integrated Security=SSPI;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alocacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Alocacao__3214EC27CBDBD6BC");

            entity.ToTable("Alocacao");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Automovei>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Automove__3214EC270CE46A2B");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Modelo)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC27F4E70C81");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Concessionaria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Concessi__3214EC27075A4DE0");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
