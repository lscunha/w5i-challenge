using Microsoft.EntityFrameworkCore;
using w5i.Models;

namespace w5i.Data
{
    public class c : DbContext
    {
        public ControleAcessoContext(DbContextOptions<ControleAcessoContext> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<RegistroAcesso> RegistrosAcesso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .HasMany(p => p.RegistrosAcesso)
                .WithOne(r => r.Pessoa)
                .HasForeignKey(r => r.PessoaId);
        }
    }
}