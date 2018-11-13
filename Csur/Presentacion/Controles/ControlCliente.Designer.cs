namespace Csur.Presentacion.Controles
{
    partial class ControlCliente
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
            this.NombreTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CiudadTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DireccionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TelefonoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CorreoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NombreUsuarioTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ClaveTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FechaNacimientoDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCorreo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCiudad = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForNombre = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCi = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFechaNacimiento = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup2 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForNombreUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForClave = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDireccion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTelefono = new DevExpress.XtraLayout.LayoutControlItem();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NombreTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudadTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DireccionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorreoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreUsuarioTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaNacimientoDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaNacimientoDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFechaNacimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombreUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AutoRetrieveFields = true;
            this.dataLayoutControl1.Controls.Add(this.NombreTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CiudadTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DireccionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TelefonoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CorreoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NombreUsuarioTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ClaveTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CiTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FechaNacimientoDateEdit);
            this.dataLayoutControl1.DataSource = this.cLIENTEBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(392, 285);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // NombreTextEdit
            // 
            this.NombreTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENTEBindingSource, "Nombre", true));
            this.NombreTextEdit.EnterMoveNextControl = true;
            this.NombreTextEdit.Location = new System.Drawing.Point(111, 46);
            this.NombreTextEdit.Name = "NombreTextEdit";
            this.NombreTextEdit.Size = new System.Drawing.Size(257, 20);
            this.NombreTextEdit.StyleController = this.dataLayoutControl1;
            this.NombreTextEdit.TabIndex = 4;
            // 
            // CiudadTextEdit
            // 
            this.CiudadTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENTEBindingSource, "Ciudad", true));
            this.CiudadTextEdit.EnterMoveNextControl = true;
            this.CiudadTextEdit.Location = new System.Drawing.Point(99, 106);
            this.CiudadTextEdit.Name = "CiudadTextEdit";
            this.CiudadTextEdit.Size = new System.Drawing.Size(281, 20);
            this.CiudadTextEdit.StyleController = this.dataLayoutControl1;
            this.CiudadTextEdit.TabIndex = 5;
            // 
            // DireccionTextEdit
            // 
            this.DireccionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENTEBindingSource, "Direccion", true));
            this.DireccionTextEdit.EnterMoveNextControl = true;
            this.DireccionTextEdit.Location = new System.Drawing.Point(99, 154);
            this.DireccionTextEdit.Name = "DireccionTextEdit";
            this.DireccionTextEdit.Size = new System.Drawing.Size(281, 20);
            this.DireccionTextEdit.StyleController = this.dataLayoutControl1;
            this.DireccionTextEdit.TabIndex = 6;
            // 
            // TelefonoTextEdit
            // 
            this.TelefonoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENTEBindingSource, "Telefono", true));
            this.TelefonoTextEdit.EnterMoveNextControl = true;
            this.TelefonoTextEdit.Location = new System.Drawing.Point(285, 130);
            this.TelefonoTextEdit.Name = "TelefonoTextEdit";
            this.TelefonoTextEdit.Size = new System.Drawing.Size(95, 20);
            this.TelefonoTextEdit.StyleController = this.dataLayoutControl1;
            this.TelefonoTextEdit.TabIndex = 7;
            // 
            // CorreoTextEdit
            // 
            this.CorreoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENTEBindingSource, "Correo", true));
            this.CorreoTextEdit.EnterMoveNextControl = true;
            this.CorreoTextEdit.Location = new System.Drawing.Point(99, 130);
            this.CorreoTextEdit.Name = "CorreoTextEdit";
            this.CorreoTextEdit.Size = new System.Drawing.Size(95, 20);
            this.CorreoTextEdit.StyleController = this.dataLayoutControl1;
            this.CorreoTextEdit.TabIndex = 8;
            // 
            // NombreUsuarioTextEdit
            // 
            this.NombreUsuarioTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENTEBindingSource, "NombreUsuario", true));
            this.NombreUsuarioTextEdit.EnterMoveNextControl = true;
            this.NombreUsuarioTextEdit.Location = new System.Drawing.Point(111, 212);
            this.NombreUsuarioTextEdit.Name = "NombreUsuarioTextEdit";
            this.NombreUsuarioTextEdit.Size = new System.Drawing.Size(257, 20);
            this.NombreUsuarioTextEdit.StyleController = this.dataLayoutControl1;
            this.NombreUsuarioTextEdit.TabIndex = 9;
            // 
            // ClaveTextEdit
            // 
            this.ClaveTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENTEBindingSource, "Clave", true));
            this.ClaveTextEdit.EnterMoveNextControl = true;
            this.ClaveTextEdit.Location = new System.Drawing.Point(111, 236);
            this.ClaveTextEdit.Name = "ClaveTextEdit";
            this.ClaveTextEdit.Size = new System.Drawing.Size(257, 20);
            this.ClaveTextEdit.StyleController = this.dataLayoutControl1;
            this.ClaveTextEdit.TabIndex = 10;
            // 
            // CiTextEdit
            // 
            this.CiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENTEBindingSource, "Ci", true));
            this.CiTextEdit.EnterMoveNextControl = true;
            this.CiTextEdit.Location = new System.Drawing.Point(111, 70);
            this.CiTextEdit.Name = "CiTextEdit";
            this.CiTextEdit.Size = new System.Drawing.Size(75, 20);
            this.CiTextEdit.StyleController = this.dataLayoutControl1;
            this.CiTextEdit.TabIndex = 11;
            // 
            // FechaNacimientoDateEdit
            // 
            this.FechaNacimientoDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENTEBindingSource, "FechaNacimiento", true));
            this.FechaNacimientoDateEdit.EditValue = null;
            this.FechaNacimientoDateEdit.EnterMoveNextControl = true;
            this.FechaNacimientoDateEdit.Location = new System.Drawing.Point(277, 70);
            this.FechaNacimientoDateEdit.Name = "FechaNacimientoDateEdit";
            this.FechaNacimientoDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.FechaNacimientoDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaNacimientoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaNacimientoDateEdit.Size = new System.Drawing.Size(91, 20);
            this.FechaNacimientoDateEdit.StyleController = this.dataLayoutControl1;
            this.FechaNacimientoDateEdit.TabIndex = 12;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(392, 285);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCorreo,
            this.ItemForCiudad,
            this.tabbedControlGroup1,
            this.tabbedControlGroup2,
            this.ItemForDireccion,
            this.ItemForTelefono});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(372, 265);
            // 
            // ItemForCorreo
            // 
            this.ItemForCorreo.Control = this.CorreoTextEdit;
            this.ItemForCorreo.Location = new System.Drawing.Point(0, 118);
            this.ItemForCorreo.Name = "ItemForCorreo";
            this.ItemForCorreo.Size = new System.Drawing.Size(186, 24);
            this.ItemForCorreo.Text = "Correo";
            this.ItemForCorreo.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForCiudad
            // 
            this.ItemForCiudad.Control = this.CiudadTextEdit;
            this.ItemForCiudad.Location = new System.Drawing.Point(0, 94);
            this.ItemForCiudad.Name = "ItemForCiudad";
            this.ItemForCiudad.Size = new System.Drawing.Size(372, 24);
            this.ItemForCiudad.Text = "Ciudad";
            this.ItemForCiudad.TextSize = new System.Drawing.Size(84, 13);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.CustomizationFormText = "Dator Personales";
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup3;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(372, 94);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForNombre,
            this.ItemForCi,
            this.ItemForFechaNacimiento});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(348, 48);
            this.layoutControlGroup3.Text = "Datos personales";
            // 
            // ItemForNombre
            // 
            this.ItemForNombre.Control = this.NombreTextEdit;
            this.ItemForNombre.Location = new System.Drawing.Point(0, 0);
            this.ItemForNombre.Name = "ItemForNombre";
            this.ItemForNombre.Size = new System.Drawing.Size(348, 24);
            this.ItemForNombre.Text = "Nombre";
            this.ItemForNombre.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForCi
            // 
            this.ItemForCi.Control = this.CiTextEdit;
            this.ItemForCi.Location = new System.Drawing.Point(0, 24);
            this.ItemForCi.Name = "ItemForCi";
            this.ItemForCi.Size = new System.Drawing.Size(166, 24);
            this.ItemForCi.Text = "Ci";
            this.ItemForCi.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForFechaNacimiento
            // 
            this.ItemForFechaNacimiento.Control = this.FechaNacimientoDateEdit;
            this.ItemForFechaNacimiento.Location = new System.Drawing.Point(166, 24);
            this.ItemForFechaNacimiento.Name = "ItemForFechaNacimiento";
            this.ItemForFechaNacimiento.Size = new System.Drawing.Size(182, 24);
            this.ItemForFechaNacimiento.Text = "Fecha Nacimiento";
            this.ItemForFechaNacimiento.TextSize = new System.Drawing.Size(84, 13);
            // 
            // tabbedControlGroup2
            // 
            this.tabbedControlGroup2.Location = new System.Drawing.Point(0, 166);
            this.tabbedControlGroup2.Name = "tabbedControlGroup2";
            this.tabbedControlGroup2.SelectedTabPage = this.layoutControlGroup4;
            this.tabbedControlGroup2.SelectedTabPageIndex = 0;
            this.tabbedControlGroup2.Size = new System.Drawing.Size(372, 99);
            this.tabbedControlGroup2.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4});
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForNombreUsuario,
            this.ItemForClave});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(348, 53);
            this.layoutControlGroup4.Text = "Para acceso desde Android o Internet";
            // 
            // ItemForNombreUsuario
            // 
            this.ItemForNombreUsuario.Control = this.NombreUsuarioTextEdit;
            this.ItemForNombreUsuario.Location = new System.Drawing.Point(0, 0);
            this.ItemForNombreUsuario.Name = "ItemForNombreUsuario";
            this.ItemForNombreUsuario.Size = new System.Drawing.Size(348, 24);
            this.ItemForNombreUsuario.Text = "Nombre Usuario";
            this.ItemForNombreUsuario.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForClave
            // 
            this.ItemForClave.Control = this.ClaveTextEdit;
            this.ItemForClave.Location = new System.Drawing.Point(0, 24);
            this.ItemForClave.Name = "ItemForClave";
            this.ItemForClave.Size = new System.Drawing.Size(348, 29);
            this.ItemForClave.Text = "Clave";
            this.ItemForClave.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForDireccion
            // 
            this.ItemForDireccion.Control = this.DireccionTextEdit;
            this.ItemForDireccion.Location = new System.Drawing.Point(0, 142);
            this.ItemForDireccion.Name = "ItemForDireccion";
            this.ItemForDireccion.Size = new System.Drawing.Size(372, 24);
            this.ItemForDireccion.Text = "Direccion";
            this.ItemForDireccion.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForTelefono
            // 
            this.ItemForTelefono.Control = this.TelefonoTextEdit;
            this.ItemForTelefono.Location = new System.Drawing.Point(186, 118);
            this.ItemForTelefono.Name = "ItemForTelefono";
            this.ItemForTelefono.Size = new System.Drawing.Size(186, 24);
            this.ItemForTelefono.Text = "Telefono";
            this.ItemForTelefono.TextSize = new System.Drawing.Size(84, 13);
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataSource = typeof(Csur.Datos.EntidadCLIENTE);
            // 
            // ControlCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "ControlCliente";
            this.Size = new System.Drawing.Size(392, 285);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NombreTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudadTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DireccionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorreoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreUsuarioTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaNacimientoDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaNacimientoDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFechaNacimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombreUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDireccion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCorreo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCiudad;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelefono;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNombre;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCi;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFechaNacimiento;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNombreUsuario;
        private DevExpress.XtraLayout.LayoutControlItem ItemForClave;
        public DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        public System.Windows.Forms.BindingSource cLIENTEBindingSource;
        public DevExpress.XtraEditors.TextEdit NombreTextEdit;
        public DevExpress.XtraEditors.TextEdit CiudadTextEdit;
        public DevExpress.XtraEditors.TextEdit DireccionTextEdit;
        public DevExpress.XtraEditors.TextEdit TelefonoTextEdit;
        public DevExpress.XtraEditors.TextEdit CorreoTextEdit;
        public DevExpress.XtraEditors.TextEdit NombreUsuarioTextEdit;
        public DevExpress.XtraEditors.TextEdit ClaveTextEdit;
        public DevExpress.XtraEditors.TextEdit CiTextEdit;
        public DevExpress.XtraEditors.DateEdit FechaNacimientoDateEdit;
    }
}
