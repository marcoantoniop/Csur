namespace Csur.Presentacion.Controles
{
    partial class ControlCuenta
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
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.BancoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForBanco = new DevExpress.XtraLayout.LayoutControlItem();
            this.Cuenta1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCuenta1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.FechaDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.txtSocio = new DevExpress.XtraLayout.SimpleLabelItem();
            this.entidadCUENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BancoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cuenta1TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCuenta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadCUENTABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.BancoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Cuenta1TextEdit);
            this.dataLayoutControl1.Controls.Add(this.FechaDateEdit);
            this.dataLayoutControl1.DataSource = this.entidadCUENTABindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(698, 158, 650, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(447, 122);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(447, 122);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBanco,
            this.ItemForCuenta1,
            this.ItemForFecha,
            this.simpleSeparator1,
            this.txtSocio});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(427, 102);
            // 
            // BancoTextEdit
            // 
            this.BancoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.entidadCUENTABindingSource, "Banco", true));
            this.BancoTextEdit.Location = new System.Drawing.Point(59, 37);
            this.BancoTextEdit.Name = "BancoTextEdit";
            this.BancoTextEdit.Size = new System.Drawing.Size(376, 20);
            this.BancoTextEdit.StyleController = this.dataLayoutControl1;
            this.BancoTextEdit.TabIndex = 5;
            // 
            // ItemForBanco
            // 
            this.ItemForBanco.Control = this.BancoTextEdit;
            this.ItemForBanco.Location = new System.Drawing.Point(0, 25);
            this.ItemForBanco.Name = "ItemForBanco";
            this.ItemForBanco.Size = new System.Drawing.Size(427, 24);
            this.ItemForBanco.Text = "Banco";
            this.ItemForBanco.TextSize = new System.Drawing.Size(43, 13);
            // 
            // Cuenta1TextEdit
            // 
            this.Cuenta1TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.entidadCUENTABindingSource, "Cuenta1", true));
            this.Cuenta1TextEdit.Location = new System.Drawing.Point(59, 61);
            this.Cuenta1TextEdit.Name = "Cuenta1TextEdit";
            this.Cuenta1TextEdit.Size = new System.Drawing.Size(376, 20);
            this.Cuenta1TextEdit.StyleController = this.dataLayoutControl1;
            this.Cuenta1TextEdit.TabIndex = 6;
            // 
            // ItemForCuenta1
            // 
            this.ItemForCuenta1.Control = this.Cuenta1TextEdit;
            this.ItemForCuenta1.Location = new System.Drawing.Point(0, 49);
            this.ItemForCuenta1.Name = "ItemForCuenta1";
            this.ItemForCuenta1.Size = new System.Drawing.Size(427, 24);
            this.ItemForCuenta1.Text = "Cuenta";
            this.ItemForCuenta1.TextSize = new System.Drawing.Size(43, 13);
            // 
            // FechaDateEdit
            // 
            this.FechaDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.entidadCUENTABindingSource, "Fecha", true));
            this.FechaDateEdit.EditValue = null;
            this.FechaDateEdit.Location = new System.Drawing.Point(59, 85);
            this.FechaDateEdit.Name = "FechaDateEdit";
            this.FechaDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.FechaDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaDateEdit.Size = new System.Drawing.Size(376, 20);
            this.FechaDateEdit.StyleController = this.dataLayoutControl1;
            this.FechaDateEdit.TabIndex = 7;
            // 
            // ItemForFecha
            // 
            this.ItemForFecha.Control = this.FechaDateEdit;
            this.ItemForFecha.Location = new System.Drawing.Point(0, 73);
            this.ItemForFecha.Name = "ItemForFecha";
            this.ItemForFecha.Size = new System.Drawing.Size(427, 29);
            this.ItemForFecha.Text = "Fecha";
            this.ItemForFecha.TextSize = new System.Drawing.Size(43, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 23);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(427, 2);
            // 
            // txtSocio
            // 
            this.txtSocio.AllowHotTrack = false;
            this.txtSocio.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSocio.AppearanceItemCaption.Options.UseFont = true;
            this.txtSocio.AppearanceItemCaption.Options.UseTextOptions = true;
            this.txtSocio.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSocio.Location = new System.Drawing.Point(0, 0);
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.Size = new System.Drawing.Size(427, 23);
            this.txtSocio.Text = "Socio";
            this.txtSocio.TextSize = new System.Drawing.Size(43, 19);
            // 
            // entidadCUENTABindingSource
            // 
            this.entidadCUENTABindingSource.DataSource = typeof(Csur.Datos.EntidadCUENTA);
            // 
            // ControlCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "ControlCuenta";
            this.Size = new System.Drawing.Size(447, 122);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BancoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cuenta1TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCuenta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadCUENTABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit BancoTextEdit;
        private DevExpress.XtraEditors.TextEdit Cuenta1TextEdit;
        private DevExpress.XtraEditors.DateEdit FechaDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBanco;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCuenta1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFecha;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        public DevExpress.XtraLayout.SimpleLabelItem txtSocio;
        public System.Windows.Forms.BindingSource entidadCUENTABindingSource;
    }
}
