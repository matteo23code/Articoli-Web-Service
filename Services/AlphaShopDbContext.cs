using ArticoliWebService.Models;
using Microsoft.EntityFrameworkCore;

namespace ArticoliWebService.Services
{
    public class AlphaShopDbContext : DbContext
    {
        public AlphaShopDbContext(DbContextOptions<AlphaShopDbContext> options)
        : base(options)
        //riferimento alla classe base
        {

        }

    public virtual DbSet<Articoli>  Articoli { get; set; }

        public virtual DbSet<Ean> Barcode { get; set; }
        public virtual DbSet<FamAssort> FamAssorts { get; set; }
        public virtual DbSet<Ingredienti> Ingredienti { get; set; }

        public virtual DbSet<Iva> Iva { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articoli>()
            .HasKey(a => new { a.CodArt });

            //Relazione on to many (uno a molti) fra articoli e barcode
            modelBuilder.Entity<Ean>()
            .HasOne<Articoli>(s => s.Articolo) //ad un articolo..
            .WithMany(g => g.Barcode) //corrispondono molti barcode
            .HasForeignKey(s => s.CodArt); //la chiave esterna dell' entity barcode

            //Relazione one to one (uno a uno ) tra articoli e ingredienti
            modelBuilder.Entity<Articoli>()
            .HasOne<Ingredienti>(S => S.Ingrediente) // ad un articolo
            .WithOne(g => g.Articolo) // Corrisponde un ingrediente
            .HasForeignKey<Ingredienti>(s => s.CodArt);

            // Relazione one to many tra iva e articoli
            modelBuilder.Entity<Articoli>()
            .HasOne<Iva>(s => s.iva)
            .WithMany(g => g.Articoli)
            .HasForeignKey(s => s.idiva);

            //Relazione one to many fra FamAssort e articoli
            modelBuilder.Entity<Articoli>()
            .HasOne<FamAssort>(s => s.FamAssort)
            .WithMany(g => g.Articoli)
            .HasForeignKey(s => s.idfamass);
        }
    }

}