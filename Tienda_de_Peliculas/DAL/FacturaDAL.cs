
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Peliculas.Clases;
using Tienda_de_Peliculas.View_Models;
using Tienda_de_Peliculas.Entities;

namespace Tienda_de_Peliculas.DAL 
{
    public class FacturaDAL
    {
   
        #region Cantida de Venta
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
        #endregion

        #region Cantida de Alquiler
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
        #endregion

        #region listar factura
        public static List<FacturaViewModel>listarfactura()
        {
            List<FacturaViewModel> lista =new List<FacturaViewModel>();

            using (SqlConnection conexion =BDConexion.ObtenerConexion())
            {
                conexion.Open();
                string query = "Select * FROM Peli.Listado_Facturas";
                SqlCommand comando = new SqlCommand (query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    FacturaViewModel facturaview = new FacturaViewModel ();
                    facturaview.fact_ID = reader.GetInt32(0);
                    facturaview.meto_Descripcion = reader.GetString(1);
                    facturaview.dato_NombreCompleto = reader.GetString(2);
                    facturaview.fact_NumFactura= reader.GetString(3);
                    facturaview.fact_FechaFactura=reader.GetDateTime(4);
                    facturaview.tran_Descripcion= reader.GetString(5);
                    facturaview.fact_Impuesto=reader.GetDecimal(6);
                    facturaview.fact_Descuento=reader.GetDecimal(7);
                    facturaview.fact_Subtotal=reader.GetDecimal(8);
                    facturaview.inve_Titulo=reader.GetString(9);
                    facturaview.fact_fechaDev = reader.GetDateTime(10); 
                    facturaview.fact_Total = reader.GetDecimal(11);
                    
                    lista.Add(facturaview);

                };
                conexion.Close();     
                return lista;   

            }

        }
        #endregion

        #region insertar
        public static string InsertarFacturas(Facturas facturas)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("Peli.UDP_Peli.tbFacturas", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@meto_Id", facturas.meto_id);
                    cmd.Parameters.AddWithValue("@dato_Id", facturas.dato_id);
                    cmd.Parameters.AddWithValue("@fact_NumFactura", facturas.fact_NumFactura);
                    cmd.Parameters.AddWithValue("@fact_FechaFactura", facturas.fact_fechafactura);
                    cmd.Parameters.AddWithValue("@tran_Id", facturas.tran_id);
                    cmd.Parameters.AddWithValue("@fact_Subtotal", facturas.fact_subtotal);
                    cmd.Parameters.AddWithValue("@fact_Impuesto", facturas.fact_impuesto);
                    cmd.Parameters.AddWithValue("@fact_Descuento", facturas.fact_descuento);
                    cmd.Parameters.AddWithValue("@inve_Id", facturas.inve_id);
                    cmd.Parameters.AddWithValue("@fact_fechaDev", facturas.fact_fechadev);
                    cmd.Parameters.AddWithValue("@fact_Total", facturas.fact_total);
                    cmd.Parameters.AddWithValue("@usua_UsuarioCreacion", facturas.usua_UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@fact_FechaCreacion", facturas.fact_FechaCreacion);


                    mensaje = (string)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error: " + ex.Message;
            }

            return mensaje;
        }
        #endregion

        #region Cargar Datos de Factura para Editar
        public static Facturas Editar_CargarDatos(int fact_ID)
        {
            Facturas factura = null;
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("Peli.UPD_tbFacturas_CargarInformacion", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fact_ID", fact_ID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            factura = new Facturas
                            {
                                meto_id = reader.GetInt32(0),
                                dato_id = reader.GetInt32(1),
                                fact_NumFactura = reader.GetString(2),
                                fact_fechafactura = reader.GetDateTime(3),
                                tran_id = reader.GetInt32(4),
                                fact_subtotal = reader.GetDecimal(5),
                                fact_impuesto = reader.GetDecimal(6),
                                fact_descuento = reader.GetDecimal(7),
                                inve_id = reader.GetInt32(8),
                                fact_fechadev = reader.GetDateTime(9),
                                fact_total = reader.GetDecimal(10)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la información de la factura: " + ex.Message);
            }

            return factura;
        }
        #endregion

        #region Editar Factura
        public static string EditarFacturas(Facturas factura)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("Peli.UPD_tbFacturas_Editar", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fact_ID", factura.fact_id);
                    cmd.Parameters.AddWithValue("@meto_Id", factura.meto_id);
                    cmd.Parameters.AddWithValue("@dato_Id", factura.dato_id);
                    cmd.Parameters.AddWithValue("@fact_NumFactura", factura.fact_NumFactura);
                    cmd.Parameters.AddWithValue("@fact_FechaFactura", factura.fact_fechafactura);
                    cmd.Parameters.AddWithValue("@tran_Id", factura.tran_id);
                    cmd.Parameters.AddWithValue("@fact_Subtotal", factura.fact_subtotal);
                    cmd.Parameters.AddWithValue("@fact_Impuesto", factura.fact_impuesto);
                    cmd.Parameters.AddWithValue("@fact_Descuento", factura.fact_descuento);
                    cmd.Parameters.AddWithValue("@inve_Id", factura.inve_id);
                    cmd.Parameters.AddWithValue("@fact_fechaDev", factura.fact_fechadev);
                    cmd.Parameters.AddWithValue("@fact_Total", factura.fact_total);
                    cmd.Parameters.AddWithValue("@usua_UsuarioModificacion", factura.usua_UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@fact_FechaModificacion", factura.fact_FechaModificacion);

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
     #endregion

        #region Eliminar Factura
        public static string EliminarFacturas(Facturas factura)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConexion.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("Peli.UPD_tbFacturas_Eliminar", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fact_ID", factura.fact_id);
                    cmd.Parameters.AddWithValue("@usua_UsuarioModificacion", factura.usua_UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@fact_FechaModificacion", factura.fact_FechaModificacion);

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
        #endregion

        public class FacturaDal
        {
            public DataTable CargarFacturas()
            {
                DataTable dt = new DataTable();
                    using (SqlConnection conexion = BDConexion.ObtenerConexion())
                    {
                        conexion.Open();

                        using (SqlCommand cmd = new SqlCommand("Peli.CargarFacturas", conexion))
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
}
