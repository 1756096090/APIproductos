using APIproductos.Models;
using Microsoft.EntityFrameworkCore;

namespace APIproductos.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(
            DbContextOptions<ApplicationDBContext> options
            ) : base( options ) { }
        
        public DbSet<Producto> Producto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    IdProducto = 1,
                    Nombre = "Producto1",
                    Descripcion = "Descripcion del producto1",
                    Cantidad = 12
                }

                ) ; 
            
            
            
        }

    }
}
