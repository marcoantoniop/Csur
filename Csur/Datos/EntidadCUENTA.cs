//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Csur.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class EntidadCUENTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntidadCUENTA()
        {
            this.TRANSACCION = new HashSet<EntidadTRANSACCION>();
        }
    
        public int IdCuenta { get; set; }
        public Nullable<int> IdPersona { get; set; }
        public string Banco { get; set; }
        public string Cuenta1 { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual EntidadPERSONA PERSONA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntidadTRANSACCION> TRANSACCION { get; set; }
    }
}
