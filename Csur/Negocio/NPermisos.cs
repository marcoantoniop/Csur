namespace Csur.Negocio
{
    public static class NPermisos
    {
        private static int idUsuario = 0;
        private static int idPersona = 0;
        private static string nombreUsuario = "";
        private static string nombrePersona = "";
        private static string apellidoPersona = "";
        private static string tipoUsuario = "";


        public static int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }
        
        public static string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }
            set
            {
                nombreUsuario = value;
            }
        }

        public static string TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

        public static string ApellidoPersona { get => apellidoPersona; set => apellidoPersona = value; }
        public static string NombrePersona { get => nombrePersona; set => nombrePersona = value; }
        public static int IdPersona { get => idPersona; set => idPersona = value; }
    }
}
