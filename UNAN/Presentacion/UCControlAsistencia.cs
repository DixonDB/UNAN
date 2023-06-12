using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.Logica;

namespace UNAN.Presentacion
{
    public partial class UCControlAsistencia : UserControl
    {
        DCarreras carreras = new DCarreras();
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
            DModalidades mod = new DModalidades();
            carreras.MostrarCarrera(cbCarrera, cbModalidad.Text);
            carreras.MostrarCodigoC(cbCarrera.Text, lblCod);
            mod.MostrarModalidades(cbModalidad);
        }

        private void cbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            carreras.MostrarCodigoC(cbCarrera.Text, lblCod);
        }

        private void cbModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            carreras.MostrarCarrera(cbCarrera, cbModalidad.Text);

        }
    }
}
