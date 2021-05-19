using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyAPI.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string LinkImagen { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Calificacion { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
        
        public IEnumerable<PersonajesPeliculas> PersonajesPeliculas { get; set; }
    }
}
