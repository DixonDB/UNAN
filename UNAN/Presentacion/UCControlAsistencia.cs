using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNAN.Datos;

namespace UNAN.Presentacion
{
    public partial class UCControlAsistencia : UserControl
    {
        public UCControlAsistencia()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnFormAsistencia.Visible = true;
            pnFormAsistencia.Dock= DockStyle.Fill;
            PanelPaginado.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            pnFormAsistencia.Visible= false;
            PanelPaginado.Visible = true;
        }

        private void UCControlAsistencia_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            DCarreras carreras = new DCarreras();
            DModalidades mod = new DModalidades();
            carreras.MostrarCarrera(cbCarrera);
            carreras.MostrarCodigoC(cbCarrera.Text, lblCod);
            mod.MostrarModalidades(cbModalidad);
        }

        private void cbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            DCarreras carreras = new DCarreras();
            carreras.MostrarCodigoC(cbCarrera.Text, lblCod);
        }
    }
}
