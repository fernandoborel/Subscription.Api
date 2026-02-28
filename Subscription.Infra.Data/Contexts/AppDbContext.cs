using Microsoft.EntityFrameworkCore;
using Subscription.Infra.Data.Configurations;

namespace Subscription.Infra.Data.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options){}

    //Configurar os mapeamentos
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        modelBuilder.ApplyConfiguration(new PlanoConfiguration());
        modelBuilder.ApplyConfiguration(new AssinaturaConfiguration());
    }
}