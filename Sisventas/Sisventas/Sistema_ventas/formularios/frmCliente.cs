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
    public partial class frmClientes : Form
    {
        public frmClientes()
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
                parametros.Parameters.AddWithValue("@nombre",txtnombre.Text);
                parametros.Parameters.AddWithValue("@apellido", txtapellido.Text);
                parametros.Parameters.AddWithValue("@empresa", txtempresa.Text);
                parametros.Parameters.AddWithValue("@direccion", txtdireccion.Text);
                parametros.Parameters.AddWithValue("@ciudad", txtciudad.Text);
                parametros.Parameters.AddWithValue("@tipo", txttipo.Text);
                parametros.Parameters.AddWithValue("@telefono", txttelefono.Text);
                parametros.Parameters.AddWithValue("@correo", txtcorreo.Text);
                parametros.Parameters.AddWithValue("@cedula", txtcedula.Text);

                if (c.TransaccionMysql("Insertar_Cliente", parametros.Parameters, CommandType.StoredProcedure)) { 
            
                
                }
                
                c.Desconectar();

            }




        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;

            }
            else {

                e.Handled = true;
            }
        
        
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else {

                e.Handled = true;
            }




        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
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

            if (char.IsLetterOrDigit(e.KeyChar))
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

            if (char.IsLetterOrDigit(e.KeyChar))
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

            if (char.IsLetter(e.KeyChar))
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

            if (char.IsLetter(e.KeyChar))
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

            if (char.IsNumber(e.KeyChar))
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

            if (char.IsLetterOrDigit(e.KeyChar))
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
