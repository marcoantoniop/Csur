using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csur.Negocio
{
    public static class Mensajes
    {
        public static void ErrorEnDatos(Exception e, string proceso)
        {
            MessageBox.Show("Se detecto un error en: " + proceso +
                            Environment.NewLine + "Por favor notifique al desollador con los siguientes datos:" +
                            Environment.NewLine + e.Message,
                "Error de datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

        }
        public static void MensajeSimple(string titulo, string mensaje, MessageBoxIcon icono)
        {
            XtraMessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }

        public static void MensajeRapido(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
