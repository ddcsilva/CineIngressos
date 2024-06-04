using IngressosNet.Models;
using Microsoft.EntityFrameworkCore;

namespace IngressosNet.Data;

public class IngressosNetContext(DbContextOptions<IngressosNetContext> options) : DbContext(options)
{
    public DbSet<Ator> Atores { get; set; } = null!;
    public DbSet<Cinema> Cinemas { get; set; } = null!;
    public DbSet<Filme> Filmes { get; set; } = null!;
    public DbSet<Produtor> Produtores { get; set; } = null!;
    public DbSet<AtorFilme> AtoresFilmes { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AtorFilme>()
            .HasKey(af => new { af.AtorId, af.FilmeId });

        modelBuilder.Entity<AtorFilme>()
            .HasOne(af => af.Ator)
            .WithMany(a => a.AtoresFilmes)
            .HasForeignKey(af => af.AtorId);

        modelBuilder.Entity<AtorFilme>()
            .HasOne(af => af.Filme)
            .WithMany(f => f.AtoresFilmes)
            .HasForeignKey(af => af.FilmeId);

        base.OnModelCreating(modelBuilder);
    }
}
