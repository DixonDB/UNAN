using System;
using System.Windows.Forms;
using UNAN.Datos;

namespace UNAN.Presentacion
{
    public partial class UCControlAsistencia : UserControl
    {
        DCarreras carreras = new DCarreras();
        DModalidades mod = new DModalidades();
        DAsignatura asig = new DAsignatura();
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
            carreras.MostrarCarrera(cbCarrera, cbModalidad.Text);
            Mostrarcod();
            mod.MostrarModalidades(cbModalidad);
            mod.MostrarGrupos(cbGrupo, cbCarrera.Text);
            mod.MostrarSemestre(cbSemestre);
        }
        private void Mostrarcod()
        {
            DCarreras funcion = new DCarreras();
            funcion.MostrarCodigoC(cbCarrera.Text, lblCod);
        }

        private void cbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrarcod();
            mod.MostrarGrupos(cbGrupo, cbCarrera.Text);
            asig.MostrarAsignatura(cbAsignaturas, cbSemestre.Text, cbCarrera.Text, cbGrupo.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
        }

        private void cbModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            carreras.MostrarCarrera(cbCarrera, cbModalidad.Text);
            asig.MostrarAsignatura(cbAsignaturas, cbSemestre.Text, cbCarrera.Text, cbGrupo.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
            mod.MostrarGrupos(cbGrupo, cbCarrera.Text);
            Mostrarcod();
        }

        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            asig.MostrarAsignatura(cbAsignaturas, cbSemestre.Text, cbCarrera.Text, cbGrupo.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
        }

        private void cbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            asig.MostrarAsignatura(cbAsignaturas, cbSemestre.Text, cbCarrera.Text, cbGrupo.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
        }

        private void cbAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
        }
    }
}
