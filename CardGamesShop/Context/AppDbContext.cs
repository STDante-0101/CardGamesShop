using CardGamesShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CardGamesShop.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
