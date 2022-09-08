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
    public partial class principal : Form
    {
        LogiProducto objeCN = new LogiProducto();
        public principal()
        {
            InitializeComponent();
        }

        //metodo para llamar el datagrid

        private void Verproductos()
        {
            LogiProducto objeto = new LogiProducto();
            datadatos.DataSource = objeto.View();
        }

        private void Vercodigos()
        {
            LogiProducto objeto = new LogiProducto();
            dataventas.DataSource = objeto.View();
        }
        private void binventario_Click(object sender, EventArgs e)
        {
            Form formuinventario = new Inventario();
            formuinventario.Show();
            this.Hide();
        }

        private void tabprincipal_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bagregar_Click(object sender, EventArgs e)
        {
            Form formularioagregar = new agregarproductos();
            formularioagregar.Show();
        }

        private void datadatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e)
        {
            Verproductos();
            Vercodigos();

           
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            Form formularioeliminar = new Eliminar();
            formularioeliminar.Show();
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            Form formularioactualizar = new Actualizar();
            formularioactualizar.Show();
        }

        private void bmostrar_Click(object sender, EventArgs e)
        {
            LogiProducto objeto = new LogiProducto();
            datadatos.DataSource = objeto.View();
        }

        private void bpagar_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, r;
            n1 = Convert.ToInt32(tcantidad.Text);
            n2 = Convert.ToInt32(tvalor.Text);
            n3 = Convert.ToInt32(tpaga.Text);
            r = n1 * n2;
            n3 = n3 - r;
            ttotal.Text = r.ToString();
            MessageBox.Show("la devuelta es: " + n3);
        }
    }
}
