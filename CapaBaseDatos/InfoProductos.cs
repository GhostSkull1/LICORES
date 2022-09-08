using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaBaseDatos.Conexion;

namespace CapaBaseDatos
{
    public class InfoProductos
    {
        private Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader dataReader;
        DataTable tabla = new DataTable();

        public void CrearProducto(string producto, int cantidad, float valor, int codigo)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "INV_INSERTAR_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@producto", producto);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public DataTable ReadAllProducts()
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "INV_MOSTRAR_ALL_PRODUCTS";
            comando.CommandType = CommandType.StoredProcedure;
            dataReader = comando.ExecuteReader();
            tabla.Load(dataReader);

            conexion.CloseConnection();
            return tabla;
        }

        public void BorrarProducto(int codigo)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "INV_ELIMINAR_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void ActualizarProducto(string producto, int cantidad, float valor, int codigo)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "INV_ACTUALIZAR_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@producto", producto);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }




    }

    
    
}
