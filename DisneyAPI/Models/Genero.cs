using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyAPI.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string LinkImagen { get; set; }

        public IEnumerable<Pelicula> Peliculas { get; set; }
    }
}
