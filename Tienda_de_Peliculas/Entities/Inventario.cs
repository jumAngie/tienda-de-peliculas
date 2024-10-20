using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas.Clases
{
    public class Inventario
    {
        public int inve_Id {  get; set; }
        public string inve_Titulo { get; set; }
		public string inve_Anio { get; set; }
		public int gene_Id { get; set; }
		public string inve_Duracion { get; set; }
		public int form_Id { get; set; }
		public int esta_Id { get; set; }
		public string inve_Descripcion { get; set; }
		public int idio_Id { get; set; }
		public int inve_Cantidad { get; set; }
		public double inve_Precio { get; set; }
		public int clas_Id { get; set; }
		public int usua_UsuarioCreacion { get; set; }
		public DateTime inve_FechaCreacion { get; set; }
		public int usua_UsuarioModificacion { get; set; }
		public DateTime inve_FechaModificacion { get; set; }
		public bool inve_Estado { get; set; }


    }
}
