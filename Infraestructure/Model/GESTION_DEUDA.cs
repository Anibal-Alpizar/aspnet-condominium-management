//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infraestructure.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GESTION_DEUDA
    {
        public int ID_GESTION_DEUDA { get; set; }
        public int ID_RESIDENCIA { get; set; }
        public Nullable<int> ID_PLAN_COBRO { get; set; }
        public int MES { get; set; }
        public int ANIO { get; set; }
        public decimal MONTO { get; set; }
        public System.DateTime FECHA_VENCIMIENTO { get; set; }
        public int ID_ESTADO_DEUDA { get; set; }
        public string DETALLES_RUBROS { get; set; }
        public System.DateTime FECHA_REGISTRO { get; set; }
        public System.DateTime FECHA_PAGO { get; set; }
        public Nullable<decimal> TOTALPAGAR { get; set; }
    
        public virtual ESTADO_DEUDA ESTADO_DEUDA { get; set; }
        public virtual RESIDENCIA RESIDENCIA { get; set; }
        public virtual PLAN_COBRO PLAN_COBRO { get; set; }
    }
}
