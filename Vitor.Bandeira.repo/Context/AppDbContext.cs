
using Microsoft.EntityFrameworkCore;
using Vitor.Bandeira.Models;

namespace Vitor.Bandeira.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Veiculo> Veiculos { get; set; } = default!;
    }
}