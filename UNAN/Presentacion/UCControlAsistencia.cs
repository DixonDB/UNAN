using System;
using System.Collections.Generic;
using System.Data;
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
        DAsistencia asis = new DAsistencia();
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
            MostrarDatos();
            timer1.Enabled = true;
            await CargarDatos();
            pncarga.Visible = false;
            hora();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        public async Task CargarDatos()
        {
            await Task.Delay(1500);
            MostrarAsistencia();
            
            await Task.Delay(1000);
        }
        private void MostrarDatos()
        {
            asis.ModalidadXProfesor(cbModalidad,Login.idprofesor);
            asis.MostrarTemas(cbContenido, cbCarrera.Text, cbAsignaturas.Text, cbGrupo.Text, Login.idprofesor, cbSemestre.Text);
            asis.CarreraXProfesor(cbCarrera, Login.idprofesor,cbModalidad.Text, cbSemestre.Text);
            Mostrarcod();
            GrupoXporfesor();
            asis.SemestreXProfesor(cbSemestre,Login.idprofesor);
        }
        private void Mostrarcod()
        {
            DCarreras funcion = new DCarreras();
            funcion.MostrarCodigoC(cbCarrera.Text, lblCod);
        }
        private void MostrarEE()
        {
            try
            {
                LPlanDidactico plan = new LPlanDidactico();
                if (plan.IdTema == 0)
                {
                    cbContenido.Text = "";
                }
                else
                {
                    plan.IdTema = (int)cbContenido.SelectedValue;
                    asis.MostrarEE(lblEE, plan.IdTema);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void GrupoXporfesor()
        {
            try
            {
                if (cbCarrera.Text == "")
                {
                    cbGrupo.Text = "";
                }
                else
                {
                    asis.GrupoXProfesor(cbGrupo, cbCarrera.Text,Login.idprofesor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar grupoxprofeosr" + ex.Message);
            }
        }
        private void cbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrarcod();
            GrupoXporfesor();
            asis.AsignaturaXProfesor(cbAsignaturas, Login.idprofesor, cbModalidad.Text, cbCarrera.Text, cbSemestre.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
        }
        private void cbModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            asis.CarreraXProfesor(cbCarrera, Login.idprofesor,cbModalidad.Text,cbSemestre.Text);
            asis.AsignaturaXProfesor(cbAsignaturas, Login.idprofesor, cbModalidad.Text, cbCarrera.Text, cbSemestre.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
            GrupoXporfesor();
            Mostrarcod();
            MostrarEE();
        }
        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            asis.AsignaturaXProfesor(cbAsignaturas, Login.idprofesor, cbModalidad.Text, cbCarrera.Text, cbSemestre.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
        }
        private void cbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            asis.AsignaturaXProfesor(cbAsignaturas, Login.idprofesor, cbModalidad.Text, cbCarrera.Text, cbSemestre.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
        }
        private void cbAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
            asis.MostrarTemas(cbContenido, cbCarrera.Text, cbAsignaturas.Text, cbGrupo.Text, Login.idprofesor, cbSemestre.Text);
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
            int IdTema = (int)cbContenido.SelectedValue;
            asis.MostrarEE(lblEE, IdTema);
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
            asis.CarreraXProfesor(cbCarrera, Login.idprofesor, cbModalidad.Text, cbSemestre.Text);
            asis.AsignaturaXProfesor(cbAsignaturas, Login.idprofesor, cbModalidad.Text, cbCarrera.Text, cbSemestre.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
            GrupoXporfesor();
            Mostrarcod();
            MostrarEE();
            btnAceptar.Enabled = false;
        }            
        private void btnAddBloque_Click(object sender, EventArgs e)
        {
            string Carrera = (cbCarrera.Text);
            string Modalidad = (cbModalidad.Text);            
            string Grupo = cbGrupo.Text;
            string Semestre = cbSemestre.Text;
            string Asignatura = cbAsignaturas.Text;
            string Tema = cbContenido.Text;
            if (i <= cant)
            {
                dtAsistEntrada.Rows.Add(new object[]
                {
                Semestre,Carrera,Modalidad,Grupo,Asignatura,Tema
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
            MostrarAsistencia();
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
                    oConcepto.Semestre = (dr.Cells[0].Value.ToString());
                    oConcepto.Modalidad = (dr.Cells[1].Value.ToString());
                    oConcepto.Carrera = dr.Cells[2].Value.ToString();
                    oConcepto.Grupo = dr.Cells[3].Value.ToString();
                    oConcepto.Asignatura = dr.Cells[4].Value.ToString();
                    oConcepto.Tema = dr.Cells[5].Value.ToString();
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
                parametros.Fecha = DateTime.Parse(lblFecha.Text);
                parametros.Idprofe = Login.idprofesor;
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
        private void MostrarAsistencia()
        {
            int idprofesor = Login.idprofesor;
            DataTable dt = new DataTable();
            DAsistencia funcion = new DAsistencia();
            funcion.MostrarAsistencia(ref dt, idprofesor);
            dataAsistencia.DataSource = dt;
            Diseñodt();
        }
        private void Diseñodt()
        {
            Bases.DiseñoDtv(ref dataAsistencia);
            PanelPaginado.Visible = true;
            dataAsistencia.Columns[2].Visible = false;
            dataAsistencia.Columns[3].Visible = false;
        }
    }
}
