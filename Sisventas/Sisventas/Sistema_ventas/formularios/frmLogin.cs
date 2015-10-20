﻿using System;
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
    public partial class frmLogin: Form{
        MenuPrincipal menu = new MenuPrincipal();
        
        public frmLogin()
        {
            InitializeComponent();
        }


        public static string Encriptar(this string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
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
            parametro.Parameters.AddWithValue("@clave",Encriptar(txtclave.Text));
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
        catch (Exception) { canal.Desconectar(); }
           




        }

    
   
    
    
    
    
    
    }
}
