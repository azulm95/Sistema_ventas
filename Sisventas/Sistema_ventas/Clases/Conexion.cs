using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.Windows.Forms;
namespace Sistema_ventas.Clases
{
    


    class Conexion{
        
        private MySqlTransaction transaccion;
        private MySqlConnection canal = new MySqlConnection();
        private String servidor = "Server=localhost;";
        private String db = "Database=post;";
        private String user = "Uid=root;";
        private String clave = "Pwd=S1st3m4s;";
        
        
        public void Conectar() {
            try
            {
                canal.ConnectionString = servidor + db + user + clave;
                canal.Open();
            }
            catch (Exception ex) {
                MessageBox.Show("error de conexion: " + ex.Message);
            }
        }


        public System.Data.DataTable ConsultaMySQL(String query,MySqlParameterCollection parametros) { 
            System.Data.DataTable tabla = new System.Data.DataTable();
            try {

            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand comando = new MySqlCommand(query, canal);

            if (parametros != null)
            {
                foreach (var item in parametros)
                {
                    comando.Parameters.Add(item);

                }
            }



            adapter.SelectCommand = comando;
            adapter.Fill(tabla);
            if (tabla.Rows.Count > 0)
            {
                return tabla;
            }
            else {
                return null;
            }

            
            }
            catch (Exception er) { MessageBox.Show("error: " + er.Message); return null; }
         
        }
        
        
        
        
        public void Desconectar() {
            try
            {

                canal.Close();

            }
            catch (Exception) { }
            }

        public Boolean TransaccionMysql(String query,MySqlParameterCollection parametros) {
            Boolean respuesta = false;
            int f;
            try{
                transaccion = canal.BeginTransaction();
                MySqlCommand comando = new MySqlCommand(query, canal);

                if (parametros != null) {
                    foreach (var item in parametros){
                        comando.Parameters.Add(item);

                    }
                }

                comando.Transaction = transaccion;
           f= comando.ExecuteNonQuery();
             transaccion.Commit();

             if (f>=0){
                 respuesta = true;
             }
             else{
                 respuesta = false;
                
             }
            
            
            
            }catch (Exception ex){
                transaccion.Rollback();
                MessageBox.Show("error sql:" + ex.Message);
                respuesta = false;
            }
        return respuesta;
        }
    
    

    
    
    
    
    
    
    }
}
