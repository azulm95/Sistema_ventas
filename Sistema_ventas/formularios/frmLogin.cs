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
using Sistema_ventas.formularios;
using MySql.Data.MySqlClient;
namespace Sistema_ventas
{
    public partial class Form1 : Form{
        MenuPrincipal menu = new MenuPrincipal();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e){
        Conexion canal = new Conexion();
        Validaciones validar = new Validaciones();
        try { 
            if (validar.ValidarTexto(gblogin) == 0){
            canal.Conectar();
            DataTable tb = new DataTable();
            MySqlCommand parametro =  new MySqlCommand();
            parametro.Parameters.AddWithValue("@nombre", txtnombre.Text);
            parametro.Parameters.AddWithValue("@clave",txtclave.Text);
            String sentencia = "SELECT *  FROM tbl_usuarios WHERE nombre=@nombre AND clave=@clave;";
            tb = canal.ConsultaMySQL(sentencia,parametro.Parameters,CommandType.Text);
             
        

            if (tb != null)
            {
                canal.Desconectar();
                this.Hide();
                menu.setNombre(tb.Rows[0][1].ToString());
                menu.setRol(tb.Rows[0][3].ToString());
                

                        menu.ShowDialog();
            }
            else {
                MessageBox.Show("Credenciales incorrectos");
                txtnombre.Text = String.Empty;
                txtclave.Text = String.Empty;
                canal.Desconectar();
            }




            
        }
        else {
            MessageBox.Show("Debe llenar todos los campos!");
        
        }
        }
        catch (Exception ecep) { MessageBox.Show(ecep.Message); canal.Desconectar(); }
           




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gblogin_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

   
    
    
    
    
    
    }
}
