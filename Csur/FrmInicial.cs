using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Csur.Presentacion;
using Csur.Presentacion.Admin;

namespace Csur
{
    public partial class FrmInicial : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdminTerrenos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAdminTerreno frmAdminTerreno = new FrmAdminTerreno();
            frmAdminTerreno.ShowDialog();
        }

        private void BtnAdminUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAdminPersonas frmAdminPersonas = new FrmAdminPersonas();
            frmAdminPersonas.ShowDialog();
        }

        private void BtnNuevaVenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNuevaVenta frmNuevaVenta = new FrmNuevaVenta();
            frmNuevaVenta.ShowDialog();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdminPropietario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAdminPropietario frmAdminPropietario = new FrmAdminPropietario();
            frmAdminPropietario.ShowDialog();
        }
    }
}
