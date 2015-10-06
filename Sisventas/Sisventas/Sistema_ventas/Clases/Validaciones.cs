using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Sistema_ventas.Clases
{
    class Validaciones
    {

        public int ValidarTexto(GroupBox grupo) { 
        int k=0;
        foreach (var item in grupo.Controls){
            if(item.GetType()==typeof(TextBox)){
                if (((TextBox)item).Text == String.Empty)
                {
                    k = k + 1;
                }
                
       
            }
        }

        return k; 
        }


        public void LimpiarTexto(GroupBox grupo)
        {
           
            foreach (var item in grupo.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    if (((TextBox)item).Text != String.Empty)
                    {
                        ((TextBox)item).Text = String.Empty;
                    }


                }
            }

       
        }  


        
   
    
    
    
    
    }
}
