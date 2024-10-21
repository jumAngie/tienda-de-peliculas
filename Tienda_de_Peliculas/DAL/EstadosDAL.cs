﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas.DAL
{
    public class EstadosDAL
    {
        public DataTable CargarEstados()
        {
            SqlConnection conexion = BDConexion.ObtenerConexion();
            SqlDataAdapter da = new SqlDataAdapter("Peli.Estados_CMB", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}