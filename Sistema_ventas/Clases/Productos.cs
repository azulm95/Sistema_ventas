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

        String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        String codigo;

        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        String marca;

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        String clase;

        public String Clase
        {
            get { return clase; }
            set { clase = value; }
        }
        String precio;

        public String Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        DateTime fechav;

        public DateTime Fechav
        {
            get { return fechav; }
            set { fechav = value; }
        }

        public String AgregarProducto(String nombre,String codigo, String marca,String descripcion, String clase, String precio, DateTime fechav) {
            Conexion c = new Conexion();
            String respuesta;
            MySqlCommand parametros = new MySqlCommand();
            parametros.Parameters.AddWithValue("p_codigo",codigo);
            parametros.Parameters.AddWithValue("p_nombre", nombre);
            parametros.Parameters.AddWithValue("p_marca", marca);
            parametros.Parameters.AddWithValue("p_id_clasificacion", clase);
            parametros.Parameters.AddWithValue("p_fechav", fechav);
            parametros.Parameters.AddWithValue("p_descripcion", descripcion);
            parametros.Parameters.AddWithValue("p_precio", precio);

            String sentencia = "Insertar_Producto";

            c.Conectar();
           Boolean a = c.TransaccionMysql(sentencia, parametros.Parameters,System.Data.CommandType.StoredProcedure);
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
