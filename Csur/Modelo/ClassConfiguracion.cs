using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csur.Datos;

namespace Csur.Modelo
{
    public static class ClassConfiguracion
    {
        private static EntidadPARAMETROS entidadParametros;
        private static EntidadCONFIGURACION entidadConfiguracion;
        private static ICollection<EntidadPARAMETROS> listaEntidadParametros;

        public static EntidadPARAMETROS EntidadParametros { get => entidadParametros; set => entidadParametros = value; }
        public static EntidadCONFIGURACION EntidadConfiguracion { get => entidadConfiguracion; set => entidadConfiguracion = value; }
        public static ICollection<EntidadPARAMETROS> ListaEntidadParametros { get => listaEntidadParametros; set => listaEntidadParametros = value; }
    }
}
