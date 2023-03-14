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
    
    public partial class GESTION_PLANES_COBRO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GESTION_PLANES_COBRO()
        {
            this.GESTION_DEUDA = new HashSet<GESTION_DEUDA>();
            this.RUBRO_COBRO = new HashSet<RUBRO_COBRO>();
        }
    
        public int ID_PLAN_COBRO { get; set; }
        public Nullable<int> ID_USUARIO { get; set; }
        public Nullable<int> ID_ESTADO_DEUDA { get; set; }
        public string NOMBRE_PLAN { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<System.DateTime> FECHA_INICIO { get; set; }
        public Nullable<System.DateTime> FECHA_FIN { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
    
        public virtual ESTADO_DEUDA ESTADO_DEUDA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GESTION_DEUDA> GESTION_DEUDA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RUBRO_COBRO> RUBRO_COBRO { get; set; }
    }
}
