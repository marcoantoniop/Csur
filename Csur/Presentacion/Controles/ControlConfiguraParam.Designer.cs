namespace Csur.Presentacion.Controles
{
    partial class ControlConfiguraParam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cONFIGURACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.FechaDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.ParametroTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForParametro = new DevExpress.XtraLayout.LayoutControlItem();
            this.ValorATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForValorA = new DevExpress.XtraLayout.LayoutControlItem();
            this.ValorBTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForValorB = new DevExpress.XtraLayout.LayoutControlItem();
            this.ValorCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForValorC = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForObservacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ActivoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ItemForActivo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ObservacionTextEdit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONFIGURACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametroTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForParametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForValorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorBTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForValorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForValorC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForObservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacionTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.FechaDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ParametroTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ValorATextEdit);
            this.dataLayoutControl1.Controls.Add(this.ValorBTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ValorCTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ActivoCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.ObservacionTextEdit);
            this.dataLayoutControl1.DataSource = this.cONFIGURACIONBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(441, 252);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(441, 252);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // cONFIGURACIONBindingSource
            // 
            this.cONFIGURACIONBindingSource.DataSource = typeof(Csur.Datos.EntidadCONFIGURACION);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFecha,
            this.ItemForParametro,
            this.ItemForValorA,
            this.ItemForValorB,
            this.ItemForValorC,
            this.ItemForObservacion,
            this.ItemForActivo});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(421, 232);
            // 
            // FechaDateEdit
            // 
            this.FechaDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cONFIGURACIONBindingSource, "Fecha", true));
            this.FechaDateEdit.EditValue = null;
            this.FechaDateEdit.Enabled = false;
            this.FechaDateEdit.Location = new System.Drawing.Point(76, 12);
            this.FechaDateEdit.Name = "FechaDateEdit";
            this.FechaDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaDateEdit.Size = new System.Drawing.Size(142, 20);
            this.FechaDateEdit.StyleController = this.dataLayoutControl1;
            this.FechaDateEdit.TabIndex = 4;
            // 
            // ItemForFecha
            // 
            this.ItemForFecha.Control = this.FechaDateEdit;
            this.ItemForFecha.Location = new System.Drawing.Point(0, 0);
            this.ItemForFecha.Name = "ItemForFecha";
            this.ItemForFecha.Size = new System.Drawing.Size(210, 24);
            this.ItemForFecha.Text = "Fecha";
            this.ItemForFecha.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ParametroTextEdit
            // 
            this.ParametroTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cONFIGURACIONBindingSource, "Parametro", true));
            this.ParametroTextEdit.Location = new System.Drawing.Point(76, 36);
            this.ParametroTextEdit.Name = "ParametroTextEdit";
            this.ParametroTextEdit.Size = new System.Drawing.Size(353, 20);
            this.ParametroTextEdit.StyleController = this.dataLayoutControl1;
            this.ParametroTextEdit.TabIndex = 5;
            // 
            // ItemForParametro
            // 
            this.ItemForParametro.Control = this.ParametroTextEdit;
            this.ItemForParametro.Location = new System.Drawing.Point(0, 24);
            this.ItemForParametro.Name = "ItemForParametro";
            this.ItemForParametro.Size = new System.Drawing.Size(421, 24);
            this.ItemForParametro.Text = "Parametro";
            this.ItemForParametro.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ValorATextEdit
            // 
            this.ValorATextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cONFIGURACIONBindingSource, "ValorA", true));
            this.ValorATextEdit.Location = new System.Drawing.Point(76, 60);
            this.ValorATextEdit.Name = "ValorATextEdit";
            this.ValorATextEdit.Size = new System.Drawing.Size(353, 20);
            this.ValorATextEdit.StyleController = this.dataLayoutControl1;
            this.ValorATextEdit.TabIndex = 6;
            // 
            // ItemForValorA
            // 
            this.ItemForValorA.Control = this.ValorATextEdit;
            this.ItemForValorA.Location = new System.Drawing.Point(0, 48);
            this.ItemForValorA.Name = "ItemForValorA";
            this.ItemForValorA.Size = new System.Drawing.Size(421, 24);
            this.ItemForValorA.Text = "Valor A";
            this.ItemForValorA.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ValorBTextEdit
            // 
            this.ValorBTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cONFIGURACIONBindingSource, "ValorB", true));
            this.ValorBTextEdit.Location = new System.Drawing.Point(76, 84);
            this.ValorBTextEdit.Name = "ValorBTextEdit";
            this.ValorBTextEdit.Size = new System.Drawing.Size(353, 20);
            this.ValorBTextEdit.StyleController = this.dataLayoutControl1;
            this.ValorBTextEdit.TabIndex = 7;
            // 
            // ItemForValorB
            // 
            this.ItemForValorB.Control = this.ValorBTextEdit;
            this.ItemForValorB.Location = new System.Drawing.Point(0, 72);
            this.ItemForValorB.Name = "ItemForValorB";
            this.ItemForValorB.Size = new System.Drawing.Size(421, 24);
            this.ItemForValorB.Text = "Valor B";
            this.ItemForValorB.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ValorCTextEdit
            // 
            this.ValorCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cONFIGURACIONBindingSource, "ValorC", true));
            this.ValorCTextEdit.Location = new System.Drawing.Point(76, 108);
            this.ValorCTextEdit.Name = "ValorCTextEdit";
            this.ValorCTextEdit.Size = new System.Drawing.Size(353, 20);
            this.ValorCTextEdit.StyleController = this.dataLayoutControl1;
            this.ValorCTextEdit.TabIndex = 8;
            // 
            // ItemForValorC
            // 
            this.ItemForValorC.Control = this.ValorCTextEdit;
            this.ItemForValorC.Location = new System.Drawing.Point(0, 96);
            this.ItemForValorC.Name = "ItemForValorC";
            this.ItemForValorC.Size = new System.Drawing.Size(421, 24);
            this.ItemForValorC.Text = "Valor C";
            this.ItemForValorC.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForObservacion
            // 
            this.ItemForObservacion.Control = this.ObservacionTextEdit;
            this.ItemForObservacion.Location = new System.Drawing.Point(0, 120);
            this.ItemForObservacion.Name = "ItemForObservacion";
            this.ItemForObservacion.Size = new System.Drawing.Size(421, 112);
            this.ItemForObservacion.Text = "Observacion";
            this.ItemForObservacion.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ActivoCheckEdit
            // 
            this.ActivoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cONFIGURACIONBindingSource, "Activo", true));
            this.ActivoCheckEdit.Location = new System.Drawing.Point(222, 12);
            this.ActivoCheckEdit.Name = "ActivoCheckEdit";
            this.ActivoCheckEdit.Properties.Caption = "Activo";
            this.ActivoCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.ActivoCheckEdit.Size = new System.Drawing.Size(207, 19);
            this.ActivoCheckEdit.StyleController = this.dataLayoutControl1;
            this.ActivoCheckEdit.TabIndex = 10;
            // 
            // ItemForActivo
            // 
            this.ItemForActivo.Control = this.ActivoCheckEdit;
            this.ItemForActivo.Enabled = false;
            this.ItemForActivo.Location = new System.Drawing.Point(210, 0);
            this.ItemForActivo.Name = "ItemForActivo";
            this.ItemForActivo.Size = new System.Drawing.Size(211, 24);
            this.ItemForActivo.Text = "Activo";
            this.ItemForActivo.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForActivo.TextVisible = false;
            // 
            // ObservacionTextEdit
            // 
            this.ObservacionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cONFIGURACIONBindingSource, "Observacion", true));
            this.ObservacionTextEdit.Location = new System.Drawing.Point(76, 132);
            this.ObservacionTextEdit.Name = "ObservacionTextEdit";
            this.ObservacionTextEdit.Size = new System.Drawing.Size(353, 108);
            this.ObservacionTextEdit.StyleController = this.dataLayoutControl1;
            this.ObservacionTextEdit.TabIndex = 9;
            // 
            // ControlConfiguraParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "ControlConfiguraParam";
            this.Size = new System.Drawing.Size(441, 252);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONFIGURACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametroTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForParametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForValorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorBTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForValorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForValorC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForObservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacionTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit FechaDateEdit;
        private DevExpress.XtraEditors.TextEdit ParametroTextEdit;
        private DevExpress.XtraEditors.TextEdit ValorATextEdit;
        private DevExpress.XtraEditors.TextEdit ValorBTextEdit;
        private DevExpress.XtraEditors.TextEdit ValorCTextEdit;
        private DevExpress.XtraEditors.CheckEdit ActivoCheckEdit;
        private DevExpress.XtraEditors.MemoEdit ObservacionTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFecha;
        private DevExpress.XtraLayout.LayoutControlItem ItemForParametro;
        private DevExpress.XtraLayout.LayoutControlItem ItemForValorA;
        private DevExpress.XtraLayout.LayoutControlItem ItemForValorB;
        private DevExpress.XtraLayout.LayoutControlItem ItemForValorC;
        private DevExpress.XtraLayout.LayoutControlItem ItemForObservacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForActivo;
        public System.Windows.Forms.BindingSource cONFIGURACIONBindingSource;
    }
}
