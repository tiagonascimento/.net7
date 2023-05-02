using APICatalogo.Model;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace APICatalogo.Context
{
    public class ApiCatalogoAppDbContext : DbContext
    {
        public ApiCatalogoAppDbContext(DbContextOptions<ApiCatalogoAppDbContext> options):base(options){}
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }

        
    }
}

 
