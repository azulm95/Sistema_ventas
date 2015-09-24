using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sistema_ventas.Clases;
namespace Sistema_ventas.Clases
{
    class Productos
    {

        public String AgregarProducto(String nombre,String codigo, String marca,String descripcion, String clase, String precio, DateTime fechav) {
            Conexion c = new Conexion();
            String respuesta;
            MySqlCommand parametros = new MySqlCommand();
            parametros.Parameters.AddWithValue("@codigo",codigo);
            parametros.Parameters.AddWithValue("@nombre", nombre);
            parametros.Parameters.AddWithValue("@marca", marca);
            parametros.Parameters.AddWithValue("@id_clasificacion", clase);
            parametros.Parameters.AddWithValue("@fechav", fechav);
            parametros.Parameters.AddWithValue("@descripcion", descripcion);
            parametros.Parameters.AddWithValue("@precio", precio);

            String sentencia = "INSERT INTO `tbl_producto`(`codigo`,`nombre`,`marca`,`id_clasificacion`,`fecha_vencimiento`,`descripcion`,`precio`)VALUES(@codigo,@nombre,@marca,@id_clasificacion,@fechav,@descripcion,@precio);";

            c.Conectar();
           Boolean a = c.TransaccionMysql(sentencia, parametros.Parameters);
            c.Desconectar();
            if (a == true)
            {
                respuesta = "Producto agregado exitosamente!";
            
            }
            else {
                respuesta = "Fallo al agregar producto";
            }
            c = null;

            return respuesta;
        }
    
    
    
    
    }
}
