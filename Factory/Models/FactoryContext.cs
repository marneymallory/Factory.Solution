using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContextFactory : DbContext
  {
    public virtual DbSet<Machine> Machines { get; set; }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<EngineerMachine> EngineerMachine { get; set; }
    
    public FactoryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}