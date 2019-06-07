using Kusina.Application.Interfaces;
using Kusina.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kusina.Persistence
{
    public class KusinaDbContext : DbContext, IKusinaDbContext
    {
        public KusinaDbContext()
        {
        }

        public KusinaDbContext(DbContextOptions<KusinaDbContext> options)
            : base (options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connString = "";
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(connString);
            }
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Step> Steps { get; set; }
    }
}
