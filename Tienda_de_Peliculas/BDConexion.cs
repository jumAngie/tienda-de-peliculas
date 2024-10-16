using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas
{
    public class BDConexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TIENDA_PELICULAS;Data Source=DESKTOP-J3T0LDQ\\SQLEXPRESS");
            conexion.Open();

            return conexion;
        }
    }
}
