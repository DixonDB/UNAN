﻿using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.Logica;

namespace UNAN.Presentacion
{
    public partial class UCControlAsistencia : UserControl
    {
        private int conteo;
        DCarreras carreras = new DCarreras();
        DModalidades mod = new DModalidades();
        DAsignatura asig = new DAsignatura();
        public UCControlAsistencia()
        {
            InitializeComponent();
            conteo = 0;
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

        private async void UCControlAsistencia_Load(object sender, EventArgs e)
        {
            pncarga.Dock = DockStyle.Fill;
            timer1.Enabled = true;
            await CargarDatos();
            pncarga.Visible = false;
            hora();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        public async Task CargarDatos()
        {
            await Task.Delay(1500);
            MostrarDatos();
            
            await Task.Delay(1000);
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

        private void cbContenido_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarEE();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo += 10;
            lblCarga.Text = conteo.ToString() + " %";
            if (pbrCarga.Value < 100)
            {
                pbrCarga.Value += 10;
            }
            if (pbrCarga.Value == 100)
            {
                timer1.Enabled = false;
            }
        }
    }
}
