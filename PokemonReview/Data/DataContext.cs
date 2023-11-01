using Microsoft.EntityFrameworkCore;
using PokemonReview.Models;

namespace PokemonReview.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        
            
        
        }

        // the object of dbset is always going to be pluralised 
        public DbSet<Catagory> catagories { get; set; }
        public DbSet<Country> countries { get; set; }   
        public DbSet<Owner> owners { get; set; }
        public DbSet<Pokemon> pokemons { get; set; }
        public DbSet<PokemonOwner> pokemonsOwners { get; set; }
        public DbSet<PokemonCatagory> pokemonsCatagories { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<Reviewer> reviewers {  get; set; }


        //For many to many tables, needed for model creating 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCatagory>()
                .HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            modelBuilder.Entity<PokemonCatagory>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc => pc.PokemonCatagories)
                .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonCatagory>()
                .HasOne(p => p.Catagory)
                .WithMany(pc => pc.PokemonCatagories)
                .HasForeignKey(c => c.CategoryId);


            modelBuilder.Entity<PokemonOwner>()
                .HasKey(po => new { po.PokemonId, po.OwnerId });
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc => pc.PokemonOwners)
                .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(p => p.Owner)
                .WithMany(pc => pc.PokemonOwners)
                .HasForeignKey(c => c.OwnerId);
        }



    }
}
