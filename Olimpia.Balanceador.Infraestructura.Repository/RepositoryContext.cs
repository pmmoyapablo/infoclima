using Olimpia.Balanceador.Dominio.Entity;
using Microsoft.EntityFrameworkCore;

namespace Olimpia.Balanceador.Infraestructura.Repository
{
  public class RepositoryContext : DbContext
  {
    private readonly string _connectionString;
    public RepositoryContext(string connectionString)
    {
      _connectionString = connectionString;
    }

    public DbSet<Climates> Climates { get; set; }
    public DbSet<Users> Users { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(_connectionString);
    }
  }
}