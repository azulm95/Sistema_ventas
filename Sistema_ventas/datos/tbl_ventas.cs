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
    
    public partial class tbl_ventas
    {
        public int id { get; set; }
        public int id_factura { get; set; }
        public string observacion { get; set; }
    
        public virtual tbl_factura tbl_factura { get; set; }
    }
}
