using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Peliculas.Clases;

namespace Tienda_de_Peliculas.DAL
{
    public class ClientesDAL
    {
        public static string CantidadDeClientesRegistrdos()
        {
            string clientesRegistrados = "0";
            var clientes = 0;
            
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Gral.Datos_Generales_CantidadDeClientes", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    clientes = (int)cmd.ExecuteScalar();

                    clientesRegistrados = Convert.ToString(clientes);
                }

            }
            catch (Exception ex)
            {
                clientesRegistrados = "Error: " + ex.Message;
                throw;
            }


            return clientesRegistrados;
        }
    }
}
