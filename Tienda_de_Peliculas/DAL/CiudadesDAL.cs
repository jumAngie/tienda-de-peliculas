using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Peliculas.View_Models;
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
                conexion.Open();
                string query = ScriptsDatabase.ListarCiudades;
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
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

        // Insertar
        public static string InsertarCiudades(Ciudades ciudades)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
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

        // Editar_CargarDatos
        public static Ciudades Editar_CargarDatos(int ciud_Id)
        {
            Ciudades ciudades = null;
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("Gral.UPD_tbCiudades_CargarInformacion", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ciud_Id", ciud_Id);
                   
                   using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ciudades = new Ciudades
                            {
                                pais_Id = reader.GetInt32(0),
                                dept_Id = reader.GetInt32(1),
                                ciud_Descripcion = reader.GetString(2)
                            };
                         }
                   }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al cargar la información de la ciudad: " + ex.Message);
            }

            return ciudades;
        }

        // Editar
        public static string EditarCiudades(Ciudades ciudades)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("Gral.UPD_tbCiudades_Editar", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ciud_Id", ciudades.ciud_Id);
                    cmd.Parameters.AddWithValue("@ciud_Descripcion", ciudades.ciud_Descripcion);
                    cmd.Parameters.AddWithValue("@dept_Id", ciudades.dept_Id);
                    cmd.Parameters.AddWithValue("@usua_UsuarioModificacion", ciudades.usua_UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@ciud_FechaModificacion", ciudades.ciud_FechaModificacion);

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

        // Eliminar
        public static string EliminarCiudades(Ciudades ciudades)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("Gral.UPD_tbCiudades_Eliminar", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ciud_Id", ciudades.ciud_Id);
                    cmd.Parameters.AddWithValue("@usua_UsuarioModificacion", ciudades.usua_UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@ciud_FechaModificacion", ciudades.ciud_FechaModificacion);

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

        public DataTable CargarCiudadesPorDepto(int dept_Id)
        {
            DataTable dt = new DataTable();
            
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("Gral.Ciudades_CMB", conexion))
                {
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dept_Id", dept_Id);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt); 
                }
            }

            return dt;  
        }
    }
}
