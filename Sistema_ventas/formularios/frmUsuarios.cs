using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema_ventas.Clases;

namespace Sistema_ventas.formularios
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if ((txtnombre.Text != null)&&(txtclave.Text !=null)&& (txtid.Text != null)) {
                MySqlCommand parametros = new MySqlCommand();
                Conexion canal = new Conexion();
                parametros.Parameters.AddWithValue("p_op", 1);
                parametros.Parameters.AddWithValue("p_id",txtid);
                parametros.Parameters.AddWithValue("p_nombre",txtnombre.Text);
                parametros.Parameters.AddWithValue("p_clave", txtclave.Text);
                parametros.Parameters.AddWithValue("p_rol", txtrol.SelectedText);
                canal.Conectar();
                if (canal.TransaccionMysql("Crear_Usuario", parametros.Parameters, CommandType.StoredProcedure)) {

                    MessageBox.Show("Usuario creado con exito");
                    this.Dispose();
                }
                
                canal.Desconectar();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtnombre.Text != null) && (txtclave.Text != null) && (txtid.Text != null))
            {
                MySqlCommand parametros = new MySqlCommand();
                Conexion canal = new Conexion();
                parametros.Parameters.AddWithValue("p_op", 2);
                parametros.Parameters.AddWithValue("p_id", txtid);
                parametros.Parameters.AddWithValue("p_nombre", txtnombre.Text);
                parametros.Parameters.AddWithValue("p_clave", txtclave.Text);
                parametros.Parameters.AddWithValue("p_rol", txtrol.SelectedText);
                canal.Conectar();
                if (canal.TransaccionMysql("Crear_Usuario", parametros.Parameters, CommandType.StoredProcedure))
                {

                    MessageBox.Show("Usuario actualizado con exito");
                    this.Dispose();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text != null)
            {
                MySqlCommand parametros = new MySqlCommand();
                Conexion canal = new Conexion();
                parametros.Parameters.AddWithValue("p_op", 3);
                parametros.Parameters.AddWithValue("p_id", txtid);
               
                canal.Conectar();
                if (canal.TransaccionMysql("Crear_Usuario", parametros.Parameters, CommandType.StoredProcedure))
                {

                    MessageBox.Show("Usuario Eliminado con exito");
                    this.Dispose();
                }

            }
        }
    }
