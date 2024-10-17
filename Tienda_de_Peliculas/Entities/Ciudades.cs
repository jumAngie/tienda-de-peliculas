using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas.Clases
{
    public class Ciudades
    {
        public int ciud_Id { get; set; }
        public int dept_Id { get; set; }
        public string ciud_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime ciud_FechaCreacion { get; set; }
        public int usua_UsuarioModificacion { get; set; }
        public DateTime ciud_FechaModificacion { get; set; }
        public bool ciud_Estado { get; set; }

        public int pais_Id { get; set; }

        public Ciudades() { }

        public Ciudades(int ciud_Id, int dept_Id, string ciud_Descripcion, int usua_UsuarioCreacion, DateTime ciud_FechaCreacion, int usua_UsuarioModificacion, DateTime ciud_FechaModificacion, bool ciud_Estado)
        {
            this.ciud_Id = ciud_Id;
            this.dept_Id = dept_Id;
            this.ciud_Descripcion = ciud_Descripcion;
            this.usua_UsuarioCreacion = usua_UsuarioCreacion;
            this.ciud_FechaCreacion = ciud_FechaCreacion;
            this.usua_UsuarioModificacion = usua_UsuarioModificacion;
            this.ciud_FechaModificacion = ciud_FechaModificacion;
            this.ciud_Estado = ciud_Estado;
        }
    }

   

}
