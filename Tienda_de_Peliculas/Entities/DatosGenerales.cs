using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas.Clases
{
    public class DatosGenerales
    {
        public int dato_Id { get; set; }
        public string dato_NombreCompleto { get; set; }
        public string dato_DNI { get; set; }
        public string dato_Telefono { get; set; }
        public string dato_email { get; set; }
        public int ciud_Id { get; set; }
        public string dato_Direccion { get; set; }
        public DateTime dato_FechaNacimiento { get; set; }
        public int sexo_Id { get; set; }
        public int cate_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime dato_FechaCreacion { get; set; }
        public int usua_UsuarioModificacion { get; set; }
        public DateTime dato_FechaModificacion { get; set; }
        public bool dato_Estado { get; set; }

        [NotMapped]
        public int dept_Id { get; set; }

        [NotMapped]
        public int pais_Id { get; set; }

    }
}
