using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licores
{
    public partial class Eliminar : Form
    {
        LogiProducto objeCN = new LogiProducto();
        LogiProducto ver = new LogiProducto();

       
        public Eliminar()
        {
            InitializeComponent();
            
        }

        private void bborrar_Click(object sender, EventArgs e)
        {
            if(texeliminar.Text != "")
            { 
            objeCN.Borrar(int.Parse(texeliminar.Text));
            MessageBox.Show("Se borro el producto");
            
            ver.View();
            this.Close();
            }
            else
            {
                MessageBox.Show("INGRESE EL CODIGO DEL PRODUCTO A BORRAR");
            }
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            texeliminar.Focus();
        }
    }
}
