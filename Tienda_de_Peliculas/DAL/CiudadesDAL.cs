using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Peliculas.Vistas;

namespace Tienda_de_Peliculas.Clases
{
    public class CiudadesDAL
    {
        // Listar
        public static List<CiudadViewModel> ListarCiudades()
        {
            List<CiudadViewModel> lista = new List<CiudadViewModel>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Gral.Listado_Ciudades";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read()) {
                    CiudadViewModel ciudadView = new CiudadViewModel();
                    ciudadView.CiudadID = reader.GetInt32(0);
                    ciudadView.Pais = reader.GetString(1);
                    ciudadView.Departamento = reader.GetString(2);
                    ciudadView.Ciudad = reader.GetString(3);
                    ciudadView.UsuarioCreador = reader.GetString(4);
                    lista.Add(ciudadView);
                }

                conexion.Close();
                return lista;
            }

        }

        public static string InsertarCiudades(Ciudades ciudades)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Gral.UDP_tbCiudades_Insertar", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ciud_Descripcion",        ciudades.ciud_Descripcion);
                    cmd.Parameters.AddWithValue("@dept_Id",                 ciudades.dept_Id);
                    cmd.Parameters.AddWithValue("@usua_UsuarioCreacion",    ciudades.usua_UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@ciud_FechaCreacion",      ciudades.ciud_FechaCreacion);

                    mensaje = (string)cmd.ExecuteScalar();
                }
               
            }
            catch (Exception ex)
            {
                mensaje = "Error: " + ex.Message;   
                throw;
            }
            
            return mensaje;


        }
    }
}
