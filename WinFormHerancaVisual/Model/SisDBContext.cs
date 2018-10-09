using System.Data.Entity;

namespace WinFormHerancaVisual.Model
{
    public class SisDBContext : DbContext
    {
        public SisDBContext() : base("name=ConSistema01")
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }

    
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Cliente>();
        //}


    }
}
