using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas.View_Models
{
    public  class ClientesViewModel
    {
        [DisplayName("Nombre Completo")]
        public string NombreCompleto{ get; set; }

        [DisplayName("DNI Cliente")]
        public string DNI { get; set; }

        [DisplayName("Telefono")]
        public string Telefono { get; set; }

        [DisplayName("E-mail")]
        public string email { get; set; }

        [DisplayName("Pais")]
        public string Pais_Descripcion { get; set; }

        [DisplayName("Departamnto")]
        public string Dept_Descripcion { get; set; }

        [DisplayName("Ciudad")]
        public string Ciud_Descripcion { get; set; }

        [DisplayName("Direccion")]
        public string Direccion { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [DisplayName("Sexo")]
        public string Sexo_Descripcion { get; set; }

        [DisplayName("Categoria")]
        public string Cate_Descripcion { get; set; }

        [DisplayName("Usuario")]
        public string usua_Usuario { get; set; }

        [DisplayName("Fecha de Creacion")]
        public DateTime Fecha_Creacion { get; set; }
    }
}
