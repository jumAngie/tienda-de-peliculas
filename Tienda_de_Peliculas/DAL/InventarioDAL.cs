﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Peliculas.Clases;
using Tienda_de_Peliculas.View_Models;
using Tienda_de_Peliculas.Vistas;

namespace Tienda_de_Peliculas.DAL
{
    public class InventarioDAL
    {
        // Listar
        public static List<InventarioViewModel> ListarInventario()
        {
            List<InventarioViewModel> lista = new List<InventarioViewModel>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {

                conexion.Open();
                string query = ScriptsDatabase.ListarInventario;
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    InventarioViewModel inventarioView = new InventarioViewModel();
                    inventarioView.inve_Id = reader.GetInt32(0);
                    inventarioView.inve_Titulo = reader.GetString(1);
                    inventarioView.inve_Anio = reader.GetString(2);
                    inventarioView.gene_Descripcion = reader.GetString(3);
                    inventarioView.inve_Duracion = reader.GetInt32(4);
                    inventarioView.form_Descripcion = reader.GetString(5);
                    inventarioView.esta_Descripcion = reader.GetString(6);
                    inventarioView.inve_Descripcion = reader.GetString(7);
                    inventarioView.idio_Descripcion = reader.GetString(8);
                    inventarioView.inve_Cantidad = reader.GetInt32(9);
                    inventarioView.inve_Precio = reader.GetDecimal(10);
                    inventarioView.clas_Descripcion = reader.GetString(11);
                   // inventarioView.usua_UsuarioCreacion = reader.GetString(12);
                   //inventarioView.usua_UsuarioModificacion = reader.GetString(13);
                    lista.Add(inventarioView);
                }

                conexion.Close();
                return lista;
            }

        }

        // Inserta
        public static string InsertarInventario(Inventario inve)
        {
            string mensaje = "";
            try
            {
                using(SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.InsertarInventario, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@inve_Titulo", inve.inve_Titulo);
                    cmd.Parameters.AddWithValue("@inve_Anio", inve.inve_Anio);
                    cmd.Parameters.AddWithValue("@gene_Id", inve.gene_Id);
                    cmd.Parameters.AddWithValue("@inve_Duracion", inve.inve_Duracion);
                    cmd.Parameters.AddWithValue("@form_Id", inve.form_Id);
                    cmd.Parameters.AddWithValue("@esta_Id", inve.esta_Id);
                    cmd.Parameters.AddWithValue("@inve_Descripcion", inve.inve_Descripcion);
                    cmd.Parameters.AddWithValue("@idio_Id", inve.idio_Id);
                    cmd.Parameters.AddWithValue("@inve_Cantidad", inve.inve_Cantidad);
                    cmd.Parameters.AddWithValue("@inve_Precio", inve.inve_Precio);
                    cmd.Parameters.AddWithValue("@clas_Id", inve.clas_Id);
                    cmd.Parameters.AddWithValue("@usua_UsuarioCreacion", inve.usua_UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@inve_FechaCreacion", inve.inve_FechaCreacion);

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
        
        // Editar cargar datos
        public static Inventario Editar_CargarDatos(int inve_Id)
        {
            Inventario inve = null;
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.EditarInventario_CargarInformacion, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@inve_Id", inve_Id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            inve = new Inventario
                            {
                                inve_Id = reader.GetInt32(0),
                                inve_Titulo = reader.GetString(1),
                                inve_Anio = reader.GetString(2),
                                inve_Duracion = reader.GetInt32(3),
                                form_Id = reader.GetInt32(4),
                                esta_Id = reader.GetInt32(5),
                                gene_Id   = reader.GetInt32(6),
                                inve_Descripcion = reader.GetString(7),
                                idio_Id = reader.GetInt32(8),
                                inve_Cantidad = reader.GetInt32(9),
                                inve_Precio = reader.GetDecimal(10),
                                clas_Id = reader.GetInt32(11),
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la información de la ciudad: " + ex.Message);
            }

            return inve;
        }

        // Editar
        public static string EditarInventario(Inventario inve)
        {
            string mensaje = "";
            try
            {  
                using(SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.EditarInventario, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@inve_Id", inve.inve_Id);
                    cmd.Parameters.AddWithValue("@inve_Titulo", inve.inve_Titulo);
                    cmd.Parameters.AddWithValue("@inve_Anio", inve.inve_Anio);
                    cmd.Parameters.AddWithValue("@gene_Id", inve.gene_Id);
                    cmd.Parameters.AddWithValue("@inve_Duracion", inve.inve_Duracion);
                    cmd.Parameters.AddWithValue("@form_Id", inve.form_Id);
                    cmd.Parameters.AddWithValue("@esta_Id", inve.esta_Id);
                    cmd.Parameters.AddWithValue("@inve_Descripcion", inve.inve_Descripcion);
                    cmd.Parameters.AddWithValue("@idio_Id", inve.idio_Id);
                    cmd.Parameters.AddWithValue("@inve_Cantidad", inve.inve_Cantidad);
                    cmd.Parameters.AddWithValue("@inve_Precio", inve.inve_Precio);
                    cmd.Parameters.AddWithValue("@clas_Id", inve.clas_Id);
                    cmd.Parameters.AddWithValue("@usua_UsuarioModificacion", inve.usua_UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@inve_FechaModificacion", inve.inve_FechaModificacion);

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

        // COMBOBOX
        public DataTable CargarPeliculas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(ScriptsDatabase.CargarPeliculas, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;

        }
    }
}
