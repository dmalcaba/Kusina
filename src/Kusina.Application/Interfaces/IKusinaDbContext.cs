using Kusina.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Kusina.Application.Interfaces
{
    public interface IKusinaDbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Ingredient> Ingredients { get; set; }
        DbSet<Recipe> Recipes { get; set; }
        DbSet<Step> Steps { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
