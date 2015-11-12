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
using System.Net.Mail;

namespace Sistema_ventas.formularios
{
    public partial class frmComprasProveedores : Form
    {
        public static String nomp;
        public static String nompro;
        public static DataTable dtcompra;
        private String nombre;
        private String rol;
        public static String id_proveedor;
        public static String usuario;
        public static String id_producto;
        public static String cantidad;
        public static String costo;
        MySqlCommand paramtros = new MySqlCommand;







        public void setNombre(String n)
        {
            this.nombre = n;
        }
        public void setRol(String r)
        {
            this.rol = r;
        }

        public frmComprasProveedores()
        {
            InitializeComponent();
        }

        private void btnprove_Click(object sender, EventArgs e)
        {
           
            frmProveedor p = new frmProveedor();
            p.ShowDialog();
            lblnomprove.Text = nomp;

        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
           


            Conexion c = new Conexion();
            c.Conectar();
            frmProductos p = new frmProductos();
            p.origen = 2;
            p.DtProductos = c.ConsultaMySQL("ColsultarProducto", null, CommandType.StoredProcedure);
            c.Desconectar();
            p.ShowDialog();
            lblproducto.Text = nompro;

        }



        
       





        private void btnpedido_Click(object sender, EventArgs e)
        {
            try {

                if (ncantidad.Value != 0)
                {
                    cantidad = ncantidad.Value.ToString();

                    paramtros.Parameters.AddWithValue("p_proveedor", id_proveedor);
                    paramtros.Parameters.AddWithValue("p_usuario", usuario);
                    paramtros.Parameters.AddWithValue("p_producto", id_proveedor);
                    paramtros.Parameters.AddWithValue("p_cantidad", cantidad);
                    paramtros.Parameters.AddWithValue("p_costo", costo);
                    Conexion c = new Conexion();
                    c.Conectar();
                    if (c.TransaccionMysql("Insertar_Compra", paramtros.Parameters, CommandType.StoredProcedure)) {
                        c.Desconectar();
                        c.Conectar();
                        String co;
                        paramtros.Parameters.AddWithValue("p_id",id_producto);
                        DataTable dt = new DataTable();
                        dt = c.ConsultaMySQL("Consultar_Proveedores",paramtros.Parameters,CommandType.StoredProcedure);
                        if (dt.Rows.Count > 0) {
                            
                                co = dt.Rows[0]["correo"].ToString();
                            
                            Correo c1;

                                c1 = new Correo(1);
                                MailMessage m;
                                m = c1.crearMesaje(lblnomprove.Text, co, "azulm95@gmail.com", lblnombre.Text, lblproducto.Text,ncantidad.Value.ToString());
                            c1.MandarCorreo(m);
                            MessageBox.Show("pedido realizado");

                        }



                    }

                }
                else {

                    MessageBox.Show("Indique la cantidad del pedido.");

                }




            }
            catch (Exception es) { MessageBox.Show(es.Message); }      



        }

        private void frmComprasProveedores_Load(object sender, EventArgs e)
        {
            lblnombre.Text = nombre;
            lblrol.Text = rol;
            

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnconfiguracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion d = new frmConfiguracion();
            d.ShowDialog();
        }
    }

}
