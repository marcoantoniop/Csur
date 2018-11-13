using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csur.Datos;

namespace Csur.Negocio
{
    public class NUsuarios : CapaNegocio
    {
        public EntidadPERSONA Login(string varUsuario, string varClave)
        {
            EntidadPERSONA respuestaEntidadUsuario;
            try
            {
                var cuenta = dbContext.PERSONA.SingleOrDefault(a => a.NombreUsuario.Equals(varUsuario));
                if (cuenta != null)
                {
                    if (cuenta.Clave == varClave && cuenta.Estado == "activo")
                    //if (cuenta.Clave == varClave)
                    {
                        //return cuenta;
                        respuestaEntidadUsuario = cuenta;
                    }
                    else
                    {
                        //return null;
                        respuestaEntidadUsuario = null;
                    }
                }
                else
                {
                    //return null;
                    respuestaEntidadUsuario = null;
                }
            }
            catch (EntityException ex)
            {
                Mensajes.MensajeSimple("Error de conexión", "No se puso conectar a la base de datos. ->" + ex.Message,
                    MessageBoxIcon.Error);
                respuestaEntidadUsuario = null;
            }
            catch (Exception ex)
            {
                Mensajes.ErrorEnDatos(ex, "Acceso al sistema");
                respuestaEntidadUsuario = null;
            }
            return respuestaEntidadUsuario;

        }
    }
}
