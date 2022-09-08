using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBaseDatos
{
    public class Conexion
    {
       

        private SqlConnection conexion = new SqlConnection("server=DESKTOP-F6IB95O; database=ProductosLicolera; integrated security = true");

        public SqlConnection OpenConnection()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection CloseConnection()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }

}
