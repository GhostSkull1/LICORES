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
    public partial class agregarproductos : Form
    {
        LogiProducto objeCN = new LogiProducto();
        public agregarproductos()
        {
            InitializeComponent();
        }

        private void buttguardar_Click(object sender, EventArgs e)
        {
            objeCN.Crear(texproducto.Text, int.Parse(texcantidad.Text), float.Parse(texvalor.Text), int.Parse(texasignarcodigo.Text));
            MessageBox.Show("Se guardo el producto");
            this.Close();

        }

       
    }
}
