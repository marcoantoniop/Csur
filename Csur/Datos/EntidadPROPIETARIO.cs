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
    
    public partial class EntidadPROPIETARIO
    {
        public int IdPropietario { get; set; }
        public int IdPersona { get; set; }
        public int IdLote { get; set; }
        public string Estado { get; set; }
        public System.DateTime Fecha { get; set; }
    
        public virtual EntidadLOTE LOTE { get; set; }
        public virtual EntidadPERSONA PERSONA { get; set; }
    }
}
