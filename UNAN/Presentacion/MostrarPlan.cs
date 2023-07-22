using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.FrmPlanDidactico;
using UNAN.Logica;


namespace UNAN.Presentacion
{
    public partial class MostrarPlan : Form
    {
        public int idplan;

        public MostrarPlan()
        {
            InitializeComponent();
        }
        private void MostrarPlan_Load(object sender, EventArgs e)
        {
            Bases.DiseñoDtv(ref dtDetallePlan);
            CargarDatos();
            
        }
        public void CargarDatos()
        {
            int idPLAN = idplan;
            DataTable dt = new DataTable();
            DPlanDidactico funcion = new DPlanDidactico();
            funcion.DetallePlan(ref dt, idPLAN);
            dtDetallePlan.DataSource = dt;
        }
    }
}
