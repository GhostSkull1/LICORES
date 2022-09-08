using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBaseDatos;

namespace CapaLogica
{
    public class LogiProducto
    {
        private InfoProductos ObjeCD = new InfoProductos(); // crear objeto

        public void Crear(string producto, int cantidad, float valor, int codigo)
        {
            ObjeCD.CrearProducto(producto, cantidad, valor, codigo);
        }

        public DataTable View()  // cargar los datos en una tabla
        {
            DataTable tabla = new DataTable();
            tabla = ObjeCD.ReadAllProducts();
            return tabla;
        }

        public void Borrar(int codigo)
        {
            ObjeCD.BorrarProducto(codigo);  
        }

        public void Actualizar(string producto, int cantidad, float valor, int codigo)
        {
            ObjeCD.ActualizarProducto(producto, cantidad, valor, codigo);
        }
    }
}
