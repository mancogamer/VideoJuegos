using Microsoft.EntityFrameworkCore;
using PracticaVideojuegos.Models;

namespace PracticaVideojuegos.Context
{
    public class Aplicacion_contexto : DbContext
    {
        public Aplicacion_contexto
            
            (DbContextOptions<Aplicacion_contexto> options)
            : base(options) { 
        }

        public DbSet<Usuario> usuarios { 
            get; set; 
        }

    }
}