﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using Csur.Datos;
using DevExpress.XtraEditors;
using Csur.Negocio;

namespace Csur.Presentacion.Admin
{
    public partial class FrmAdminPersonas : Csur.Presentacion.FrmMaestro
    {
        private DBcsurEntities dbContext = new DBcsurEntities();
        private EntidadPERSONA miEntidad = new EntidadPERSONA();
        private string mensajeError;
        public FrmAdminPersonas()
        {
            InitializeComponent();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.PERSONA.Load();
            // This line of code is generated by Data Source Configuration Wizard
            pERSONABindingSource.DataSource = dbContext.PERSONA.Local.ToBindingList();
        }

        private void BtnNuevaPersona_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*************************
             * CREAMOS EL CONTROL
             *************************/

            Controles.ControlPersona miControl = new Controles.ControlPersona();
            XtraDialogArgs miDialogo = new XtraDialogArgs();
            miDialogo.Showing += Args_Showing;
            miDialogo.Content = miControl;
            miDialogo.Caption = "Nuevo personal de la Empresa";
            miDialogo.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
            /**********************************
             * SI HAY ESTABLECEMOS PROPIEDADES
             * ********************************/
            miControl.pERSONABindingSource.DataSource = miEntidad;
            /*************************************
            * MOSTRAMOS EL DIALOGO EN PANTALLA
            * ***********************************/
            DialogResult miResultado = XtraDialog.Show(miDialogo);
            /***************************************
             * AL CERRARSE VERIFICAMOS EL BOTON OK
             * *************************************/
            if (miResultado == DialogResult.OK)
            {
                miEntidad = (EntidadPERSONA)miControl.pERSONABindingSource.Current;
                /**********************************************************
                 * VERIFICAMOS LOS CAMPOS LLENADOS DE FORMA OBLIGATORIA
                 * ********************************************************/
                if (verificaCamposObligatoriosMiControl(miEntidad))
                {
                    //miEntidad.fecha_reg = DateTime.Now;
                    //miEntidad.id_usuario = NPermisos.IdUsuario;
                    dbContext.PERSONA.Add(miEntidad);
                    dbContext.SaveChanges();
                    miEntidad = new EntidadPERSONA();
                }
                else
                {
                    Mensajes.MensajeSimple("Falta información", this.mensajeError, MessageBoxIcon.Stop);
                }

                //Mensajes.MensajeRapido(miEntidad.apellidos + "  " + miEntidad.id_usuario);
            }
        }
        private bool verificaCamposObligatoriosMiControl(EntidadPERSONA entidadControl)
        {
            bool resultado = true;
            mensajeError = "";
            if (entidadControl.Nombre == null)
            {
                mensajeError = "Nombre" + Environment.NewLine;
                resultado = false;
            }
            if (entidadControl.Apellido == null)
            {
                mensajeError = "Apellido" + Environment.NewLine;
                resultado = false;
            }
            if (entidadControl.Estado == null)
            {
                mensajeError += "Estado: activo / inactivo" + Environment.NewLine;
                resultado = false;
            }

            return resultado;
        }
    }
}