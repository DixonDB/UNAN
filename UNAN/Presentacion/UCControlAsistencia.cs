using System;
using System.Collections.Generic;
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
        int cant, i = 1;
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
            mod.MostrarEE(lblEE,plan.IdCarrera,plan.IdAsignatura,plan.IdGrupo,Login.idprofesor,plan.IdSemestre, plan.IdTema);
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
        }

        private void nudBloque_Leave(object sender, EventArgs e)
        {
            Salida();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cant = int.Parse(nudBloque.Value.ToString());
            nudBloque.Enabled = false;
            txtHora.Enabled = false;
            txtmin.Enabled = false;
            pnBloques.Enabled = true;
        }
            

        private void btnAddBloque_Click(object sender, EventArgs e)
        {
            string Modalidad = (cbModalidad.Text);
            string Carrera = (cbCarrera.Text);
            string Grupo = cbGrupo.Text;
            string Semestre = cbSemestre.Text;
            string Asignatura = cbAsignaturas.Text;
            string Tema = cbContenido.Text;
            string EE = lblEE.Text;
            if (i <= cant)
            {
                dtAsistEntrada.Rows.Add(new object[]
                {
                Modalidad,Carrera,Grupo,Semestre,Asignatura,Tema, EE
                    //,Estado
                });
            }
            else
            {
                pnBloques.Enabled = false;
            }
            i++;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarAsistencia();
        }

        private void InsertarAsistencia()
        {
            try
            {
                List<LAsistencia> lst = new List<LAsistencia>();

                //LLenar
                foreach (DataGridViewRow dr in dtAsistEntrada.Rows)
                {
                    LAsistencia oConcepto = new LAsistencia();
                    oConcepto.HoraI = DateTime.Parse(dr.Cells[0].Value.ToString());
                    oConcepto.HoraF = DateTime.Parse(dr.Cells[1].Value.ToString());
                    oConcepto.Observaciones = dr.Cells[2].Value.ToString();
                    lst.Add(oConcepto);
                }
                int hora = int.Parse(txtHora.Text);
                int minuto = int.Parse(txtmin.Text);
                DateTime horaCompleta = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hora, minuto, 0);
                string horaFormateada = horaCompleta.ToString("HH:mm");
                string horaI = horaFormateada;
                string horaf = horaI;
                string observaciones = "--";
                LAsistencia parametros = new LAsistencia();
                parametros.IdAsignatura = (int)cbAsignaturas.SelectedValue;
                parametros.Idprofe = Login.idprofesor;
                parametros.IdCarrera = (int)cbCarrera.SelectedValue;
                parametros.IdGrupo = (int)cbGrupo.SelectedValue;
                parametros.IdSemestre = (int)cbSemestre.SelectedValue;
                parametros.IdTema = (int)cbContenido.SelectedValue;
                parametros.HoraI = DateTime.Parse(horaI);
                parametros.HoraF = DateTime.Parse(horaf);
                parametros.Observaciones = observaciones;
                parametros.Bloque = (int)nudBloque.Value;

                DAsistencia funcion = new DAsistencia();
                funcion.InsertarAsistencia(parametros, lst);
                MessageBox.Show("Registro realizado", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnFormAsistencia.Visible = false;
                PanelPaginado.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
