using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Peliculas.Clases;
using Tienda_de_Peliculas.View_Models;

namespace Tienda_de_Peliculas.DAL
{
    public class ReportesDAL
    {
        public List<ReporteViewModel> VentasPorPeliculas(int inve_Id, DateTime rangoInicio, DateTime rangoFin)
        {
            List<ReporteViewModel> lista = new List<ReporteViewModel>();
            string rgI = rangoInicio.ToString("yyyy-MM-dd");
            string rgF = rangoFin.ToString("yyyy-MM-dd");

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(ScriptsDatabase.VentasPorPeliculas, conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@inve_Id", inve_Id);
                cmd.Parameters.AddWithValue("@rangoInicio", rgI);
                cmd.Parameters.AddWithValue("@rangoFin", rgF);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        ReporteViewModel factura = new ReporteViewModel
                        {
                            inve_Id = reader.GetInt32(0),
                            fact_NumFactura = reader.GetString(1),
                            inve_Titulo = reader.GetString(2),
                            inve_Total = reader.GetDecimal(3)

                        };

                        lista.Add(factura);
                    }
                }
            }

            return lista;
        }

        public decimal VentasPorPelicula_TOTAL(int inve_Id, DateTime rangoInicio, DateTime rangoFin)
        {
            decimal TOTAL = 0;
            string rgI = rangoInicio.ToString("yyyy-MM-dd");
            string rgF = rangoFin.ToString("yyyy-MM-dd");

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(ScriptsDatabase.VentasPorPeliculas_TOTAL, conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@inve_Id", inve_Id);
                cmd.Parameters.AddWithValue("@rangoInicio", rgI);
                cmd.Parameters.AddWithValue("@rangoFin", rgF);

                TOTAL = (decimal)cmd.ExecuteScalar();
            }

                return TOTAL;
        }
    }
}
