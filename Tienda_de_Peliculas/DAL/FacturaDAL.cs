using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Peliculas.Clases;
using Tienda_de_Peliculas.View_Models;

namespace Tienda_de_Peliculas.DAL
{
    public class FacturaDAL
    {
        public static string CantidadVentasSemanaActual(DateTime fechaLunes, DateTime fechaDomingo)
        {
            string cantVentas = "0";
            int ventas = 0;

            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.VentasSemanales, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fechaLunes", fechaLunes);
                    cmd.Parameters.AddWithValue("@fechaDomingo", fechaDomingo);

                    ventas = (int)cmd.ExecuteScalar();

                    cantVentas = Convert.ToString(ventas);
                }

            }
            catch (Exception ex)
            {
                cantVentas = "Error: " + ex.Message;
                throw;
            }


            return cantVentas;
        }

        public static string CantidadAlquileresSemanaActual(DateTime fechaLunes, DateTime fechaDomingo)
        {
            string cantAlquileres = "0";
            int alquileres = 0;

            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.AlquileresSemanales, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fechaLunes", fechaLunes);
                    cmd.Parameters.AddWithValue("@fechaDomingo", fechaDomingo);

                    alquileres = (int)cmd.ExecuteScalar();

                    cantAlquileres = Convert.ToString(alquileres);
                }

            }
            catch (Exception ex)
            {
                cantAlquileres = "Error: " + ex.Message;
                throw;
            }


            return cantAlquileres;
        }

        //listar factura
        public static List<FacturaViewModel>listarfactura()
        {
            List<FacturaViewModel> lista =new List<FacturaViewModel>();

            using (SqlConnection conexion =BDConexion.ObtenerConexion())
            {
                conexion.Open();
                string query = "Select * Peli.listado_Facturas";
                SqlCommand comando = new SqlCommand (query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    FacturaViewModel facturaview = new FacturaViewModel ();
                    facturaview.fact_ID = reader.GetInt32(0);
                        facturaview.
f                }
                        

            }

        }
    }

}
