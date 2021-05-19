using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyAPI.Models
{
    public class Personaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string LinkImagen { get; set; }
        public string Historia { get; set; }
        public int Peso { get; set; }
        public int Edad { get; set; }

        public IEnumerable<PersonajesPeliculas> PersonajesPeliculas { get; set; }





    }
}
