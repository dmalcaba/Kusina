using Kusina.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kusina.Persistence
{
    public class KusinaDbContext : DbContext
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
