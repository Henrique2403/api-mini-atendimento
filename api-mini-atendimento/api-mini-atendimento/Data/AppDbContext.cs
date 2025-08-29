using api_mini_atendimento.Models;
using Microsoft.EntityFrameworkCore;

namespace api_mini_atendimento.Data;

public class AppDbContext : DbContext
{

  public AppDbContext(DbContextOptions options) : base(options){ }

    DbSet<Cliente> Cliente {  get; set; }
    DbSet<Atendimento> Atendimento { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>()
            .HasMany(c => c.Atendimentos)
            .WithOne(a => a.Cliente!)
            .HasForeignKey(a => a.ClienteId);
    }
}
