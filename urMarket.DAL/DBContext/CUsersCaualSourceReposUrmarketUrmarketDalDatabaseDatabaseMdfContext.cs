using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using urMarket.MODEL;

namespace urMarket.DAL.DBContext;

public partial class CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext : DbContext
{
    public CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext()
    {
    }

    public CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext(DbContextOptions<CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Carrinho> Carrinhos { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\caual\\source\\repos\\urMarket\\urMarket.DAL\\database\\database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Carrinho>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Carrinho__3214EC072B8493FC");

            entity.ToTable("Carrinho");

            entity.Property(e => e.IdProd).HasColumnName("Id_Prod");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            /*
            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.Carrinhos)
                .HasForeignKey(d => d.IdProd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Carrinho__Id_Pro__3D5E1FD2");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Carrinhos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Carrinho__Id_Usu__3E52440B");
            */
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC079A5BEE90");

            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Produto__3214EC073AD8E9AA");

            entity.ToTable("Produto");

            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdCat).HasColumnName("Id_Cat");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
            /*
            entity.HasOne(d => d.IdCatNavigation).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.IdCat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Produto__Id_Cat__3A81B327");
            */
            
           
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC07A123E3D9");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Senha)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
