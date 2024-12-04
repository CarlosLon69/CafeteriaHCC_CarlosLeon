using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CafeteriaHCC_CarlosLeon.Models
{
    public partial class DBCAFETERIAHCCContext : DbContext
    {
        public DBCAFETERIAHCCContext()
        {
        }

        public DBCAFETERIAHCCContext(DbContextOptions<DBCAFETERIAHCCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbHccAlmacen> TbHccAlmacens { get; set; } = null!;
        public virtual DbSet<TbHccEstatusOrden> TbHccEstatusOrdens { get; set; } = null!;
        public virtual DbSet<TbHccMesa> TbHccMesas { get; set; } = null!;
        public virtual DbSet<TbHccOrdene> TbHccOrdenes { get; set; } = null!;
        public virtual DbSet<TbHccOrdenesDetalle> TbHccOrdenesDetalles { get; set; } = null!;
        public virtual DbSet<TbHccProducto> TbHccProductos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbHccAlmacen>(entity =>
            {
                entity.HasKey(e => e.AlmId)
                    .HasName("PK__Tb_HccAl__827601FCD52DDC6D");

                entity.ToTable("Tb_HccAlmacen");

                entity.Property(e => e.AlmId).HasColumnName("alm_id");

                entity.Property(e => e.AlmCantidad).HasColumnName("alm_cantidad");

                entity.Property(e => e.AlmEstatus).HasColumnName("alm_estatus");

                entity.Property(e => e.AlmFechaActualizacion)
                    .HasColumnType("date")
                    .HasColumnName("alm_fecha_actualizacion");
            });

            modelBuilder.Entity<TbHccEstatusOrden>(entity =>
            {
                entity.HasKey(e => e.CatordId)
                    .HasName("PK__Tb_HccEs__83E92BB322484F94");

                entity.ToTable("Tb_HccEstatusOrden");

                entity.Property(e => e.CatordId).HasColumnName("catord_id");

                entity.Property(e => e.CatordEstatus).HasColumnName("catord_estatus");

                entity.Property(e => e.CatordNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("catord_nombre");
            });

            modelBuilder.Entity<TbHccMesa>(entity =>
            {
                entity.HasKey(e => e.MesId)
                    .HasName("PK__Tb_HccMe__86A20DC37AD7B1E2");

                entity.ToTable("Tb_HccMesas");

                entity.Property(e => e.MesId).HasColumnName("mes_id");

                entity.Property(e => e.MesDisponible).HasColumnName("mes_disponible");

                entity.Property(e => e.MesEstatus).HasColumnName("mes_estatus");

                entity.Property(e => e.MesLugares).HasColumnName("mes_lugares");
            });

            modelBuilder.Entity<TbHccOrdene>(entity =>
            {
                entity.HasKey(e => e.OrdId)
                    .HasName("PK__Tb_HccOr__DC39D7DFF7E1243D");

                entity.ToTable("Tb_HccOrdenes");

                entity.Property(e => e.OrdId).HasColumnName("ord_id");

                entity.Property(e => e.CatordId).HasColumnName("catord_id");

                entity.Property(e => e.MesId).HasColumnName("mes_id");

                entity.Property(e => e.OrdEstatus).HasColumnName("ord_estatus");

                entity.Property(e => e.OrdFechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("ord_fecha_inicio");

                entity.HasOne(d => d.Catord)
                    .WithMany(p => p.TbHccOrdenes)
                    .HasForeignKey(d => d.CatordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_catord_id");

                entity.HasOne(d => d.Mes)
                    .WithMany(p => p.TbHccOrdenes)
                    .HasForeignKey(d => d.MesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mes_id");
            });

            modelBuilder.Entity<TbHccOrdenesDetalle>(entity =>
            {
                entity.HasKey(e => e.OrddetId)
                    .HasName("PK__Tb_HccOr__9BFA4D2F289DA013");

                entity.ToTable("Tb_HccOrdenesDetalle");

                entity.Property(e => e.OrddetId).HasColumnName("orddet_id");

                entity.Property(e => e.OrdId).HasColumnName("ord_id");

                entity.Property(e => e.OrddetCantidad).HasColumnName("orddet_cantidad");

                entity.Property(e => e.OrddetEstatus).HasColumnName("orddet_estatus");

                entity.Property(e => e.ProId).HasColumnName("pro_id");

                entity.HasOne(d => d.Ord)
                    .WithMany(p => p.TbHccOrdenesDetalles)
                    .HasForeignKey(d => d.OrdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ord_id");

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.TbHccOrdenesDetalles)
                    .HasForeignKey(d => d.ProId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pro_id");
            });

            modelBuilder.Entity<TbHccProducto>(entity =>
            {
                entity.HasKey(e => e.ProId)
                    .HasName("PK__Tb_HccPr__335E4CA62B119C69");

                entity.ToTable("Tb_HccProductos");

                entity.Property(e => e.ProId).HasColumnName("pro_id");

                entity.Property(e => e.AlmId).HasColumnName("alm_id");

                entity.Property(e => e.ProDescripcion)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("pro_descripcion");

                entity.Property(e => e.ProEstatus).HasColumnName("pro_estatus");

                entity.Property(e => e.ProNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pro_nombre");

                entity.Property(e => e.ProPrecio)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("pro_precio");

                entity.HasOne(d => d.Alm)
                    .WithMany(p => p.TbHccProductos)
                    .HasForeignKey(d => d.AlmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_alm_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
