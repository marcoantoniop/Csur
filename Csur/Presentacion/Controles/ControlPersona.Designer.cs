namespace Csur.Presentacion.Controles
{
    partial class ControlPersona
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
            this.pERSONABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.NombreTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForNombre = new DevExpress.XtraLayout.LayoutControlItem();
            this.ApellidoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForApellido = new DevExpress.XtraLayout.LayoutControlItem();
            this.TelefonoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForTelefono = new DevExpress.XtraLayout.LayoutControlItem();
            this.DireccionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForDireccion = new DevExpress.XtraLayout.LayoutControlItem();
            this.TipoRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.ItemForTipo = new DevExpress.XtraLayout.LayoutControlItem();
            this.NombreUsuarioTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForNombreUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.ClaveTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForClave = new DevExpress.XtraLayout.LayoutControlItem();
            this.EstadoRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.ItemForEstado = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApellidoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DireccionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreUsuarioTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombreUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadoRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.NombreTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ApellidoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TelefonoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DireccionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TipoRadioGroup);
            this.dataLayoutControl1.Controls.Add(this.NombreUsuarioTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ClaveTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EstadoRadioGroup);
            this.dataLayoutControl1.DataSource = this.pERSONABindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(402, 243);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(402, 243);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // pERSONABindingSource
            // 
            this.pERSONABindingSource.DataSource = typeof(Csur.Datos.EntidadPERSONA);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTipo,
            this.ItemForEstado,
            this.layoutControlGroup3,
            this.ItemForNombreUsuario,
            this.ItemForClave});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(382, 223);
            // 
            // NombreTextEdit
            // 
            this.NombreTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pERSONABindingSource, "Nombre", true));
            this.NombreTextEdit.Location = new System.Drawing.Point(104, 42);
            this.NombreTextEdit.Name = "NombreTextEdit";
            this.NombreTextEdit.Size = new System.Drawing.Size(274, 20);
            this.NombreTextEdit.StyleController = this.dataLayoutControl1;
            this.NombreTextEdit.TabIndex = 4;
            // 
            // ItemForNombre
            // 
            this.ItemForNombre.Control = this.NombreTextEdit;
            this.ItemForNombre.Location = new System.Drawing.Point(0, 0);
            this.ItemForNombre.Name = "ItemForNombre";
            this.ItemForNombre.Size = new System.Drawing.Size(358, 24);
            this.ItemForNombre.Text = "Nombre";
            this.ItemForNombre.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ApellidoTextEdit
            // 
            this.ApellidoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pERSONABindingSource, "Apellido", true));
            this.ApellidoTextEdit.Location = new System.Drawing.Point(104, 66);
            this.ApellidoTextEdit.Name = "ApellidoTextEdit";
            this.ApellidoTextEdit.Size = new System.Drawing.Size(274, 20);
            this.ApellidoTextEdit.StyleController = this.dataLayoutControl1;
            this.ApellidoTextEdit.TabIndex = 5;
            // 
            // ItemForApellido
            // 
            this.ItemForApellido.Control = this.ApellidoTextEdit;
            this.ItemForApellido.Location = new System.Drawing.Point(0, 24);
            this.ItemForApellido.Name = "ItemForApellido";
            this.ItemForApellido.Size = new System.Drawing.Size(358, 24);
            this.ItemForApellido.Text = "Apellido";
            this.ItemForApellido.TextSize = new System.Drawing.Size(76, 13);
            // 
            // TelefonoTextEdit
            // 
            this.TelefonoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pERSONABindingSource, "Telefono", true));
            this.TelefonoTextEdit.Location = new System.Drawing.Point(104, 90);
            this.TelefonoTextEdit.Name = "TelefonoTextEdit";
            this.TelefonoTextEdit.Size = new System.Drawing.Size(274, 20);
            this.TelefonoTextEdit.StyleController = this.dataLayoutControl1;
            this.TelefonoTextEdit.TabIndex = 6;
            // 
            // ItemForTelefono
            // 
            this.ItemForTelefono.Control = this.TelefonoTextEdit;
            this.ItemForTelefono.Location = new System.Drawing.Point(0, 48);
            this.ItemForTelefono.Name = "ItemForTelefono";
            this.ItemForTelefono.Size = new System.Drawing.Size(358, 24);
            this.ItemForTelefono.Text = "Telefono";
            this.ItemForTelefono.TextSize = new System.Drawing.Size(76, 13);
            // 
            // DireccionTextEdit
            // 
            this.DireccionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pERSONABindingSource, "Direccion", true));
            this.DireccionTextEdit.Location = new System.Drawing.Point(104, 114);
            this.DireccionTextEdit.Name = "DireccionTextEdit";
            this.DireccionTextEdit.Size = new System.Drawing.Size(274, 20);
            this.DireccionTextEdit.StyleController = this.dataLayoutControl1;
            this.DireccionTextEdit.TabIndex = 7;
            // 
            // ItemForDireccion
            // 
            this.ItemForDireccion.Control = this.DireccionTextEdit;
            this.ItemForDireccion.Location = new System.Drawing.Point(0, 72);
            this.ItemForDireccion.Name = "ItemForDireccion";
            this.ItemForDireccion.Size = new System.Drawing.Size(358, 24);
            this.ItemForDireccion.Text = "Direccion";
            this.ItemForDireccion.TextSize = new System.Drawing.Size(76, 13);
            // 
            // TipoRadioGroup
            // 
            this.TipoRadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pERSONABindingSource, "Tipo", true));
            this.TipoRadioGroup.Location = new System.Drawing.Point(92, 174);
            this.TipoRadioGroup.Name = "TipoRadioGroup";
            this.TipoRadioGroup.Properties.Columns = 2;
            this.TipoRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("promotor", "Promotor"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("socio", "Socio")});
            this.TipoRadioGroup.Size = new System.Drawing.Size(298, 25);
            this.TipoRadioGroup.StyleController = this.dataLayoutControl1;
            this.TipoRadioGroup.TabIndex = 8;
            // 
            // ItemForTipo
            // 
            this.ItemForTipo.Control = this.TipoRadioGroup;
            this.ItemForTipo.Location = new System.Drawing.Point(0, 162);
            this.ItemForTipo.Name = "ItemForTipo";
            this.ItemForTipo.Size = new System.Drawing.Size(382, 29);
            this.ItemForTipo.StartNewLine = true;
            this.ItemForTipo.Text = "Tipo";
            this.ItemForTipo.TextSize = new System.Drawing.Size(76, 13);
            // 
            // NombreUsuarioTextEdit
            // 
            this.NombreUsuarioTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pERSONABindingSource, "NombreUsuario", true));
            this.NombreUsuarioTextEdit.Location = new System.Drawing.Point(92, 150);
            this.NombreUsuarioTextEdit.Name = "NombreUsuarioTextEdit";
            this.NombreUsuarioTextEdit.Size = new System.Drawing.Size(106, 20);
            this.NombreUsuarioTextEdit.StyleController = this.dataLayoutControl1;
            this.NombreUsuarioTextEdit.TabIndex = 9;
            // 
            // ItemForNombreUsuario
            // 
            this.ItemForNombreUsuario.Control = this.NombreUsuarioTextEdit;
            this.ItemForNombreUsuario.Location = new System.Drawing.Point(0, 138);
            this.ItemForNombreUsuario.Name = "ItemForNombreUsuario";
            this.ItemForNombreUsuario.Size = new System.Drawing.Size(190, 24);
            this.ItemForNombreUsuario.Text = "Nombre Usuario";
            this.ItemForNombreUsuario.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ClaveTextEdit
            // 
            this.ClaveTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pERSONABindingSource, "Clave", true));
            this.ClaveTextEdit.Location = new System.Drawing.Point(282, 150);
            this.ClaveTextEdit.Name = "ClaveTextEdit";
            this.ClaveTextEdit.Size = new System.Drawing.Size(108, 20);
            this.ClaveTextEdit.StyleController = this.dataLayoutControl1;
            this.ClaveTextEdit.TabIndex = 10;
            // 
            // ItemForClave
            // 
            this.ItemForClave.Control = this.ClaveTextEdit;
            this.ItemForClave.Location = new System.Drawing.Point(190, 138);
            this.ItemForClave.Name = "ItemForClave";
            this.ItemForClave.Size = new System.Drawing.Size(192, 24);
            this.ItemForClave.Text = "Clave";
            this.ItemForClave.TextSize = new System.Drawing.Size(76, 13);
            // 
            // EstadoRadioGroup
            // 
            this.EstadoRadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pERSONABindingSource, "Estado", true));
            this.EstadoRadioGroup.Location = new System.Drawing.Point(92, 203);
            this.EstadoRadioGroup.Name = "EstadoRadioGroup";
            this.EstadoRadioGroup.Properties.Columns = 2;
            this.EstadoRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("activo", "Activo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("inactivo", "Inactivo")});
            this.EstadoRadioGroup.Size = new System.Drawing.Size(298, 28);
            this.EstadoRadioGroup.StyleController = this.dataLayoutControl1;
            this.EstadoRadioGroup.TabIndex = 11;
            // 
            // ItemForEstado
            // 
            this.ItemForEstado.Control = this.EstadoRadioGroup;
            this.ItemForEstado.Location = new System.Drawing.Point(0, 191);
            this.ItemForEstado.Name = "ItemForEstado";
            this.ItemForEstado.Size = new System.Drawing.Size(382, 32);
            this.ItemForEstado.StartNewLine = true;
            this.ItemForEstado.Text = "Estado";
            this.ItemForEstado.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForNombre,
            this.ItemForApellido,
            this.ItemForTelefono,
            this.ItemForDireccion});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(382, 138);
            this.layoutControlGroup3.Text = "Datos personales";
            // 
            // ControlPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "ControlPersona";
            this.Size = new System.Drawing.Size(402, 243);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApellidoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DireccionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreUsuarioTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombreUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadoRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit NombreTextEdit;
        private DevExpress.XtraEditors.TextEdit ApellidoTextEdit;
        private DevExpress.XtraEditors.TextEdit TelefonoTextEdit;
        private DevExpress.XtraEditors.TextEdit DireccionTextEdit;
        private DevExpress.XtraEditors.RadioGroup TipoRadioGroup;
        private DevExpress.XtraEditors.TextEdit NombreUsuarioTextEdit;
        private DevExpress.XtraEditors.TextEdit ClaveTextEdit;
        private DevExpress.XtraEditors.RadioGroup EstadoRadioGroup;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTipo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEstado;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNombre;
        private DevExpress.XtraLayout.LayoutControlItem ItemForApellido;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelefono;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDireccion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNombreUsuario;
        private DevExpress.XtraLayout.LayoutControlItem ItemForClave;
        public System.Windows.Forms.BindingSource pERSONABindingSource;
    }
}
