using System.ComponentModel.DataAnnotations;

namespace PracticaVideojuegos.Models
{
    public class Videojuego
    {
        [Key]
        public int id_videoJuego { 
            get; set;
        }
        public string nombre {
            get; set; 
        }
        public string tipo_de_pago { 
            get; set;
        }
        public bool es_grupal { 
            get; set; 
        }
        public string tipo { 
            get; set; 
        }

    }
}