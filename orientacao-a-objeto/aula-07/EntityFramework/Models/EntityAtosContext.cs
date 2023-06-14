using System.Configuration;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework;

public class EntityAtosContext : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<Email> Emails { get; set; }

    // public EntityAtosContext(DbContextOptions<Contexto> options) : base(options) { }
    public EntityAtosContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        try
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["EntityAtos"];
            string conexao = "";

            if (settings != null) conexao = settings.ConnectionString;

            optionsBuilder.UseSqlServer(conexao);
            optionsBuilder.UseLazyLoadingProxies();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Email>()
            .HasOne(email => email.pessoa)
            .WithMany(pessoa => pessoa.emails)
            .OnDelete(DeleteBehavior.ClientCascade);

    }

}
