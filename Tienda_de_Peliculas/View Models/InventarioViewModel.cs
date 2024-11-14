using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas.View_Models
{
    public class InventarioViewModel
    {
        [DisplayName("Id")]
        public int inve_Id { get; set; }

        [DisplayName("Título Original")]
        public string inve_Titulo { get; set; }

        [DisplayName("Año de Lanzamiento")]
        public string inve_Anio { get; set; }

        [DisplayName("Género")]
        public string gene_Descripcion { get; set; }

        [DisplayName("Duración")]
        public int inve_Duracion { get; set; }

        [DisplayName("Formato")]
        public string form_Descripcion { get; set; }

        [DisplayName("Estado")]
        public string esta_Descripcion { get; set; }

        [DisplayName("Descripción")]
        public string inve_Descripcion { get; set; }

        [DisplayName("Idioma")]
        public string idio_Descripcion { get; set; }

        [DisplayName("Existencias")]
        public int inve_Cantidad { get; set; }

        [DisplayName("Precio")]
        public decimal inve_Precio { get; set; }

        [DisplayName("Clasificación")]
        public string clas_Descripcion { get; set; } 

        /*[DisplayName("Usuario Creador")]
        public string usua_UsuarioCreacion { get; set; }

        [DisplayName("Usuario Modificador")]
        public string usua_UsuarioModificacion { get; set; }*/
       
    }
}
