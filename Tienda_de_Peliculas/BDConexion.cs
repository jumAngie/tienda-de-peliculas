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

        // Conexiones para la base

        // otros
        //private static string connString = "Password=acampos;Persist Security Info=True;User ID=sa;Initial Catalog=TIENDA_PELICULAS;Data Source=COMPUDARIO\\SQLEXPRESS";

        // local (angie casita):
        //  private static string connString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TIENDA_PELICULAS;Data Source=DESKTOP-J3T0LDQ\\SQLEXPRESS";

        // local (carlos):
        //  private static string connString = "Password=2005;Persist Security Info=True;User ID=Carlos;Initial Catalog=TIENDA_PELICULAS;Data Source=DESKTOP-RI35QNU\\SQLEXPRESS";

        // local (cindy): aun no hay vuelva otro día

        // nube:
        private static string connString = "workstation id=TIENDA_PELICULAS.mssql.somee.com;packet size=4096;user id=jum4angie_SQLLogin_1;pwd=jddug3yr1p;data source=TIENDA_PELICULAS.mssql.somee.com;persist security info=False;initial catalog=TIENDA_PELICULAS;TrustServerCertificate=True";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(connString);

            return conexion;
        }
    }
}
