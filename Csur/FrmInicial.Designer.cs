namespace Csur
{
    partial class FrmInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Csur.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.btnCerrarSesion = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAdminTerrenos = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAdminCliente = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAdminUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.BtnNuevaVenta = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAdminPropietario = new DevExpress.XtraBars.BarButtonItem();
            this.BtnConfigAvanzada = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPPrincipal = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonGInicial = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGRapidos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPConfig = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPTerrenos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPPersonal = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPCliente = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPReportes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPTransacciones = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonGTransacciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.openStreetMapDataProvider1 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 1500;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnSalir,
            this.btnCerrarSesion,
            this.BtnAdminTerrenos,
            this.BtnAdminCliente,
            this.BtnAdminUsuario,
            this.BtnNuevaVenta,
            this.BtnAdminPropietario,
            this.BtnConfigAvanzada});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPPrincipal,
            this.ribbonPConfig,
            this.ribbonPReportes,
            this.ribbonPTransacciones});
            this.ribbonControl1.Size = new System.Drawing.Size(785, 143);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 1;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Caption = "Cerrar Sesión";
            this.btnCerrarSesion.Id = 2;
            this.btnCerrarSesion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.ImageOptions.Image")));
            this.btnCerrarSesion.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.ImageOptions.LargeImage")));
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            // 
            // BtnAdminTerrenos
            // 
            this.BtnAdminTerrenos.Caption = "Admin. Terrenos";
            this.BtnAdminTerrenos.Id = 3;
            this.BtnAdminTerrenos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdminTerrenos.ImageOptions.Image")));
            this.BtnAdminTerrenos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAdminTerrenos.ImageOptions.LargeImage")));
            this.BtnAdminTerrenos.Name = "BtnAdminTerrenos";
            this.BtnAdminTerrenos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAdminTerrenos_ItemClick);
            // 
            // BtnAdminCliente
            // 
            this.BtnAdminCliente.Caption = "Admin. Clientes";
            this.BtnAdminCliente.Id = 4;
            this.BtnAdminCliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdminCliente.ImageOptions.Image")));
            this.BtnAdminCliente.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAdminCliente.ImageOptions.LargeImage")));
            this.BtnAdminCliente.Name = "BtnAdminCliente";
            // 
            // BtnAdminUsuario
            // 
            this.BtnAdminUsuario.Caption = "Admin. Socios y Personal";
            this.BtnAdminUsuario.Id = 5;
            this.BtnAdminUsuario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdminUsuario.ImageOptions.Image")));
            this.BtnAdminUsuario.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAdminUsuario.ImageOptions.LargeImage")));
            this.BtnAdminUsuario.Name = "BtnAdminUsuario";
            this.BtnAdminUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAdminUsuario_ItemClick);
            // 
            // BtnNuevaVenta
            // 
            this.BtnNuevaVenta.Caption = "Registrar nueva Venta";
            this.BtnNuevaVenta.Id = 6;
            this.BtnNuevaVenta.ImageOptions.Image = global::Csur.Properties.Resources.ico_venta;
            this.BtnNuevaVenta.ImageOptions.LargeImage = global::Csur.Properties.Resources.ico_venta;
            this.BtnNuevaVenta.Name = "BtnNuevaVenta";
            this.BtnNuevaVenta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNuevaVenta_ItemClick);
            // 
            // BtnAdminPropietario
            // 
            this.BtnAdminPropietario.Caption = "Admin. Propietarios de Terrenos";
            this.BtnAdminPropietario.Id = 7;
            this.BtnAdminPropietario.ImageOptions.LargeImage = global::Csur.Properties.Resources.ico_propietario;
            this.BtnAdminPropietario.Name = "BtnAdminPropietario";
            this.BtnAdminPropietario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAdminPropietario_ItemClick);
            // 
            // BtnConfigAvanzada
            // 
            this.BtnConfigAvanzada.Caption = "Configuración Avanzada";
            this.BtnConfigAvanzada.Id = 8;
            this.BtnConfigAvanzada.ImageOptions.LargeImage = global::Csur.Properties.Resources.ico_config;
            this.BtnConfigAvanzada.Name = "BtnConfigAvanzada";
            this.BtnConfigAvanzada.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnConfigAvanzada_ItemClick);
            // 
            // ribbonPPrincipal
            // 
            this.ribbonPPrincipal.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonGInicial,
            this.ribbonGRapidos});
            this.ribbonPPrincipal.Name = "ribbonPPrincipal";
            this.ribbonPPrincipal.Text = "Principal";
            // 
            // ribbonGInicial
            // 
            this.ribbonGInicial.ItemLinks.Add(this.btnSalir);
            this.ribbonGInicial.ItemLinks.Add(this.btnCerrarSesion);
            this.ribbonGInicial.Name = "ribbonGInicial";
            this.ribbonGInicial.Text = "Inicial";
            // 
            // ribbonGRapidos
            // 
            this.ribbonGRapidos.ItemLinks.Add(this.BtnNuevaVenta);
            this.ribbonGRapidos.Name = "ribbonGRapidos";
            this.ribbonGRapidos.Text = "Accesos Rápidos";
            // 
            // ribbonPConfig
            // 
            this.ribbonPConfig.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPTerrenos,
            this.ribbonPPersonal,
            this.ribbonPCliente,
            this.ribbonPageGroup1});
            this.ribbonPConfig.Name = "ribbonPConfig";
            this.ribbonPConfig.Text = "Configuración";
            // 
            // ribbonPTerrenos
            // 
            this.ribbonPTerrenos.ItemLinks.Add(this.BtnAdminTerrenos);
            this.ribbonPTerrenos.ItemLinks.Add(this.BtnAdminPropietario);
            this.ribbonPTerrenos.Name = "ribbonPTerrenos";
            this.ribbonPTerrenos.Text = "Terrenos";
            // 
            // ribbonPPersonal
            // 
            this.ribbonPPersonal.ItemLinks.Add(this.BtnAdminUsuario);
            this.ribbonPPersonal.Name = "ribbonPPersonal";
            this.ribbonPPersonal.Text = "Personal";
            // 
            // ribbonPCliente
            // 
            this.ribbonPCliente.ItemLinks.Add(this.BtnAdminCliente);
            this.ribbonPCliente.Name = "ribbonPCliente";
            this.ribbonPCliente.Text = "Clientes";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnConfigAvanzada);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Avanzado";
            // 
            // ribbonPReportes
            // 
            this.ribbonPReportes.Name = "ribbonPReportes";
            this.ribbonPReportes.Text = "Reportes";
            // 
            // ribbonPTransacciones
            // 
            this.ribbonPTransacciones.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonGTransacciones});
            this.ribbonPTransacciones.Name = "ribbonPTransacciones";
            this.ribbonPTransacciones.Text = "Transacciones";
            // 
            // ribbonGTransacciones
            // 
            this.ribbonGTransacciones.ItemLinks.Add(this.BtnNuevaVenta);
            this.ribbonGTransacciones.Name = "ribbonGTransacciones";
            this.ribbonGTransacciones.Text = "General";
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 143);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(785, 389);
            this.mapControl1.TabIndex = 1;
            this.imageLayer1.DataProvider = this.openStreetMapDataProvider1;
            this.openStreetMapDataProvider1.TileUriTemplate = "http://{0}.tile.INSERT_SERVER_NAME.com/{1}/{2}/{3}.png";
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 532);
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicial";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIMIENTOS DE SUR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPPrincipal;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGInicial;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPConfig;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPReportes;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPTransacciones;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarButtonItem btnCerrarSesion;
        private DevExpress.XtraBars.BarButtonItem BtnAdminTerrenos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPTerrenos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPPersonal;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPCliente;
        private DevExpress.XtraBars.BarButtonItem BtnAdminCliente;
        private DevExpress.XtraBars.BarButtonItem BtnAdminUsuario;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider1;
        private DevExpress.XtraBars.BarButtonItem BtnNuevaVenta;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGRapidos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGTransacciones;
        private DevExpress.XtraBars.BarButtonItem BtnAdminPropietario;
        private DevExpress.XtraBars.BarButtonItem BtnConfigAvanzada;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}

