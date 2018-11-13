using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace Csur.Presentacion
{
    public partial class FrmMaestro : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMaestro()
        {
            InitializeComponent();
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