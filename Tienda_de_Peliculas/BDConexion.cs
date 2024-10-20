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
            SqlConnection conexion = new SqlConnection("workstation id=TIENDA_PELICULAS.mssql.somee.com;packet size=4096;user id=jum4angie_SQLLogin_1;pwd=jddug3yr1p;data source=TIENDA_PELICULAS.mssql.somee.com;persist security info=False;initial catalog=TIENDA_PELICULAS;TrustServerCertificate=True");
            conexion.Open();

            return conexion;
        }
    }
}
