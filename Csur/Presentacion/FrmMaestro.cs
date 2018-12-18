using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csur.Negocio;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace Csur.Presentacion
{
    public partial class FrmMaestro : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMaestro()
        {
            InitializeComponent();
            this.CargarFechaBar();
            this.CargarUsuarioBar();
        }

        private void CargarUsuarioBar()
        {
            this.barItemUsuario.Caption = NPermisos.ApellidoPersona + " " + NPermisos.NombrePersona;
        }

        private void CargarFechaBar()
        {
            DateTime miFecha = DateTime.Now;             // Use current time.
            this.barItemFecha.Caption = miFecha.ToLongDateString();
            //string format = "MMM ddd d HH:mm yyyy";   // Use this format.

        }

        private void BtnCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Buttons[DialogResult.OK].Text = "Guardar";
            e.Buttons[DialogResult.Cancel].Text = "Cancelar";
        }

    }
}