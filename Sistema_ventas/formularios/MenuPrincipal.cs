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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private String nombre;
        private String rol;
        public void setNombre(String n) {
            this.nombre = n;
        }
        public void setRol(String r){
            this.rol = r;
        }



 
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            lblnombre.Text = nombre;
            lblrol.Text = rol;
        
        
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario i = new Inventario();
            i.setNombre(nombre);
            i.setRol(rol);
            i.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.setNombre(nombre);
            ventas.setRol(rol);
            ventas.ShowDialog();





        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmComprasProveedores cp = new frmComprasProveedores;
            cp.setNombre(nombre);
            cp.setRol(rol);
            this.Hide();
            cp.ShowDialog();



        }
    }
}
