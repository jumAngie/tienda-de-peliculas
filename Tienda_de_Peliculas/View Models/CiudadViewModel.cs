using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas.Vistas
{
    public class CiudadViewModel
    {
        [DisplayName("Id Ciudad")]
        public int CiudadID { get; set; }

        [DisplayName("País")]
        public string Pais { get; set; }

        [DisplayName("Departamento")]
        public string Departamento { get; set; }

        [DisplayName("Ciudad")]
        public string Ciudad {  get; set; }

        [DisplayName("Usuario Creación")]
        public string UsuarioCreador { get; set; }
    }
}
