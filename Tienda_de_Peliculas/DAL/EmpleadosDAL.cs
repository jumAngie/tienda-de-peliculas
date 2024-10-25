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
    internal class EmpleadosDAL
    {
        public static string CantidadDeEmpleadosRegistrados()
        {
            string EmpleadosRegistrados = "0";
            var empleados = 0;

            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.ClientesRegistrados, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    empleados = (int)cmd.ExecuteScalar();

                    EmpleadosRegistrados = Convert.ToString(empleados);
                }

            }
            catch (Exception ex)
            {
                EmpleadosRegistrados = "Error: " + ex.Message;
                throw;
            }


            return EmpleadosRegistrados;
        }

        //LISTAR
        public static List<EmpleadosViewModel> ListarEmpleados()
        {
            List<EmpleadosViewModel> lista = new List<EmpleadosViewModel>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT * FROM Gral.DatosGenerales_Empleado";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    EmpleadosViewModel empleadosView = new EmpleadosViewModel();
                    empleadosView.NombreCompleto = reader.GetString(0);
                    empleadosView.DNI = reader.GetString(1);
                    empleadosView.Telefono = reader.GetString(2);
                    empleadosView.email = reader.GetString(3);
                    empleadosView.Pais_Descripcion = reader.GetString(4);
                    empleadosView.Dept_Descripcion = reader.GetString(5);
                    empleadosView.Ciud_Descripcion = reader.GetString(6);
                    empleadosView.Direccion = reader.GetString(7);
                    empleadosView.FechaNacimiento = reader.GetDateTime(8);
                    empleadosView.Sexo_Descripcion = reader.GetString(9);
                    empleadosView.Cate_Descripcion = reader.GetString(10);
                    empleadosView.usua_Usuario = reader.GetString(11);
                    empleadosView.Fecha_Creacion = reader.GetDateTime(12);


                    lista.Add(empleadosView);
                }

                conexion.Close();
                return lista;
            }


        }

        //INSERTAR
        public static string InsertarEmpleados(DatosGenerales DgEmpleados)
        {
            string Mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("Gral.UDP_tbDatosGenerales_Insertar", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    string fechaformateada = DgEmpleados.dato_FechaNacimiento.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@dato_NombreCompleto", DgEmpleados.dato_NombreCompleto);
                    cmd.Parameters.AddWithValue("@dato_DNI", DgEmpleados.dato_DNI);
                    cmd.Parameters.AddWithValue("@dato_Telefono", DgEmpleados.dato_Telefono);
                    cmd.Parameters.AddWithValue("@dato_email", DgEmpleados.dato_email);
                    cmd.Parameters.AddWithValue("@ciud_Id", DgEmpleados.ciud_Id);
                    cmd.Parameters.AddWithValue("@dato_Direccion", DgEmpleados.dato_Direccion);
                    cmd.Parameters.AddWithValue("@dato_FechaNacimiento", fechaformateada);
                    cmd.Parameters.AddWithValue("@sexo_Id", DgEmpleados.sexo_Id);
                    cmd.Parameters.AddWithValue("@cate_Id", DgEmpleados.cate_Id);
                    cmd.Parameters.AddWithValue("@usua_UsuarioCreacion", DgEmpleados.usua_UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@dato_FechaCreacion", DgEmpleados.dato_FechaCreacion);


                    Mensaje = (string)cmd.ExecuteScalar();
                }

            }
            catch (Exception ex)
            {
                Mensaje = "Error: " + ex.Message;
                throw;
            }



            return Mensaje;
        }
    }
}
