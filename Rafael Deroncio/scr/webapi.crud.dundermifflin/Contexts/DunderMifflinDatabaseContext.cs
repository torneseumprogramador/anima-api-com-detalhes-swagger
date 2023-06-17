using Microsoft.EntityFrameworkCore;
using webapi.crud.dundermifflin.Entities;

namespace webapi.crud.dundermifflin.Contexts;

public class DunderMifflinDatabaseContext : DbContext
{
    public DbSet<Funcionario> Funcionarios { get; set; }

    public DunderMifflinDatabaseContext(DbContextOptions<DunderMifflinDatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }

}