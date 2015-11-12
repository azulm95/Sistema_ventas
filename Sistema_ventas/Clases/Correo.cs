using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace Sistema_ventas.Clases
{
    class Correo
    {
      
        SmtpClient server;
        public Correo(int tipo) {
            switch (tipo)
            {
                case 1:
                    server = new SmtpClient("smtp.gmail.com", 581);
                    break;
                case 2:
                    server = new SmtpClient("smtp.hotmail.com", 25);
                    break;
                default:
                    break;
            }
            }





        public void MandarCorreo(MailMessage mensaje)
        {
            server.Send(mensaje);
        }

        public MailMessage crearMesaje(String proveedor,String cprovedor,String mi_correo,String usuario,String producto, String cantidad) {

            MailMessage mnsj = new MailMessage();

            mnsj.Subject = "Peticion de compra";

            mnsj.To.Add(new MailAddress(cprovedor));

            mnsj.From = new MailAddress(mi_correo,usuario);

            /* Si deseamos Adjuntar algún archivo*/
           // mnsj.Attachments.Add(new Attachment("C:\\archivo.pdf"));

            mnsj.Body = "Señores "+proveedor+" El siguiente es para solicitarle el pedido del producto: "+producto+" en la cantidad de: "+cantidad+". gracias por su atencion.";

            /* Enviar */

            return mnsj;
        }








    }



    }

