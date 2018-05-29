using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Projekt
{
    public partial class HubertdbContext : DbContext
    {
        public virtual DbSet<Butik> Butiks { get; set; }
        public virtual DbSet<Produkt> Produkts { get; set; }
        public virtual DbSet<ProduktListe> ProduktListes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=projekt-hubert.database.windows.net;Initial Catalog=HubertDB;Persist Security Info=True;User ID=hubert;Password=Analrundfart1");
#pragma warning restore CS1030 // #warning directive
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
                entity.Ignore(e => e.Key);
            });

            modelBuilder.Entity<Produkt>(entity =>
            {
                entity.ToTable("Produkt");

                entity.Property(e => e.ProduktId)
                    .HasColumnName("ProduktID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Materiale).IsUnicode(false);

                entity.Property(e => e.ProduktNavn).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
                entity.Ignore(e => e.Key);
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
                entity.Ignore(e => e.Key);
            });
        }
    }
}
