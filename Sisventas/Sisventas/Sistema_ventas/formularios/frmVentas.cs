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
        private int _Existencias;
        private DataTable productos;
        private DataRow columna; 



        public int Existencias
        {
            get { return _Existencias; }
            set { _Existencias = value; }
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

        private void frmVentas_Load(object sender, EventArgs e){




        }

        private void limpiarGridinventario()
        {
            dgInventario.Rows.Clear();
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
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
                    limpiarGridinventario();
                    productos = dt;
                    dgInventario.DataSource = productos;
                }
                else
                {
                    
                    limpiarGridinventario();

                    productos = null;
                }


            }
            else {

                limpiarGridinventario();
                productos = null;
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (dgInventario.Rows.Count > 0)
            {
                
                
                Productos p = new Productos();

                p.Codigo = Convert.ToString(dgInventario.CurrentRow.Cells["codigo"].Value);
                p.Nombre = Convert.ToString(dgInventario.CurrentRow.Cells["nombre"].Value);
                p.Marca = Convert.ToString(dgInventario.CurrentRow.Cells["marca"].Value);
                p.Precio = Convert.ToString(dgInventario.CurrentRow.Cells["precio"].Value);
                p.Clase = Convert.ToString(dgInventario.CurrentRow.Cells["fecha_vencimiento"].Value);
                p.Descripcion = Convert.ToString(dgInventario.CurrentRow.Cells["descripcion"].Value);
                Existencias = Convert.ToInt32(dgInventario.CurrentRow.Cells["cantidades_disponibles"].Value);
                columna =  new DataRow();
                columna[0]=p.Codigo;
                columna[1] = p.Nombre;
                columna[2] = p.Marca;
                columna[3] = p.Precio;
                columna[4] = p.Fechav;
                columna[5] = p.Descripcion;
                columna[6] = Existencias;


            
            
            }
            else {

                MessageBox.Show("Seleccione primero un producto antes para agregarlo al carro.");
            }
        
        
        
        }

        private void dgInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Prodcto seleccionado: " + dgInventario.CurrentRow.Cells["nombre"].Value + " Precio: " + dgInventario.CurrentRow.Cells["precio"].Value);
        }

       

        
    }
}
