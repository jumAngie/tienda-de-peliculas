using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas.View_Models
{
    public class FacturaViewModel
    {
        [DisplayName("ID")]
        public int inve_Id {  get; set; }

        [DisplayName("Número Factura")]
        public string fact_NumFactura { get; set; }

        [DisplayName("Nombre de la Pelicula")]
        public string inve_Titulo { get; set; }

        [DisplayName("Total")]
        public decimal inve_Total { get; set; }
    }
}
