using APICatalogo.Model;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace APICatalogo.Context
{
    public class ApiCatalogoAppDbContext : DbContext
    {
        public ApiCatalogoAppDbContext(DbContextOptions<ApiCatalogoAppDbContext> options):base(options){}
        public DbSet<Categoria>? Categoria { get; set; }
        public DbSet<Produto>? Produto { get; set; }

        
    }
}

 
