using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace entitywinform.modelos;

public partial class CrudemaContext : DbContext
{


    public DbSet<Usuario> Usuario{ get; set; }
    public CrudemaContext()
    {
    }

    public CrudemaContext(DbContextOptions<CrudemaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost; Database=crudema; Trusted_Connection=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Idusuario).HasName("PK__ENT_1__98242AA961CE4A87");

            entity.ToTable("usuarios");

            entity.HasIndex(e => e.Idusuario, "ENT_1_PK").IsUnique();

            entity.Property(e => e.Idusuario).HasColumnName("IDUSUARIO");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
