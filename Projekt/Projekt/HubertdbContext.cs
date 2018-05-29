using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Projekt
{
    public partial class HubertdbContext : DbContext
    {
        public virtual DbSet<Butik> Butiks { get; set; }
        public virtual DbSet<Materiale> Materiales { get; set; }
        public virtual DbSet<Produkt> Produkts { get; set; }
        public virtual DbSet<ProduktListe> ProduktListes { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=projekt-hubert.database.windows.net;Initial Catalog=HubertDB;Persist Security Info=True;User ID=Hubert;Password=Analrundfart1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Butik>(entity =>
            {
                entity.ToTable("Butik");

                entity.Property(e => e.ButikId)
                    .HasColumnName("ButikID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adresse).IsUnicode(false);

                entity.Property(e => e.Tlf).IsUnicode(false);
            });

            modelBuilder.Entity<Materiale>(entity =>
            {
                entity.ToTable("Materiale");

                entity.Property(e => e.MaterialeId)
                    .HasColumnName("MaterialeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaterialeNavn).IsUnicode(false);
            });

            modelBuilder.Entity<Produkt>(entity =>
            {
                entity.ToTable("Produkt");

                entity.Property(e => e.ProduktId)
                    .HasColumnName("ProduktID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FkMaterialeId).HasColumnName("fkMaterialeID");

                entity.Property(e => e.FkTypeId).HasColumnName("fkTypeID");

                entity.Property(e => e.ProduktNavn).IsUnicode(false);

                entity.HasOne(d => d.FkMateriale)
                    .WithMany(p => p.Produkts)
                    .HasForeignKey(d => d.FkMaterialeId)
                    .HasConstraintName("FK__Produkt__fkMater__787EE5A0");

                entity.HasOne(d => d.FkType)
                    .WithMany(p => p.Produkts)
                    .HasForeignKey(d => d.FkTypeId)
                    .HasConstraintName("FK__Produkt__fkTypeI__797309D9");
            });

            modelBuilder.Entity<ProduktListe>(entity =>
            {
                entity.HasKey(e => new { e.FkProduktId, e.FkButikId, e.Stoerrelse });

                entity.ToTable("ProduktListe");

                entity.Property(e => e.FkProduktId).HasColumnName("fkProduktID");

                entity.Property(e => e.FkButikId).HasColumnName("fkButikID");

                entity.Property(e => e.Pris).IsUnicode(false);

                entity.HasOne(d => d.FkButik)
                    .WithMany(p => p.ProduktListes)
                    .HasForeignKey(d => d.FkButikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProduktLi__fkBut__7B5B524B");

                entity.HasOne(d => d.FkProdukt)
                    .WithMany(p => p.ProduktListes)
                    .HasForeignKey(d => d.FkProduktId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProduktLi__fkPro__7A672E12");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("Type");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TypeNavn).IsUnicode(false);
            });
        }
    }
}
