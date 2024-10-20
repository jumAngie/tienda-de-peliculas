using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                string query = "SELECT * FROM Peli.Listado_Inventario";
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
                    inventarioView.usua_UsuarioCreacion = reader.GetString(12);
                    lista.Add(inventarioView);
                }

                conexion.Close();
                return lista;
            }

        }
    }
}
