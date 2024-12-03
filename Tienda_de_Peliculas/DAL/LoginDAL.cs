using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections;
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
    public class LoginDAL
    {
        public DatosUsuarioViewModel AutenticarUsuario(string Usuario, string Contrasenia)
        {
            byte[] contraseniaEncriptada = Encriptacion.Encrip(Contrasenia);

            DatosUsuarioViewModel usuarioAutenticado = null;
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = ScriptsDatabase.IniciarSesión;
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@usua_Usuario", Usuario);
                    comando.Parameters.AddWithValue("@usua_Contrasenia", contraseniaEncriptada);

                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioAutenticado = new DatosUsuarioViewModel
                            {
                                usua_Id = reader.GetInt32(reader.GetOrdinal("usua_Id")),
                                usua_Usuario = reader.GetString(reader.GetOrdinal("usua_Usuario")),
                                dato_Id = reader.GetInt32(reader.GetOrdinal("dato_Id")),
                                dato_NombreCompleto = reader.GetString(reader.GetOrdinal("dato_NombreCompleto")),
                                dato_email = reader.GetString(reader.GetOrdinal("dato_email")),
                                role_Descripcion = reader.GetString(reader.GetOrdinal("role_Descripcion")),
                                role_Id = reader.GetInt32(reader.GetOrdinal("role_Id")),
                                sexo_Id = reader.GetInt32(reader.GetOrdinal("sexo_Id"))
                            };
                        }
                    }
                }
            }

            return usuarioAutenticado;
        }

        public List<PantallasViewModel> ObtenerPantallasPermitidas(int roleId)
        {
            List<PantallasViewModel> pantallas = new List<PantallasViewModel>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = ScriptsDatabase.DibujarPantallas;
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@role_Id", roleId);
                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PantallasViewModel pantalla = new PantallasViewModel
                            {
                                pant_ID = reader.GetInt32(reader.GetOrdinal("pant_ID")),
                                pant_NombrePantalla = reader.GetString(reader.GetOrdinal("pant_NombrePantalla")),
                                pant_NombreBoton = reader.GetString(reader.GetOrdinal("pant_NombreBoton")),
                                pant_RutaImagen = reader.GetString(reader.GetOrdinal("pant_RutaImagen")),
                                PosicionY = reader.GetInt32(reader.GetOrdinal("PosicionY"))
                            };
                            pantallas.Add(pantalla);
                        }
                    }
                }
            }

            return pantallas;
        }

    }
}
