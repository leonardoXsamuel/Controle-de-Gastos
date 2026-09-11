using Controle_de_Gastos.model;
using Microsoft.EntityFrameworkCore;

namespace Controle_de_Gastos.Context;

public class GastoDbContext : DbContext
{
    public GastoDbContext(DbContextOptions<GastoDbContext> options) : base(options) { }

    public DbSet<Gasto> Gastos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<Gasto>()
        //    .HasIndex(u => u.Id)
        //    .IsUnique();
    }
}
