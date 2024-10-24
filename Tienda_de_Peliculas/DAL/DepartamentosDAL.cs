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
            DataTable dt = new DataTable();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("Gral.Departamentos_CMB", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pais_Id", pais_Id);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);  
                }
            }

            return dt;
        }
    }
}
