using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas.Entities
{
    public class Facturas
    {
        
        public int fact_id  {get; set; }
        public int meto_id {get; set; }  
        public int dato_id { get; set; }
        public string fact_NumFactura { get; set; }
        public DateTime fact_fechafactura { get; set; }
        public int tran_id { get; set; }
        public decimal fact_impuesto { get; set; }
        public decimal fact_descuento { get; set; }
        public decimal fact_subtotal { get; set; }
        public int inve_id { get; set; }
        public DateTime fact_fechadev { get; set; }  
        public decimal fact_total  { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime fact_FechaCreacion  { get; set; }
        public int usua_UsuarioModificacion  { get; set; }
        public DateTime fact_FechaModificacion { get; set; }
        public bool fact_estado { get; set; }

    }

}