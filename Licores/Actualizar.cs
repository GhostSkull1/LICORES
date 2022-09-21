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
using System.Xml.Linq;

namespace Licores
{
    public partial class Actualizar : Form
    {
        LogiProducto objeCN = new LogiProducto();
        public Actualizar()
        {
            InitializeComponent();
        }

        private void bactualizapro_Click(object sender, EventArgs e)
        {
            objeCN.Actualizar(textBoxproducto.Text, int.Parse(textBoxcantidad.Text), float.Parse(textBoxvalor.Text), int.Parse(textBoxcodigo.Text));
            MessageBox.Show("Se actualizo el producto");
            
            //this.Close();
        }

        private void Actualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
