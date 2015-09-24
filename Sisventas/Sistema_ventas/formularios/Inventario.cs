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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

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
        private void Inventario_Load(object sender, EventArgs e)
        {
            lblnombre.Text = nombre;
            lblrol.Text = rol;
            LLenarMarca();
            LLenarClasificacion();
        
        
       
        }

        public void LLenarMarca() {
            Conexion con = new Conexion();
            DataTable dt = new DataTable();
            String sentencia = "SELECT id_proveedor as id, empresa FROM tbl_proveedor;";
            con.Conectar();
            dt = con.ConsultaMySQL(sentencia, null);
            if (dt != null)
            {
                cbxmarca.DataSource = dt;
                cbxmarca.ValueMember = "id";
                cbxmarca.DisplayMember = "empresa";
            }
            con.Desconectar();
            dt = null;
            con = null;
       }
        public void LLenarClasificacion()
        {
            Conexion con = new Conexion();
            DataTable dt = new DataTable();
            String sentencia = "SELECT id, nombre FROM tbl_clasificacion;";
            con.Conectar();
            dt = con.ConsultaMySQL(sentencia, null);
            if (dt != null)
            {
                cbxclasificacion.DataSource = dt;
                cbxclasificacion.ValueMember = "id";
                cbxclasificacion.DisplayMember = "nombre";

            }
            con.Desconectar();
            dt = null;
            con = null;


        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            Validaciones v = new Validaciones();
            if (v.ValidarTexto(gproductos)==0) {
                Productos p = new Productos();
            MessageBox.Show(p.AgregarProducto(txtnombre.Text, txtcodigo.Text, cbxmarca.SelectedValue.ToString(), txtdescripcion.Text, cbxclasificacion.SelectedValue.ToString(), txtprecio.Text,dtfecha_ven.Value));
            v.LimpiarTexto(gproductos);
            v = null;
            p = null;

            
            }




        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if(txtproducto.Text != String.Empty){
            
                 Conexion canal = new Conexion();
           canal.Conectar();
            DataTable tb = new DataTable();
            MySqlCommand parametro =  new MySqlCommand();
            parametro.Parameters.AddWithValue("@parametro",txtproducto.Text+"%");
            String sentencia = "SELECT tbl_producto.codigo, tbl_producto.nombre,tbl_producto.fecha_vencimiento,tbl_producto.descripcion,tbl_producto.precio,tbl_proveedor.empresa as marca,tbl_clasificacion.nombre as clasificacion FROM tbl_producto inner join tbl_proveedor on tbl_producto.marca=tbl_proveedor.id_proveedor inner join tbl_clasificacion on tbl_producto.id_clasificacion=tbl_clasificacion.id WHERE tbl_producto.nombre like @parametro ;";
            tb = canal.ConsultaMySQL(sentencia,parametro.Parameters);
            if (tb != null)
            {
                dataGridView1.DataSource = tb;
            }
            else {

                MessageBox.Show("debe registrar productos.");
            }

            canal.Desconectar();
            canal = null;
          

            }





        }
    
    
    
    }
}
