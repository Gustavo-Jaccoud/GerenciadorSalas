using ApiGerenciadorSalas.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiGerenciadorSalas.Context;

public class AppDbContext : DbContext
{
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Sala> Salas { get; set; }
    public DbSet<Software> Softwares { get; set; }
    public DbSet<SalaSoftware> SalaSoftwares { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SalaSoftware>()
            .HasKey(ss => new { ss.SalaId, ss.SoftwareId });

        modelBuilder.Entity<SalaSoftware>()
            .HasOne(ss => ss.Sala)
            .WithMany(s => s.SalaSoftwares)
            .HasForeignKey(ss => ss.SalaId);

        modelBuilder.Entity<SalaSoftware>()
            .HasOne(ss => ss.Software)
            .WithMany(s => s.SalaSoftwares)
            .HasForeignKey(ss => ss.SoftwareId);
    }
}