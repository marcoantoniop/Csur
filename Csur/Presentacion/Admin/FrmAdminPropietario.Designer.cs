namespace Csur.Presentacion.Admin
{
    partial class FrmAdminPropietario
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
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement2 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement3 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement4 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminPropietario));
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.lOTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFaseNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManzanoNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLatitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLongitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROPIETARIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.listBoxControlPersona = new DevExpress.XtraEditors.ListBoxControl();
            this.pERSONABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.pRopietarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnCuentas = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRopietarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnCuentas});
            this.ribbon.MaxItemId = 5;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnCuentas);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Cuenta";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.lOTEBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(530, 359);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // lOTEBindingSource
            // 
            this.lOTEBindingSource.DataSource = typeof(Csur.Datos.EntidadLOTE);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFaseNombre,
            this.colManzanoNum,
            this.colIdLote,
            this.colNombreLote,
            this.colCodigo,
            this.colLatitud,
            this.colLongitud,
            this.colArea,
            this.colEstado,
            this.colPrecio,
            this.colPROPIETARIO,
            this.colIdPersona});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Precio", null, "(Precio: SUMA={0:#.##})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFaseNombre, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colManzanoNum, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // colFaseNombre
            // 
            this.colFaseNombre.Caption = "Fase";
            this.colFaseNombre.FieldName = "MANZANO.FASE.NombreFase";
            this.colFaseNombre.Name = "colFaseNombre";
            this.colFaseNombre.Visible = true;
            this.colFaseNombre.VisibleIndex = 1;
            // 
            // colManzanoNum
            // 
            this.colManzanoNum.Caption = "Num. Manzano";
            this.colManzanoNum.FieldName = "MANZANO.NumManzano";
            this.colManzanoNum.Name = "colManzanoNum";
            this.colManzanoNum.Visible = true;
            this.colManzanoNum.VisibleIndex = 0;
            // 
            // colIdLote
            // 
            this.colIdLote.FieldName = "IdLote";
            this.colIdLote.Name = "colIdLote";
            this.colIdLote.Visible = true;
            this.colIdLote.VisibleIndex = 7;
            // 
            // colNombreLote
            // 
            this.colNombreLote.FieldName = "NombreLote";
            this.colNombreLote.Name = "colNombreLote";
            this.colNombreLote.Visible = true;
            this.colNombreLote.VisibleIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 1;
            // 
            // colLatitud
            // 
            this.colLatitud.FieldName = "Latitud";
            this.colLatitud.Name = "colLatitud";
            this.colLatitud.Visible = true;
            this.colLatitud.VisibleIndex = 2;
            // 
            // colLongitud
            // 
            this.colLongitud.FieldName = "Longitud";
            this.colLongitud.Name = "colLongitud";
            this.colLongitud.Visible = true;
            this.colLongitud.VisibleIndex = 3;
            // 
            // colArea
            // 
            this.colArea.FieldName = "Area";
            this.colArea.Name = "colArea";
            this.colArea.Visible = true;
            this.colArea.VisibleIndex = 4;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 5;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 6;
            // 
            // colPROPIETARIO
            // 
            this.colPROPIETARIO.FieldName = "PROPIETARIO";
            this.colPROPIETARIO.Name = "colPROPIETARIO";
            this.colPROPIETARIO.Visible = true;
            this.colPROPIETARIO.VisibleIndex = 8;
            // 
            // colIdPersona
            // 
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            this.colIdPersona.Visible = true;
            this.colIdPersona.VisibleIndex = 9;
            // 
            // listBoxControlPersona
            // 
            this.listBoxControlPersona.DataSource = this.pERSONABindingSource;
            this.listBoxControlPersona.DisplayMember = "Apellido";
            this.listBoxControlPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControlPersona.ItemHeight = 58;
            this.listBoxControlPersona.Location = new System.Drawing.Point(0, 0);
            this.listBoxControlPersona.Name = "listBoxControlPersona";
            this.listBoxControlPersona.Size = new System.Drawing.Size(124, 359);
            this.listBoxControlPersona.TabIndex = 4;
            itemTemplateBase1.Columns.Add(tableColumnDefinition1);
            itemTemplateBase1.Columns.Add(tableColumnDefinition2);
            templatedItemElement1.FieldName = "NombreUsuario";
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement1.Text = "NombreUsuario";
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ColumnIndex = 1;
            templatedItemElement2.FieldName = "Telefono";
            templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement2.Text = "Telefono";
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement3.FieldName = "Nombre";
            templatedItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement3.RowIndex = 1;
            templatedItemElement3.Text = "Nombre";
            templatedItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement4.ColumnIndex = 1;
            templatedItemElement4.FieldName = "Apellido";
            templatedItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement4.RowIndex = 1;
            templatedItemElement4.Text = "Apellido";
            templatedItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            itemTemplateBase1.Elements.Add(templatedItemElement1);
            itemTemplateBase1.Elements.Add(templatedItemElement2);
            itemTemplateBase1.Elements.Add(templatedItemElement3);
            itemTemplateBase1.Elements.Add(templatedItemElement4);
            itemTemplateBase1.Name = "templatePersona";
            itemTemplateBase1.Rows.Add(tableRowDefinition1);
            itemTemplateBase1.Rows.Add(tableRowDefinition2);
            this.listBoxControlPersona.Templates.Add(itemTemplateBase1);
            this.listBoxControlPersona.ValueMember = "IdPersona";
            this.listBoxControlPersona.SelectedIndexChanged += new System.EventHandler(this.listBoxControlPersona_SelectedIndexChanged);
            // 
            // pERSONABindingSource
            // 
            this.pERSONABindingSource.DataSource = typeof(Csur.Datos.EntidadPERSONA);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 143);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.listBoxControlPersona);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(659, 359);
            this.splitContainerControl1.SplitterPosition = 124;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // pRopietarioBindingSource
            // 
            this.pRopietarioBindingSource.DataSource = typeof(Csur.Datos.EntidadPROPIETARIO);
            // 
            // BtnCuentas
            // 
            this.BtnCuentas.Caption = "Editar o modificar cuenta";
            this.BtnCuentas.Id = 4;
            this.BtnCuentas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCuentas.ImageOptions.Image")));
            this.BtnCuentas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnCuentas.ImageOptions.LargeImage")));
            this.BtnCuentas.Name = "BtnCuentas";
            this.BtnCuentas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCuentas_ItemClick);
            // 
            // FrmAdminPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(659, 533);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmAdminPropietario";
            this.Text = "ADMINISTRAR PROPIETARIOS";
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.ribbonStatusBar, 0);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pRopietarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlPersona;
        private System.Windows.Forms.BindingSource pERSONABindingSource;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.BindingSource lOTEBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFaseNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colManzanoNum;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreLote;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colLatitud;
        private DevExpress.XtraGrid.Columns.GridColumn colLongitud;
        private DevExpress.XtraGrid.Columns.GridColumn colArea;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLote;
        private System.Windows.Forms.BindingSource pRopietarioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPROPIETARIO;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraBars.BarButtonItem BtnCuentas;
    }
}
