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
            // local (angie): Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TIENDA_PELICULAS;Data Source=DESKTOP-J3T0LDQ\\SQLEXPRESS
            // nube: workstation id=TIENDA_PELICULAS.mssql.somee.com;packet size=4096;user id=jum4angie_SQLLogin_1;pwd=jddug3yr1p;data source=TIENDA_PELICULAS.mssql.somee.com;persist security info=False;initial catalog=TIENDA_PELICULAS;TrustServerCertificate=True
            SqlConnection conexion = new SqlConnection(" workstation id=TIENDA_PELICULAS.mssql.somee.com;packet size=4096;user id=jum4angie_SQLLogin_1;pwd=jddug3yr1p;data source=TIENDA_PELICULAS.mssql.somee.com;persist security info=False;initial catalog=TIENDA_PELICULAS;TrustServerCertificate=True");
            conexion.Open();

            return conexion;
        }
    }
}
