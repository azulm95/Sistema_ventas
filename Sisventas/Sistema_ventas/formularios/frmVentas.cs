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
    public partial class frmVentas : Form
    {
        private String nombre;
        private String rol;
        public void setNombre(String n)
        {
            this.nombre = n;
        }
        public void setRol(String r)
        {
            this.rol = r;
        }


        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e){




        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtproducto_KeyPress(object sender, KeyPressEventArgs e){
            DataTable dt = new DataTable();
            MySqlCommand parametros = new MySqlCommand();
            Conexion canal = new Conexion();
            parametros.Parameters.AddWithValue("@parametro", txtproducto.Text);
           
            String sentencia = "SELECT p.codigo,p.nombre,p.marca,p.fecha_vencimiento,p.descripcion,p.precio i.existencia FROM tbl_inventario as i INNER JOIN tbl_producto as p ON tbl_inventario.id_producto = tbl_producto.codigo WHERE  "; 
            canal.Conectar();




            dt = canal.ConsultaMySQL(sentencia,parametros.Parameters);






        }
    }
}
