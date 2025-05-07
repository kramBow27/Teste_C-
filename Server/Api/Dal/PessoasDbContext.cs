using Api.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Api.Dal
{
    public class PessoasDbContext : DbContext
    {
        public PessoasDbContext(DbContextOptions<PessoasDbContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas => Set<Pessoa>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(e =>
            {
                e.ToTable("Pessoas");
                e.HasKey("Id");
                e.Property(p => p.Id).HasColumnName("Id");
                e.Property(p => p.Nome).HasColumnName("Nome");
                e.Property(p => p.DataNascimento).HasColumnName("DataNascimento");
                e.Property(p => p.Endereco).HasColumnName("Endereco");
            }); 
        }
    }
}
