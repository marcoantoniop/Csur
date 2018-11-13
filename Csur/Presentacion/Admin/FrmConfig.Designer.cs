namespace Csur.Presentacion.Admin
{
    partial class FrmConfig
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.navBarControlConfig = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupComisiones = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemComisionIndependiente = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemComisionPromotor = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemAsalariadoEncGrupo = new DevExpress.XtraNavBar.NavBarItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGuardarNuevaConfig = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNuevaConfig = new DevExpress.XtraEditors.SimpleButton();
            this.groupBoxControlConfig = new System.Windows.Forms.GroupBox();
            this.controlConfiguraParametro = new Csur.Presentacion.Controles.ControlConfiguraParam();
            this.parametrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlConfig)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxControlConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            // 
            // navBarControlConfig
            // 
            this.navBarControlConfig.ActiveGroup = this.navBarGroupComisiones;
            this.navBarControlConfig.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControlConfig.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupComisiones});
            this.navBarControlConfig.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemComisionIndependiente,
            this.navBarItemComisionPromotor,
            this.navBarItemAsalariadoEncGrupo});
            this.navBarControlConfig.Location = new System.Drawing.Point(0, 143);
            this.navBarControlConfig.Name = "navBarControlConfig";
            this.navBarControlConfig.OptionsNavPane.ExpandedWidth = 158;
            this.navBarControlConfig.Size = new System.Drawing.Size(158, 359);
            this.navBarControlConfig.TabIndex = 2;
            this.navBarControlConfig.View = new DevExpress.XtraNavBar.ViewInfo.ExplorerBarViewInfoRegistrator();
            // 
            // navBarGroupComisiones
            // 
            this.navBarGroupComisiones.Caption = "Comisiones";
            this.navBarGroupComisiones.Expanded = true;
            this.navBarGroupComisiones.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemComisionIndependiente),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemComisionPromotor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemAsalariadoEncGrupo)});
            this.navBarGroupComisiones.Name = "navBarGroupComisiones";
            // 
            // navBarItemComisionIndependiente
            // 
            this.navBarItemComisionIndependiente.Caption = "Independientes";
            this.navBarItemComisionIndependiente.ImageOptions.LargeImage = global::Csur.Properties.Resources.ico_commission_ind;
            this.navBarItemComisionIndependiente.ImageOptions.SmallImage = global::Csur.Properties.Resources.ico_commission_ind;
            this.navBarItemComisionIndependiente.Name = "navBarItemComisionIndependiente";
            this.navBarItemComisionIndependiente.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemComisionIndependiente_LinkClicked);
            // 
            // navBarItemComisionPromotor
            // 
            this.navBarItemComisionPromotor.Caption = "Asalariado Promotor";
            this.navBarItemComisionPromotor.ImageOptions.LargeImage = global::Csur.Properties.Resources.ico_commission;
            this.navBarItemComisionPromotor.ImageOptions.SmallImage = global::Csur.Properties.Resources.ico_commission;
            this.navBarItemComisionPromotor.Name = "navBarItemComisionPromotor";
            this.navBarItemComisionPromotor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemComisionPromotor_LinkClicked);
            // 
            // navBarItemAsalariadoEncGrupo
            // 
            this.navBarItemAsalariadoEncGrupo.Caption = "Asalariado Encargado de Grupo";
            this.navBarItemAsalariadoEncGrupo.ImageOptions.LargeImage = global::Csur.Properties.Resources.ico_commission_varios;
            this.navBarItemAsalariadoEncGrupo.ImageOptions.SmallImage = global::Csur.Properties.Resources.ico_commission_varios;
            this.navBarItemAsalariadoEncGrupo.Name = "navBarItemAsalariadoEncGrupo";
            this.navBarItemAsalariadoEncGrupo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemAsalariadoEncGrupo_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnGuardarNuevaConfig);
            this.panel1.Controls.Add(this.BtnNuevaConfig);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(158, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 100);
            this.panel1.TabIndex = 4;
            // 
            // BtnGuardarNuevaConfig
            // 
            this.BtnGuardarNuevaConfig.ImageOptions.Image = global::Csur.Properties.Resources.icon_config_save;
            this.BtnGuardarNuevaConfig.Location = new System.Drawing.Point(283, 15);
            this.BtnGuardarNuevaConfig.Name = "BtnGuardarNuevaConfig";
            this.BtnGuardarNuevaConfig.Size = new System.Drawing.Size(159, 68);
            this.BtnGuardarNuevaConfig.TabIndex = 1;
            this.BtnGuardarNuevaConfig.Text = "Guardar la nueva\r\nConfiguración";
            this.BtnGuardarNuevaConfig.Click += new System.EventHandler(this.BtnGuardarNuevaConfig_Click);
            // 
            // BtnNuevaConfig
            // 
            this.BtnNuevaConfig.ImageOptions.Image = global::Csur.Properties.Resources.icon_config_new;
            this.BtnNuevaConfig.Location = new System.Drawing.Point(54, 15);
            this.BtnNuevaConfig.Name = "BtnNuevaConfig";
            this.BtnNuevaConfig.Size = new System.Drawing.Size(162, 68);
            this.BtnNuevaConfig.TabIndex = 0;
            this.BtnNuevaConfig.Text = "Crear nueva\r\nconfiguración";
            this.BtnNuevaConfig.Click += new System.EventHandler(this.BtnNuevaConfig_Click);
            // 
            // groupBoxControlConfig
            // 
            this.groupBoxControlConfig.Controls.Add(this.controlConfiguraParametro);
            this.groupBoxControlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxControlConfig.Location = new System.Drawing.Point(158, 143);
            this.groupBoxControlConfig.Name = "groupBoxControlConfig";
            this.groupBoxControlConfig.Size = new System.Drawing.Size(501, 259);
            this.groupBoxControlConfig.TabIndex = 5;
            this.groupBoxControlConfig.TabStop = false;
            this.groupBoxControlConfig.Text = "Valores de configuración";
            // 
            // controlConfiguraParametro
            // 
            this.controlConfiguraParametro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlConfiguraParametro.Location = new System.Drawing.Point(3, 17);
            this.controlConfiguraParametro.Name = "controlConfiguraParametro";
            this.controlConfiguraParametro.Size = new System.Drawing.Size(495, 239);
            this.controlConfiguraParametro.TabIndex = 0;
            // 
            // parametrosBindingSource
            // 
            this.parametrosBindingSource.DataSource = typeof(Csur.Datos.EntidadPARAMETROS);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(659, 533);
            this.Controls.Add(this.groupBoxControlConfig);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navBarControlConfig);
            this.Name = "FrmConfig";
            this.Text = "Configuración Avanzada";
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.ribbonStatusBar, 0);
            this.Controls.SetChildIndex(this.navBarControlConfig, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBoxControlConfig, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlConfig)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxControlConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parametrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControlConfig;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupComisiones;
        private DevExpress.XtraNavBar.NavBarItem navBarItemComisionIndependiente;
        private DevExpress.XtraNavBar.NavBarItem navBarItemComisionPromotor;
        private DevExpress.XtraNavBar.NavBarItem navBarItemAsalariadoEncGrupo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxControlConfig;
        private Controles.ControlConfiguraParam controlConfiguraParametro;
        private DevExpress.XtraEditors.SimpleButton BtnGuardarNuevaConfig;
        private DevExpress.XtraEditors.SimpleButton BtnNuevaConfig;
        private System.Windows.Forms.BindingSource parametrosBindingSource;
    }
}
