//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_Coki.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedido_detalle
    {
        public int idpedido { get; set; }
        public Nullable<int> idproducto { get; set; }
        public Nullable<decimal> peso { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public Nullable<decimal> descuento { get; set; }
        public Nullable<decimal> subtotal { get; set; }
        public Nullable<int> idfactura { get; set; }
    
        public virtual factura_cabecera factura_cabecera { get; set; }
        public virtual producto producto { get; set; }
    }
}