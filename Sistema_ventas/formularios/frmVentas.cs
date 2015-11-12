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
       public static string codicliente;
        private String nombre;
        private String rol;
        private int _Existencias;
        private DataTable productos;
        public static DataTable factura;
        private DataTable venta = new DataTable();
        private String iva = "no";
        //DataRow columna; 
        public String[] vec;


        public int Existencias
        {
            get { return _Existencias; }
            set { _Existencias = value; }
        }

        public DataTable Factura
        {
            get
            {
                return factura;
            }

            set
            {
                factura = value;
            }
        }

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

        private void crearVenta() {
            venta.Columns.Add("codigo",typeof(object));
            venta.Columns.Add("nombre", typeof(object));
            venta.Columns.Add("precio", typeof(object));
            venta.Columns.Add("pedido", typeof(object));
        }

        private void crearNumero() {
            try
            {

           
            DataTable d = new DataTable();
            Conexion c = new Conexion();
            c.Conectar();
            d = c.ConsultaMySQL("CrearNumero",null,CommandType.StoredProcedure);
            String n;
            int cod;
                if ((d.Rows[0][0].ToString() == String.Empty)||((d.Rows[0][0] is DBNull))) {
                    n = "0";
                }
                else {
                    n = d.Rows[0][0].ToString();
                }


           cod = Convert.ToInt32(n);
            cod = cod + 1;
            lblCodigo.Text = cod.ToString();
            c.Desconectar();
            c = null;

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
                
            }
        }

        private void frmVentas_Load(object sender, EventArgs e){
            crearVenta();
            crearNumero();
            lblnombre.Text = nombre;
            lblrol.Text = rol;
            lblusuario.Text = nombre;


        }

        //private void limpiarGridinventario()
        //{
        //    dgInventario.Rows.Clear();
        //}
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                DataTable dt = new DataTable();
                MySqlCommand parametros = new MySqlCommand();
                Conexion canal = new Conexion();
                String param = txtproducto.Text + "%";
                parametros.Parameters.AddWithValue("p_parametro", param);

                String sentencia = "Consultar_Productos_para_vender";
                canal.Conectar();

                dt = canal.ConsultaMySQL(sentencia, parametros.Parameters, CommandType.StoredProcedure);
                if (dt != null)
                {
                    productos = new DataTable();
                    //limpiarGridinventario();
                    //productos = dt;
                    //dgInventario.DataSource = productos;

                    frmProductos c = new frmProductos();
                    c.origen = 1;
                    c.DtProductos = dt;
                    c.ShowDialog();
                    if (factura != null)
                    {
                   
                        foreach (DataRow item in factura.Rows)
                        {
                            if (item["seleccion"].Equals("Si"))
                            {
                                DataRow a = venta.NewRow();
                                a["codigo"] = item["codigo"].ToString();
                                a["nombre"] = item["nombre"].ToString();
                                a["precio"] = item["precio"].ToString();
                                a["pedido"] = item["pedido"].ToString();

                                venta.Rows.Add(a);
                            }


                        }

                        dgCarro.DataSource = venta;

                        CalcularPrecios();
                    }
                    }
                else
                {
                    
                    //limpiarGridinventario();

                    productos = null;
                }


            }
            else {

                //limpiarGridinventario();
                //productos = null;
            }


        }



        public void CalcularPrecios() {
            String v,c;
            int ca;
            decimal sv1,sv2 = 0,total;
            foreach (DataRow item in venta.Rows)
            {
                if (chkiva.Checked == true)
                {
                    v = item["precio"].ToString();
                    c = item["pedido"].ToString();
                    ca = Convert.ToInt32(c);
                    sv1 = Convert.ToDecimal(v);
                    sv2 = sv2 + sv1 * ca;
                    lblsubtotal.Text = sv2.ToString();
                    total = +CalcularIVA(sv1, ca);
                    lbltotal.Text = total.ToString();
                    iva = "si";
                }
                else {
                    v = item["precio"].ToString();
                    c = item["pedido"].ToString();
                    ca = Convert.ToInt32(c);
                    sv1 = Convert.ToDecimal(v);
                    sv2 = sv2 + sv1 * ca;
                    lblsubtotal.Text = sv2.ToString();
                    lbltotal.Text = sv2.ToString();


                }

            }


        } 


        private void btnAgregar_Click(object sender, EventArgs e)
        {

         
        
        
        }


        public decimal CalcularIVA(decimal precio,int cantidad)
        {
            decimal iva,i =0.16M;
            iva = (precio * cantidad)*i;
            return iva;
        } 

        private void txtproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmClientes c = new frmClientes();
            c.ShowDialog();
            lblnombrec.Text = codicliente;


        }

        private void tabCarro_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }


        private void Comprar(String codigo,String cantidad) {
            Conexion c = new Conexion();
            MySqlCommand parametros = new MySqlCommand();
            parametros.Parameters.AddWithValue("p_numero",lblCodigo.Text);
            parametros.Parameters.AddWithValue("p_cliente", lblnombrec.Text);
            parametros.Parameters.AddWithValue("p_producto", codigo);
            parametros.Parameters.AddWithValue("p_subtotal", lblsubtotal.Text);
            parametros.Parameters.AddWithValue("p_iva", iva);
            parametros.Parameters.AddWithValue("p_total", lbltotal.Text);
            parametros.Parameters.AddWithValue("p_cantidad", cantidad);
            parametros.Parameters.AddWithValue("p_usuario", lblusuario.Text);
            parametros.Parameters.AddWithValue("p_observacion","Nada");
            c.Conectar();

            if (c.TransaccionMysql("InsertarFactura", parametros.Parameters, CommandType.StoredProcedure))
            {
                c.Desconectar();
                c.Conectar();
                if (c.TransaccionMysql("CrearVenta", parametros.Parameters, CommandType.StoredProcedure)) {
                    MessageBox.Show("Venta realizada con exito");
                    c.Desconectar();
                }
                c.Desconectar();


               
            }
            else {


            } 


        }


        private void bagregar_Click(object sender, EventArgs e)
        {

            if (dgCarro.RowCount > 0)
            {

                foreach (DataRow item in venta.Rows)
                {



                    Comprar(item["codigo"].ToString(),item["pedido"].ToString());



                }


            }






        }

        private void btnconfiguracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion d = new frmConfiguracion();
            d.ShowDialog();
        }





        //private void dgInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    MessageBox.Show("Prodcto seleccionado: " + dgInventario.CurrentRow.Cells["nombre"].Value + " Precio: " + dgInventario.CurrentRow.Cells["precio"].Value);

        //}
    }
}
