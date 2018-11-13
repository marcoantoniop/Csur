using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csur.Datos;
using DevExpress.XtraEditors;

namespace Csur.Negocio
{
    public class CapaNegocio
    {
        public DBcsurEntities dbContext = new DBcsurEntities();

        protected void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Buttons[DialogResult.OK].Text = "Guardar";
            e.Buttons[DialogResult.Cancel].Text = "Cancelar";
        }

        protected void Args_ShowingContinuarNuevo(object sender, XtraMessageShowingArgs e)
        {
            e.Buttons[DialogResult.Yes].Text = "Nuevo";
            e.Buttons[DialogResult.No].Text = "Recuperar";
        }

        public bool DialogoComenzarFormularioBlanco()
        {
            bool respuesta = true;
            XtraMessageBoxArgs miMensaje = new XtraMessageBoxArgs();
            miMensaje.Showing += Args_ShowingContinuarNuevo;
            miMensaje.Buttons = new DialogResult[] { DialogResult.Yes, DialogResult.No };
            miMensaje.Text = "Hay datos guardados del anterior formulario sin completar, desea continuar llenando los datos? \n O desea comenzar con un formulario Nuevo en blanco.";
            miMensaje.Caption = "Datos recuperados";
            DialogResult miResultado = XtraMessageBox.Show(miMensaje);
            if (miResultado == DialogResult.Yes)
            {
                respuesta = true;
            }
            if (miResultado == DialogResult.No)
            {
                respuesta = false;
            }
            return respuesta;
        }
    }

}
