﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace Csur.Presentacion.Controles
{
    public partial class ControlPlanCuentas : DevExpress.XtraEditors.XtraUserControl
    {
        public ControlPlanCuentas()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            //Csur.Datos.DBcsurEntities dbContext = new Csur.Datos.DBcsurEntities();
            // Call the Load method to get the data for the given DbSet from the database.
            //dbContext.PLANCUENTAS.Load();
            // This line of code is generated by Data Source Configuration Wizard
            //pLANCUENTASBindingSource.DataSource = dbContext.PLANCUENTAS.Local.ToBindingList();
        }
    }
}
