using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Csur.Negocio;

namespace Csur.Presentacion
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            
            NUsuarios nUsuarios = new NUsuarios();
            
            if (txtUsuario.Text != "" && txtClave.Text != "")
            {
                var cuenta = nUsuarios.Login(txtUsuario.Text, txtClave.Text);
                if (cuenta == null)
                {
                    // Acceso invalido
                    Mensajes.MensajeSimple("Error en acceso", "Sus datos son inválidos", MessageBoxIcon.Error);
                }
                else
                {
                    // Acceso correcto
                    NPermisos.NombreUsuario = cuenta.NombreUsuario;
                    NPermisos.TipoUsuario = cuenta.Tipo;
                    NPermisos.IdUsuario = cuenta.IdPersona;
                    NPermisos.IdPersona = cuenta.IdPersona;
                    NPermisos.NombrePersona = cuenta.Nombre;
                    NPermisos.ApellidoPersona = cuenta.Apellido;
                    FrmInicial frmInicial = new FrmInicial();
                    frmInicial.Show();
                    this.Hide();
                }

            }
            
            
        }
    }
}