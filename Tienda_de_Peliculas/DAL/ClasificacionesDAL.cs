using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas.DAL
{
    public class ClasificacionesDAL
    {
        public DataTable CargarClasificaciones()
        {
            SqlConnection conexion = BDConexion.ObtenerConexion();
            SqlDataAdapter da = new SqlDataAdapter("Peli.Clasificaciones_CMB", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
