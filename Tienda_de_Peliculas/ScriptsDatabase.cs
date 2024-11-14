using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
        public static string CargarPeliculas = "Peli.Inventario_CMB";
        public static string EditarInventario_CargarInformacion = "Peli.UPD_tbInventario_CargarInformacion";
        public static string EditarInventario = "Peli.UDP_tbInventario_Editar";
        #endregion

        #region Factura
        public static string InsertarFactura = "";
        #endregion

        #region Clientes
        public static string Clientes_CMB = "Gral.Clientes_CMB";
        #endregion

        #region Empleados
        public static string ListarEmpleados = "SELECT * FROM Gral.DatosGenerales_Empleado";
        public static string InsertarEmpleados = "Gral.UDP_tbDatosGenerales_Insertar";
        #endregion

        #region Paises
        public static string ListarPaises = "Gral.Paises_CMB";
        #endregion

        #region Departamentos
        #endregion

        #region Ciudades
        public static string ListarCiudades = "SELECT * FROM Gral.Listado_Ciudades";
        public static string Ciudades_CMB = "Gral.Ciudades_CMB";
        public static string InsertarCiudades = "Gral.UDP_tbCiudades_Insertar";
        public static string EditarCiudades_CargarInformacion = "Gral.UPD_tbCiudades_CargarInformacion";
        public static string EditarCiudades = "Gral.UPD_tbCiudades_Editar";
        public static string EliminarCiudades = "Gral.UPD_tbCiudades_Eliminar";
        #endregion

        #region Idiomas
        public static string ListarIdiomas = "Peli.Idiomas_CMB";
        #endregion

        #region Clasificaciones
        public static string ListarClasificaciones = "Peli.Clasificaciones_CMB";
        #endregion

        #region Reportes
        public static string VentasPorPeliculas = "Peli.REPORTE_VentasPorPeliculas";
        public static string VentasPorPeliculas_TOTAL = "Peli.REPORTE_VentasPorPeliculas_TOTAL";
        #endregion

        #region Formatos
        public static string ListarFormatos = "Peli.Formatos_CMB";
        #endregion

        #region Generos
        public static string ListarGeneros = "Peli.Generos_CMB";
        #endregion

        #region Estados
        public static string ListarEstados = "Peli.Estados_CMB";
        #region Login
        public static string IniciarSesión = "Acce.UDP_IniciarSesion";
        public static string DibujarPantallas = "Acce.UDP_DibujarMenuPorRol";
        #endregion
    }
}
