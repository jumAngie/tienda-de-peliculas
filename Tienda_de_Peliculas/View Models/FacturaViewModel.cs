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
        /*
				usuC.usua_Usuario AS 'Usuario Creación',
				fact_FechaCreacion, 

				CASE WHEN usuM.usua_Usuario IS NULL THEN 'N/A' 
				ELSE usuM.usua_Usuario  
				END AS 'Usuario Modificador',

				fact_FechaModificacion
         */

        [DisplayName("ID")]
        public int fact_ID { get; set; }

        [DisplayName("Pelicula Id")]
        public int inve_Id { get; set; }

        [DisplayName("Nombre de la Pelicula")]
        public string inve_Titulo { get; set; }

        [DisplayName("Cliente")]
        public string dato_NombreCompleto { get; set; }

        [DisplayName("Número Factura")]
        public string fact_NumFactura { get; set; }

        [DisplayName("Fecha de la Factura")]
        public string fact_FechaFactura { get; set; }

        [DisplayName("Tipo de Transacción")]
        public string tran_Descripcion { get; set; }

        [DisplayName("ISV")]
        public string fact_Impuesto { get; set; }

        [DisplayName("Descuento")]
        public string fact_Descuento { get; set; }

        [DisplayName("Subtotal")]
        public string fact_Subtotal { get; set; }

        [DisplayName("Fecha devolución")]
        public string fact_fechaDev { get; set; }

        [DisplayName("Total")]
        public decimal inve_Total { get; set; }

    }
}
