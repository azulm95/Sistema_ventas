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
using Sistema_ventas.formularios;


namespace Sistema_ventas.formularios
{
    public partial class frmCliente : Form
    {
        
       
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Validaciones v =  new Validaciones();
            if(v.ValidarTexto(groupBox1) == 0){
            Conexion c = new Conexion();
                c.Conectar();
               MySqlCommand parametros = new MySqlCommand();
                parametros.Parameters.AddWithValue("p_nombre",txtnombre.Text);
                parametros.Parameters.AddWithValue("p_apellido",txtapellido.Text);
                parametros.Parameters.AddWithValue("p_empresa",txtempresa.Text);
                parametros.Parameters.AddWithValue("p_direccion",txtdireccion.Text);
                parametros.Parameters.AddWithValue("p_ciudad",txtciudad.Text);
                parametros.Parameters.AddWithValue("p_telefono",txttelefono.Text);
                parametros.Parameters.AddWithValue("p_tipo",cbxtipo.SelectedText);
                parametros.Parameters.AddWithValue("p_correo",txtcorreo);
                c.TransaccionMysql("Insertar_Cliente",parametros.Parameters,CommandType.StoredProcedure);

                c.Desconectar();

                

            
            }
          






        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetterOrDigit(e.KeyChar)){
          
      
            }
                            
                            
            public DataTable AgregarCliente(){
            DataTable dt = new DataTable();
             

            
            
            return null;}
                
                            }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            








        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if((txtnombre.Text != null)||(txtnombre.Text != " ")){
             Conexion c = new Conexion();
                MySqlCommand param = new MySqlCommand();

                param.Parameters.AddWithValue("p_parametro",txtnombre.Text +" %");

                DataTable dt = new DataTable();
                c.Conectar();

               dt = c.ConsultaMySQL("Consulta_cliente",param.Parameters,CommandType.StoredProcedure);
                    if(dt != null){

                       txtnombre.Text =Convert.ToString(dt.Rows[0][0]);
                       txtapellido.Text =Convert.ToString(dt.Rows[1][0]);
                       txtempresa.Text =Convert.ToString(dt.Rows[2][0]);
                        txtdireccion.Text= Convert.ToString(dt.Rows[3][0]);
                       txtciudad.Text = Convert.ToString(dt.Rows[4][0]);
                        txttelefono.Text =Convert.ToString(dt.Rows[5][0]);
                         txtcorreo.Text =Convert.ToString(dt.Rows[6][0]);            
                c.Desconectar();
                    }
                    
        
                                c.Desconectar();    
        }
        }


                        }



                    }


            
            
            }
        }

      
    }
}
