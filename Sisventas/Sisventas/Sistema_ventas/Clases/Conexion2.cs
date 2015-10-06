using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_ventas.datos;
namespace Sistema_ventas.Clases
{
    class Conexion2{
        private postEntities basedatos = new postEntities();
        private String respuesta = " ";

        public void Insertar(String tabla, String[] registro){
            switch (tabla){
                    case "usuarios":
                        tbl_usuarios usuario = new tbl_usuarios();

                        usuario.nombre = registro[0];
                        usuario.clave = registro[1];
                        usuario.rol = registro[2];
                        basedatos.tbl_usuarios.Add(usuario);
                        basedatos.SaveChanges();
                        respuesta = "Usuario creado con exito!";
                        break;
                       

                    default:
                        respuesta = " ";
                        break;
                }
        }

        public Boolean Loguin(String nombre,String clave){
            Boolean resultado=  false;
            var query = from p in basedatos.tbl_usuarios
                        where p.nombre == nombre && p.clave == clave
                        select p.nombre.FirstOrDefault();

            if (query != null){
                resultado = true;
            }else {
                resultado = false;
            }


            return resultado;
        }
        
       

            




          
 

    
    
    
    
    
    
    




}

}
