//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_ventas.datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_compras
    {
        public int id { get; set; }
        public string id_proveedor { get; set; }
        public int id_usuario { get; set; }
        public string id_producto { get; set; }
        public int cantidad { get; set; }
        public decimal costo { get; set; }
        public System.DateTime fecha { get; set; }
    
        public virtual tbl_producto tbl_producto { get; set; }
        public virtual tbl_proveedor tbl_proveedor { get; set; }
        public virtual tbl_usuarios tbl_usuarios { get; set; }
    }
}
