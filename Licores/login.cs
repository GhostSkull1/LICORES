using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaBaseDatos;
using System.Data.SqlClient;

namespace Licores
{
    public partial class login : Form
    {
        //CLASELOGIN objeadmin = new CLASELOGIN();
        public login()
        {
            InitializeComponent();
        }


        private void buentrar_Click(object sender, EventArgs e)
        {
            if(texusuario.Text.Trim().Length < 5)
            {
                MessageBox.Show("INGRESAR NOMBRE DE USUARIO!","ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                texusuario.Focus();
                return;
            }

            if(texclave.Text.Trim().Length < 5)
            {
                MessageBox.Show("INGRESAR LA CLAVE DEL USUARIO!", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                texclave.Focus();
                return;
            }

            logueo();
            this.Hide();
            //SqlConnection.ChangePassword(texclave.Text,texusuario.Text);
            //Conexion.ReferenceEquals(texusuario, texclave);
            //string consulta = "select * from USUARIO where usuario='" + texusuario.Text + "' and contraseña='" + texclave.Text + "'";
            //SqlCommand comando = new SqlCommand(consulta);
            //SqlDataAdapter lector;
            //lector = comando.ExecuteReader()
        }

        private void logueo()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F6IB95O;Initial Catalog=ProductosLicolera;Integrated Security=True");
            cn.Open();
            SqlCommand cm = new SqlCommand("select USUARIO,CLAVE from usuario where USUARIO='" + texusuario.Text + "' and CLAVE='" + texclave.Text + "'", cn);
            SqlDataReader dr = cm.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("BIENVENIDO", "Sistema");
                principal PRIN = new principal();
                PRIN.ShowDialog();
            }
            else
                MessageBox.Show("ERROR DE CREDENCIALES", "Sistema");
        }

        private void bucancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
