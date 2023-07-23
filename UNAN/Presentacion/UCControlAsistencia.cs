using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.Logica;

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
            carga();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnFormAsistencia.Visible = true;
            pnFormAsistencia.Dock= DockStyle.Fill;
            PanelPaginado.Visible = false;
            limpiar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            pnFormAsistencia.Visible= false;
            PanelPaginado.Visible = true;
        }

        private void UCControlAsistencia_Load(object sender, EventArgs e)
        {
            hora();
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
            mod.MostrarTemas(cbContenido, cbCarrera.Text, cbAsignaturas.Text, cbGrupo.Text, Login.idprofesor, cbSemestre.Text);
            MostrarEE();
        }
        private void Mostrarcod()
        {
            DCarreras funcion = new DCarreras();
            funcion.MostrarCodigoC(cbCarrera.Text, lblCod);
        }
        private void MostrarEE()
        {
            LPlanDidactico plan = new LPlanDidactico();
            plan.IdCarrera = (int)cbCarrera.SelectedValue; 
            plan.IdAsignatura= (int)cbAsignaturas.SelectedValue;
            plan.IdGrupo= (int)cbGrupo.SelectedValue;
            plan.IdSemestre= (int)cbSemestre.SelectedValue;
            plan.IdTema= (int)cbContenido.SelectedValue;
            mod.MostrarEETemas(cbActividad,plan.IdCarrera,plan.IdAsignatura,plan.IdGrupo,Login.idprofesor,plan.IdSemestre, plan.IdTema);
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
            mod.MostrarTemas(cbContenido, cbCarrera.Text, cbAsignaturas.Text, cbGrupo.Text, Login.idprofesor, cbSemestre.Text);
        }
        private void hora()
        {
            txtHora.Text = DateTime.Now.ToString("hh");
            txtmin.Text = DateTime.Now.ToString("mm");
        }
        private void Salida()
        {
            int bloque = int.Parse(nudBloque.Value.ToString());
            double tiempo = 1.20;
            double salida = bloque * tiempo;
            int hora = int.Parse(txtHora.Text);
            int minutos = int.Parse(txtmin.Text);
            DateTime fechaActual = DateTime.Now;
            DateTime nuevaFecha = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, hora, minutos, 0);
            TimeSpan horasLaboradas = TimeSpan.FromHours(salida);
            DateTime horaConSalida = nuevaFecha.Add(horasLaboradas);
            txtHoraS.Text=horaConSalida.Hour.ToString();
            txtMinS.Text=horaConSalida.Minute.ToString();
        }

        private void nudBloque_Leave(object sender, EventArgs e)
        {
            Salida();
        }
        private void limpiar()
        {
            txtHoraS.Clear();
            txtMinS.Clear();
            nudBloque.Value = 0;
            txtObservaciones.Clear();
        }

        private void carga()
        {
            if (backgroundWorker1.IsBusy != true)
            {
                pncarga.Dock = DockStyle.Fill;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(100);
                backgroundWorker1.ReportProgress(i * 10);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbrCarga.Value = e.ProgressPercentage;
            lblCarga.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pncarga.Visible = false;
        }

        private void cbContenido_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarEE();
        }
    }
}
