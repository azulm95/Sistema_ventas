using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_ventas.Clases;
using MySql.Data.MySqlClient;
namespace Sistema_ventas.formularios
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validaciones v = new Validaciones();
            Conexion c = new Conexion();
            MySqlCommand parametros = new MySqlCommand();

            if (v.ValidarTexto(gbpaciente) == 0) {
                c.Conectar();
               
                parametros.Parameters.AddWithValue("p_nombre",txtnombre.Text);
                parametros.Parameters.AddWithValue("p_apellido", txtapellido.Text);
                parametros.Parameters.AddWithValue("p_empresa", txtempresa.Text);
            
                parametros.Parameters.AddWithValue("p_ciudad", txtciudad.Text);
              
                parametros.Parameters.AddWithValue("p_telefono", txttelefono.Text);
                parametros.Parameters.AddWithValue("p_correo", txtcorreo.Text);
                

                if (c.TransaccionMysql("CrearProveedor", parametros.Parameters, CommandType.StoredProcedure)) {
                    frmComprasProveedores.nomp = txtnombre.Text;
                    this.Dispose();
                }
                
                c.Desconectar();

            }




        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar))||(char.IsControl(e.KeyChar)))
            {
                e.Handled = false;

            }
            else {

                e.Handled = true;
            }
        
        
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else {

                e.Handled = true;
            }




        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((char.IsLetter(e.KeyChar))|| (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void txtempresa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((char.IsLetterOrDigit(e.KeyChar)) || (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((char.IsLetterOrDigit(e.KeyChar)) || (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void txtciudad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((char.IsLetter(e.KeyChar)) || (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void txttipo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((char.IsLetter(e.KeyChar)) || (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((char.IsNumber(e.KeyChar)) || (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((char.IsLetterOrDigit(e.KeyChar)) || (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

    }
}
