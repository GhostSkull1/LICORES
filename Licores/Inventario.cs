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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void bregresar_Click(object sender, EventArgs e)
        {
            Form formuprincipal = new principal();
            formuprincipal.Show();
        }
    }
}
