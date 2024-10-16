using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas.DAL
{
    public class DepartamentosDAL
    {
        public DataTable CargarDepartamentosPorPais(int pais_Id)
        {
            SqlConnection conexion = BDConexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("Gral.Departamentos_CMB", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pais_Id", pais_Id);


            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
