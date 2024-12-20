﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Peliculas.Clases;
using Tienda_de_Peliculas.View_Models;
using Tienda_de_Peliculas.Vistas;
using System.Security.Cryptography.X509Certificates;
using Tienda_de_Peliculas.Entities;

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
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.ClientesRegistrados, conexion);
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

        //LISTAR
        public static List<ClientesViewModel> ListarClientes()
        {
            List<ClientesViewModel> lista = new List<ClientesViewModel>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                conexion.Open();
                string query = ScriptsDatabase.ListarClientes;
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ClientesViewModel ClienteView = new ClientesViewModel();
                    ClienteView.NombreCompleto = reader.GetString(0);
                    ClienteView.DNI= reader.GetString(1);
                    ClienteView.Telefono = reader.GetString(2);
                    ClienteView.email = reader.GetString(3);
                    ClienteView.Pais_Descripcion = reader.GetString(4);
                    ClienteView.Dept_Descripcion = reader.GetString(5);
                    ClienteView.Ciud_Descripcion = reader.GetString(6);
                    ClienteView.Direccion = reader.GetString(7);
                    ClienteView.FechaNacimiento = reader.GetDateTime(8);
                    ClienteView.Sexo_Descripcion = reader.GetString(9);
                    ClienteView.Cate_Descripcion = reader.GetString(10);
                    ClienteView.usua_Usuario = reader.GetString(11);
                    ClienteView.Fecha_Creacion = reader.GetDateTime(12);


                    lista.Add(ClienteView);
                }

                conexion.Close();
                return lista;
            }

           
        }

        //INSERTAR
        public static string InsertarClientes(DatosGenerales DgClientes)
        {
            string Mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("Gral.UDP_tbDatosGenerales_Insertar", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    string fechaformateada = DgClientes.dato_FechaNacimiento.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@dato_NombreCompleto", DgClientes.dato_NombreCompleto);
                    cmd.Parameters.AddWithValue("@dato_DNI", DgClientes.dato_DNI);
                    cmd.Parameters.AddWithValue("@dato_Telefono", DgClientes.dato_Telefono);
                    cmd.Parameters.AddWithValue("@dato_email", DgClientes.dato_email);
                    cmd.Parameters.AddWithValue("@ciud_Id", DgClientes.ciud_Id);
                    cmd.Parameters.AddWithValue("@dato_Direccion", DgClientes.dato_Direccion);
                    cmd.Parameters.AddWithValue("@dato_FechaNacimiento", fechaformateada);
                    cmd.Parameters.AddWithValue("@sexo_Id", DgClientes.sexo_Id);
                    cmd.Parameters.AddWithValue("@cate_Id", DgClientes.cate_Id);
                    cmd.Parameters.AddWithValue("@usua_UsuarioCreacion", DgClientes.usua_UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@dato_FechaCreacion", DgClientes.dato_FechaCreacion);


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

        // COMBOBOX
        public DataTable CargarClientes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(ScriptsDatabase.Clientes_CMB, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;

        }

        public static DatosGenerales  Editar_CargarDatos(int clien_ID)
        {
            DatosGenerales clientes = null;
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.EditarClientes_CargarInformacion, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@dato_Id", clien_ID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clientes = new DatosGenerales
                            {
                                dato_NombreCompleto = reader.GetString(0),
                                dato_DNI = reader.GetString(1),
                                dato_Telefono = reader.GetString(2),
                                dato_email = reader.GetString(3),
                                ciud_Id = reader.GetInt32(4),
                                dato_Direccion = reader.GetString(5),
                                dato_FechaNacimiento = reader.GetDateTime(6),
                                sexo_Id = reader.GetInt32(7),
                                cate_Id = reader.GetInt32(8),
                                dept_Id = reader.GetInt32(9),
                                pais_Id = reader.GetInt32(10),
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la información de los clientes: " + ex.Message);
            }

            return clientes;
        }

        public static string EditarClientes(DatosGenerales clientes)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.EditarClientes, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@dato_NombreCompleto", clientes.dato_NombreCompleto);
                    cmd.Parameters.AddWithValue("@dato_DNI", clientes.dato_DNI);
                    cmd.Parameters.AddWithValue("@dato_Telefono", clientes.dato_Telefono);
                    cmd.Parameters.AddWithValue("@dato_email", clientes.dato_email);
                    cmd.Parameters.AddWithValue("@ciud_Id", clientes.ciud_Id);
                    cmd.Parameters.AddWithValue("@dato_Direccion", clientes.dato_Direccion);
                    cmd.Parameters.AddWithValue("@dato_FechaNacimiento", clientes.dato_FechaNacimiento);
                    cmd.Parameters.AddWithValue("@sexo_Id", clientes.sexo_Id);
                    cmd.Parameters.AddWithValue("@cate_Id", clientes.cate_Id);
                    cmd.Parameters.AddWithValue("@dept_Id", clientes.dept_Id);
                    cmd.Parameters.AddWithValue("@pais_Id", clientes.pais_Id);
                   

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
                         