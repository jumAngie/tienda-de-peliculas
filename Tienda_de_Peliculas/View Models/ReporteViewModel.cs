using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas.View_Models
{
    public class ReporteViewModel
    {

        public int inve_Id {  get; set; }
        public string fact_NumFactura { get; set; }
        public string inve_Titulo { get; set; }
        public decimal inve_Total { get; set; }
    }
}
