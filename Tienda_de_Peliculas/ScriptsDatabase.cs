using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas
{
    public class ScriptsDatabase
    {
        // acá se colocan los nombres de los procedimientos almacenados que estamos
        // usando para evitar colocarlos directamene al momento de pedir la consulta en el código.

        #region Dashboard
        public static string ClientesRegistrados = "Gral.Datos_Generales_CantidadDeClientes";
        public static string VentasSemanales = "Peli.Datos_Generales_VentasSemanales";
        public static string AlquileresSemanales = "Peli.Datos_Generales_AlquileresSemanales";
        #endregion

        #region Inventario
        public static string ListarInventario = "SELECT * FROM Peli.Listado_Inventario";
        public static string InsertarInventario = "Peli.UPD_tbInventario_Insertar";
        #endregion

        #region Factura
        #endregion

        #region Datos Generales
        #endregion

        #region Paises
        public static string ListarPaises = "Gral.Paises_CMB";
        #endregion

        #region Departamentos
        #endregion

        #region Ciudades
        public static string ListarCiudades = "SELECT * FROM Gral.Listado_Ciudades";
        #endregion

        #region Idiomas
        #endregion

        #region Clasificaciones
        public static string ListarClasificaciones = "Peli.Clasificaciones_CMB";
        #endregion
    }
}
