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

        [DisplayName("Número Factura")]
        public string fact_NumFactura { get; set; }

        [DisplayName("ID")]
        public int fact_ID { get; set; }

        [DisplayName("Cliente")]
        public string dato_NombreCompleto { get; set; }


        [DisplayName("Nombre de la Pelicula")]
        public string inve_Titulo { get; set; }

        [DisplayName("Metodo de pago")]
        public string meto_Descripcion { get; set; }

        [DisplayName("Fecha de la Factura")]
        public DateTime fact_FechaFactura { get; set; }

        [DisplayName("Tipo de Transacción")]
        public string tran_Descripcion { get; set; }

        [DisplayName("ISV")]
        public decimal fact_Impuesto { get; set; }

        [DisplayName("Descuento")]
        public decimal fact_Descuento { get; set; }

        [DisplayName("Subtotal")]
        public decimal fact_Subtotal { get; set; }

        [DisplayName("Total")]
        public decimal fact_Total { get; set; }

        [DisplayName("Fecha devolución")]
        public DateTime fact_fechaDev { get; set; }

    }
}
