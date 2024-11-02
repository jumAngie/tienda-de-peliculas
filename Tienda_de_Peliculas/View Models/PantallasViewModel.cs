using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas.View_Models
{
    public class PantallasViewModel
    {
        public int pant_ID { get; set; }
        public string pant_NombrePantalla { get; set; }
        public string pant_RutaImagen { get; set; }
        public string pant_NombreBoton { get; set; }
        public int PosicionY { get; set; }
    }
}
