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

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Step> Steps { get; set; }
    }
}
