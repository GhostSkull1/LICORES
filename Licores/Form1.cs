using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Licores
{
    public partial class principal : Form
    {
        LogiProducto h = new LogiProducto();
        Int16 errorvalidacion = 0;

        LogiProducto objeCN = new LogiProducto();
        public principal()
        {
            InitializeComponent();
            datadatos.Refresh();
        }

        private void VALIDADOR()
        {
            if(teproducto.Text .Trim().Length <4)
            {
                errorvalidacion = 0;
                h.menaviso("INGRESE EL NOMBRE DEL PRODUCTO");
                teproducto.Focus();
                errorvalidacion++;
                return;
                
            }
            if(tecantidad.Text.Trim().Length <6)
            {
                h.menaviso("INGRESE LA CANTIDAD DEL PRODUCTO");
                tecantidad.Focus();
                errorvalidacion++;
                return;
            }
            if(tevalor.Text.Trim().Length <6)
            {
                h.menaviso("INGRESE EL VALOR DEL PRODUCTO");
                tevalor.Focus();
                errorvalidacion++;
                return;
            }
            if(tecodigo.Text.Trim().Length<3)
            {
                h.menaviso("INGRESE EL CODIGO DEL PRODUCTO");
                tecodigo.Focus();
                errorvalidacion++;
                return;
            }

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

            //VALIDADOR();
            //if(errorvalidacion == 0)

            borrarerror();

            if(validarcampos())
            { 
            objeCN.Crear(teproducto.Text, int.Parse(tecantidad.Text), float.Parse(tevalor.Text), int.Parse(tecodigo.Text));
            MessageBox.Show("Se guardo el producto");

            limpiar();
            Verproductos();
            }
            //Form formularioagregar = new agregarproductos();
            //datadatos.Refresh();
            //formularioagregar.Show();
        }

        private bool validarcampos()
        {
            bool ok = true;
            if(teproducto.Text == "")
            {
                ok = false;
                errorProvider1.SetError(teproducto, "INGRESE EL NOMBRE DEL PRODUCTO");
            }

            if (tecantidad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tecantidad, "INGRESE LA CANTIDAD DEL PRODUCTO");
            }

            if (tevalor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tevalor, "INGRESE EL VALOR DEL PRODUCTO");
            }

            if (tecodigo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tecodigo, "INGRESE EL CODIGO DEL PRODUCTO");
            }

            return ok;
        }

        private void borrarerror()
        {
            errorProvider1.SetError(teproducto, "");
            errorProvider1.SetError(tecantidad, "");
            errorProvider1.SetError(tevalor, "");
            errorProvider1.SetError(tecodigo, "");
        }

        private void datadatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = datadatos.CurrentCell.RowIndex;
            teproducto.Text = datadatos[0, fila].Value.ToString();
            tecantidad.Text = datadatos[1, fila].Value.ToString();
            tevalor.Text = datadatos[2, fila].Value.ToString();
            tecodigo.Text = datadatos[3, fila].Value.ToString();

        }

        private void principal_Load(object sender, EventArgs e)
        {
            dataventas.Refresh();
            datadatos.Refresh();
            tcantidad.Focus();
            tproducto.Enabled = false;
            tvalor.Enabled = false;
            ttotal.Enabled = false;
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
            if(validarcampos())
            { 
            objeCN.Actualizar(teproducto.Text, int.Parse(tecantidad.Text), float.Parse(tevalor.Text), int.Parse(tecodigo.Text));
            MessageBox.Show("Se actualizo el producto");
            limpiar();
            Verproductos();
            }

            //Form formularioactualizar = new Actualizar();
            //formularioactualizar.Show();
        }

        private void bmostrar_Click(object sender, EventArgs e)
        {
            LogiProducto objeto = new LogiProducto();
            datadatos.DataSource = objeto.View();
        }

        public void limpiar2()
        {
            tproducto.Text = "";
            tvalor.Text = "";
            tcantidad.Text = "";
            ttotal.Text = "";
            tpaga.Text = "";
        }

       

        private void bpagar_Click(object sender, EventArgs e)
        {
           if(ttotal.Text != "")
            {
                int n3 = 0;
                int n1, n2, r;
                n1 = Convert.ToInt32(tcantidad.Text);
                n2 = Convert.ToInt32(tvalor.Text);
                n3 = Convert.ToInt32(tpaga.Text);
                r = n1 * n2;
                n3 = n3 - r;
                //ttotal.Text = r.ToString();
                MessageBox.Show("EL CAMBIO ES: " + n3);
                limpiar2();
            }
           else
            {
                MessageBox.Show("INGRESE EL VALOR QUE PAGA EL CLIENTE");
            }
           
        }

        private void tebuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila1 = dataventas.CurrentCell.RowIndex;
            tproducto.Text = datadatos[0, fila1].Value.ToString();
            //tcantidad.Text = datadatos[1, fila1].Value.ToString();
            tvalor.Text = datadatos[2, fila1].Value.ToString();
            tcantidad.Focus();
        }

        private void btotal_Click(object sender, EventArgs e)
        {
            if(tcantidad.Text != "")
            {
                int n1, n2, n3, r;
                n1 = Convert.ToInt32(tcantidad.Text);
                n2 = Convert.ToInt32(tvalor.Text);
                //n3 = Convert.ToInt32(tpaga.Text);
                r = n1 * n2;
                //n3 = n3 - r;
                ttotal.Text = r.ToString();
                // MessageBox.Show("la devuelta es: " + n3);
            }
            else
            {
                MessageBox.Show("INGRESE LA CANTIDAD A VENDER");
            }
            
        }

        public void limpiar()
        {
            teproducto.Text = "";
            tecantidad.Text = "";
            tevalor.Text = "";
            tecodigo.Text = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void butactualizar_Click(object sender, EventArgs e)
        {
            LogiProducto objeto = new LogiProducto();
            dataventas.DataSource = objeto.View();
        }

        private void tecantidad_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if(int.TryParse(tecantidad.Text, out num))
            {
                errorProvider1.SetError(tecantidad, "INGRESE LA CANTIDAD EN NUMERO");
            }
            else
            {
                errorProvider1.SetError(tecantidad, "");
            }
        }

        private void tevalor_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (int.TryParse(tevalor.Text, out num))
            {
                errorProvider1.SetError(tevalor, "INGRESE EL VALOR EN NUMERO");
            }
            else
            {
                errorProvider1.SetError(tevalor, "");
            }
        }

        private void tecodigo_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (int.TryParse(tecodigo.Text, out num))
            {
                errorProvider1.SetError(tecodigo, "INGRESE EL CODIGO EN NUMERO");
            }
            else
            {
                errorProvider1.SetError(tecodigo, "");
            }
        }

        private void teproducto_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tecantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
