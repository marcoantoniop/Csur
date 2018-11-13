namespace Csur.Presentacion.Admin
{
    partial class FrmAdminPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminPersonas));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pERSONABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnNuevaPersona = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBloquearPersonal = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAdminCuenta = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnNuevaPersona,
            this.BtnBloquearPersonal,
            this.BtnAdminCuenta});
            this.ribbon.MaxItemId = 7;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pERSONABindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(659, 359);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pERSONABindingSource
            // 
            this.pERSONABindingSource.DataSource = typeof(Csur.Datos.EntidadPERSONA);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre,
            this.colApellido,
            this.colTelefono,
            this.colDireccion,
            this.colTipo,
            this.colNombreUsuario,
            this.colEstado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTipo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 112;
            // 
            // colApellido
            // 
            this.colApellido.FieldName = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 2;
            this.colApellido.Width = 105;
            // 
            // colTelefono
            // 
            this.colTelefono.Caption = "Teléfono";
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 3;
            // 
            // colDireccion
            // 
            this.colDireccion.Caption = "Dirección";
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 5;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 4;
            // 
            // colNombreUsuario
            // 
            this.colNombreUsuario.FieldName = "NombreUsuario";
            this.colNombreUsuario.Name = "colNombreUsuario";
            this.colNombreUsuario.Visible = true;
            this.colNombreUsuario.VisibleIndex = 0;
            this.colNombreUsuario.Width = 114;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 4;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnNuevaPersona);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnBloquearPersonal);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnAdminCuenta);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Operaciones";
            // 
            // BtnNuevaPersona
            // 
            this.BtnNuevaPersona.Caption = "Agregar Nuevo Personal";
            this.BtnNuevaPersona.Id = 4;
            this.BtnNuevaPersona.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevaPersona.ImageOptions.Image")));
            this.BtnNuevaPersona.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnNuevaPersona.ImageOptions.LargeImage")));
            this.BtnNuevaPersona.Name = "BtnNuevaPersona";
            this.BtnNuevaPersona.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNuevaPersona_ItemClick);
            // 
            // BtnBloquearPersonal
            // 
            this.BtnBloquearPersonal.Caption = "Bloquear / Desbloquear";
            this.BtnBloquearPersonal.Id = 5;
            this.BtnBloquearPersonal.ImageOptions.LargeImage = global::Csur.Properties.Resources.ico_persona_lock;
            this.BtnBloquearPersonal.Name = "BtnBloquearPersonal";
            // 
            // BtnAdminCuenta
            // 
            this.BtnAdminCuenta.Caption = "Administrar Cuenta Bancaria";
            this.BtnAdminCuenta.Id = 6;
            this.BtnAdminCuenta.ImageOptions.LargeImage = global::Csur.Properties.Resources.ico_persona_cuenta;
            this.BtnAdminCuenta.Name = "BtnAdminCuenta";
            // 
            // FrmAdminPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(659, 533);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmAdminPersonas";
            this.Text = "Administrar Personal y Socios";
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.ribbonStatusBar, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource pERSONABindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraBars.BarButtonItem BtnNuevaPersona;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem BtnBloquearPersonal;
        private DevExpress.XtraBars.BarButtonItem BtnAdminCuenta;
    }
}
