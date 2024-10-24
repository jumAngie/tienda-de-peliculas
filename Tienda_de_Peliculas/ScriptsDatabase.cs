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

        #region Inventario
        public static string ListarInventario = "SELECT * FROM Peli.Listado_Inventario";
        #endregion

        #region Factura
        #endregion

        #region Datos Generales
        #endregion

        #region Paises
        #endregion

        #region Departamentos
        #endregion

        #region Ciudades
        #endregion

        #region Idiomas
        #endregion
    }
}
