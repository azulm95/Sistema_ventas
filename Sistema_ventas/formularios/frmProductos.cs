using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_ventas.Controles;
namespace Sistema_ventas.formularios
{
    public partial class frmProductos : Form
    {
       
      
       private DataTable dtProductos = new DataTable();
        private Boolean aceptar = false;
        public int origen;
        public DataTable DtProductos{
         
            get
            {
                return dtProductos;
            }

            set
            {
                dtProductos = value;
            }
        }

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CrearProductos(origen);    
        }



        private void CrearProductos(int origen) {
            switch (origen) {
                case 1:
            mdProducto pro;
            foreach (DataRow fila in dtProductos.Rows)
            {
                pro = new mdProducto();
                       
                pro.chkNomPro.Text = fila["nombre"].ToString();
                pro.lblprecio.Text = fila["precio"].ToString();
                pro.lblmarca.Text = fila["marca"].ToString();
                pro.lblcantidad.Text = fila["cantidades_disponibles"].ToString();
                flpprductos.Controls.Add(pro);
            }

                    break;
                case 2:
                    Producto1 p;
                    foreach (DataRow fila in dtProductos.Rows)
                    {
                        p = new Producto1();
                        p.lblcodigo.Text = fila["codigo"].ToString();
                        p.chkproduc.Text = fila["nombre"].ToString();
                        p.lblprec.Text = fila["precio"].ToString();
                        flpprductos.Controls.Add(p);
                    }


                    break;







            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnseleccion_Click(object sender, EventArgs e)
        {
            switch (origen)
            {

                case 1:
                    int i = 0;
                    foreach (mdProducto p in flpprductos.Controls)
                    {
                        if (p.chkNomPro.Checked == true)
                        {

                            DtProductos.Rows[i]["seleccion"] = "Si";
                            DtProductos.Rows[i]["pedido"] = p.Ncantidad.Value;
                            aceptar = true;
                        }
                        i = i + 1;
                    }

                    if (aceptar)
                    {
                        frmVentas.factura = dtProductos;
                        this.Dispose();
                    }
                    else
                    {

                        MessageBox.Show("Debe Elegir como minimo un solo producto para agregar!");
                    }

                    break;

                case 2:
                    int a = 0;

                    foreach (Producto1 p in flpprductos.Controls)
                    {
                        if (p.chkproduc.Checked == true)
                        {
                            frmComprasProveedores.id_producto = p.lblcodigo.Text;
                            frmComprasProveedores.costo = p.lblprec.Text;
                            frmComprasProveedores.nompro = dtProductos.Rows[a]["nombre"].ToString();
                            this.Dispose();

                        }
                        a = a + 1;
                    }



                    break;

            }
        }
    }
}
