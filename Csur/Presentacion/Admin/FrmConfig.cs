using Csur.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Csur.Presentacion.Admin
{
    public partial class FrmConfig : Csur.Presentacion.FrmMaestro
    {
        private DBcsurEntities dbContext = new DBcsurEntities();
        private EntidadFASE miEntidadFase = new EntidadFASE();
        private EntidadPERSONA miEntidadPersona = new EntidadPERSONA();
        private EntidadCONFIGURACION miEntidadConfiguracion = new EntidadCONFIGURACION();
        private EntidadCONFIGURACION miEntidadConfiguracionOld = new EntidadCONFIGURACION();
        private EntidadPARAMETROS miEntidadParametros = new EntidadPARAMETROS();
        private List<EntidadPARAMETROS> listEntidadParametross = new List<EntidadPARAMETROS>();
        
        public FrmConfig()
        {
            InitializeComponent();
            this.ActivaControlConfig(false);
            dbContext.PARAMETROS.Load();
            parametrosBindingSource.DataSource = dbContext.PARAMETROS.Local.ToBindingList();
            DesactivarBotonesConfig();

        }

        private void DesactivarBotonesConfig()
        {
            BtnGuardarNuevaConfig.Enabled = false;
            BtnNuevaConfig.Enabled = false;
        }


        private void ActivaControlConfig(bool activar = true)
        {
            if (activar)
            {
                controlConfiguraParametro.Enabled = true;
            }
            else
            {
                controlConfiguraParametro.Enabled = false;
            }
        }

        private void BtnNuevaConfig_Click(object sender, EventArgs e)
        {
            miEntidadConfiguracionOld = miEntidadConfiguracion;
            BtnGuardarNuevaConfig.Enabled = true;
            BtnNuevaConfig.Enabled = false;

            miEntidadConfiguracion = new EntidadCONFIGURACION();
            miEntidadConfiguracion.Parametro = miEntidadParametros.Parametro;
            miEntidadConfiguracion.Fecha = DateTime.Now;
            miEntidadConfiguracion.Activo = true;
            miEntidadConfiguracion.CreadoPor = Negocio.NPermisos.IdPersona;
            this.ActivaControlConfig(true);
            controlConfiguraParametro.cONFIGURACIONBindingSource.DataSource = miEntidadConfiguracion;

        }

        private void BtnGuardarNuevaConfig_Click(object sender, EventArgs e)
        {
            if (miEntidadConfiguracionOld != null)
            {
                miEntidadConfiguracionOld.Activo = false;
                miEntidadConfiguracionOld.BajaPor = Negocio.NPermisos.IdPersona;
                var temp = dbContext.CONFIGURACION.Find(miEntidadConfiguracionOld.IdConfig);
                dbContext.Entry(temp).CurrentValues.SetValues(miEntidadConfiguracionOld);
                dbContext.SaveChanges();
                controlConfiguraParametro.Validate();
                miEntidadConfiguracion =
                    (EntidadCONFIGURACION)controlConfiguraParametro.cONFIGURACIONBindingSource.Current;
                dbContext.CONFIGURACION.Add(miEntidadConfiguracion);
                dbContext.SaveChanges();
                this.DesactivarBotonesConfig();
                this.ActivaControlConfig(false);
                //controlConfiguraParametro.Enabled = true;
            }
            else
            {
                controlConfiguraParametro.Validate();
                miEntidadConfiguracion =
                    (EntidadCONFIGURACION)controlConfiguraParametro.cONFIGURACIONBindingSource.Current;
                dbContext.CONFIGURACION.Add(miEntidadConfiguracion);
                dbContext.SaveChanges();
                this.DesactivarBotonesConfig();
                this.ActivaControlConfig(false);
                //controlConfiguraParametro.Enabled = false;
            }

        }

        private void ActivarBtnCrearNuevaConfig()
        {
            BtnNuevaConfig.Enabled = true;
        }

        /***********************************************
         *
         *
         *  EVENTOS EL LOS BOTONES DE ITEMS BAR
         *
         *
         ***********************************************/
        #region EventosBarsItem


        private void navBarItemComisionIndependiente_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CargarDatosParametro("comision_independiente"))
            {
                //controlConfiguraParametro.cONFIGURACIONBindingSource[0] = miEntidadParametros;
                this.ActivaControlConfig(false);
                BtnGuardarNuevaConfig.Enabled = false;
            }
        }

        

        private void navBarItemComisionPromotor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CargarDatosParametro("comision_promotor"))
            {
                this.ActivaControlConfig(false);
                BtnGuardarNuevaConfig.Enabled = false;
                //controlConfiguraParametro.cONFIGURACIONBindingSource.DataSource = miEntidadConfiguracion;
            }
        }

        private void navBarItemAsalariadoEncGrupo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CargarDatosParametro("comision_encargado_grupo"))
            {
                this.ActivaControlConfig(false);}
            BtnGuardarNuevaConfig.Enabled = false;
        }

        #endregion

        /***********************************************
         *
         *
         *  METODOS DE LLAMADAS DE DATOS
         *
         *
         ***********************************************/
        #region MetodosDatos

        private bool CargarDatosParametro(string parametro)
        {
            bool resultado;
            var miConsulta = dbContext.PARAMETROS
                .FirstOrDefault(param => param.Parametro == parametro);
            miEntidadParametros = miConsulta;
            if (miConsulta != null)
            {
                groupBoxControlConfig.Text = miEntidadParametros.Descripcion;
                resultado = true;
                var miConfigActiva = dbContext.CONFIGURACION
                    .FirstOrDefault(configuracion =>
                        configuracion.Activo == true && configuracion.Parametro == parametro);
                if (miConfigActiva != null)
                {
                    miEntidadConfiguracion = miConfigActiva;
                    controlConfiguraParametro.cONFIGURACIONBindingSource.DataSource = miEntidadConfiguracion;
                }
                else
                {
                    miEntidadConfiguracion = new EntidadCONFIGURACION();
                    miEntidadConfiguracion = null;
                    
                    groupBoxControlConfig.Text = parametro + " No tiene una configuración.";
                }

                ActivarBtnCrearNuevaConfig();
                //controlConfiguraParametro.cONFIGURACIONBindingSource.DataSource = miEntidadParametros;

            }else
            {
                miEntidadConfiguracion = new EntidadCONFIGURACION();
                miEntidadConfiguracion = null;
                groupBoxControlConfig.Text = parametro + " No EXISTE EL PARAMETRO DE CONFIGURACION.";
                
                resultado = false;
                this.DesactivarBotonesConfig();
            }

            return resultado;
        }

        
        #endregion

    }
}
