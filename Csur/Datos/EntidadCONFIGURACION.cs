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
    
    public partial class EntidadCONFIGURACION
    {
        public int IdConfig { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Parametro { get; set; }
        public string ValorA { get; set; }
        public string ValorB { get; set; }
        public string ValorC { get; set; }
        public string Observacion { get; set; }
        public bool Activo { get; set; }
        public int CreadoPor { get; set; }
        public Nullable<int> BajaPor { get; set; }
    
        public virtual EntidadPARAMETROS PARAMETROS { get; set; }
        public virtual EntidadPERSONA PERSONA { get; set; }
        public virtual EntidadPERSONA PERSONA1 { get; set; }
    }
}
