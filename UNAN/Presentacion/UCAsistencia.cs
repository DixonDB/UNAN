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
    public partial class UCAsistencia : UserControl
    {
        public UCAsistencia()
        {
            InitializeComponent();
        }

        private void UCAsistencia_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            DCarreras carreras = new DCarreras();
            DModalidades mod= new DModalidades();
            carreras.MostrarCarrera(cbCarrera);
            carreras.MostrarCodigoC(cbCarrera.Text, lblCod);
            mod.MostrarModalidades(cbModalidad);
        }

        private void cbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            DCarreras carreras=new DCarreras();
            carreras.MostrarCodigoC(cbCarrera.Text, lblCod);
        }
    }
}
