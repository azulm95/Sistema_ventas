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
namespace Sistema_ventas.formularios
{
    public partial class frmComprasProveedores : Form
    {
        public static String nomp;
        public static String nompro;
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
            p.DtProductos = c.ConsultaMySQL("ColsultarProducto",null,CommandType.StoredProcedure);
            c.Desconectar();
            p.ShowDialog();
            lblproducto.Text = nompro;

        }

        private void btnpedido_Click(object sender, EventArgs e)
        {









        }

        private void frmComprasProveedores_Load(object sender, EventArgs e)
        {
            lblnombre.Text = nombre;
            lblrol.Text = rol;            


        }
    }

}
