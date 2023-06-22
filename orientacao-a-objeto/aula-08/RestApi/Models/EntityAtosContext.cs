using Microsoft.EntityFrameworkCore;

namespace RestApi.Models;

public class EntityAtosContext : DbContext
{
    public DbSet<Pessoa>? Pessoas { get; set; }
    public DbSet<Email>? Emails { get; set; }

    // public EntityAtosContext(DbContextOptions<Contexto> options) : base(options) { }
    public EntityAtosContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=CodeFirst; User ID=atos; password=senha123; language=Portuguese; TrustServerCertificate=True");
        // optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Email>()
            .HasOne(email => email.pessoa)
            .WithMany(pessoa => pessoa.Emails)
            .OnDelete(DeleteBehavior.ClientCascade);
    }
}
