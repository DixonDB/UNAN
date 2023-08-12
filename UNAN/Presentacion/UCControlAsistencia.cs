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
        public static int IdAsistencia;
        public static DateTime Fecha;
        public static int Bloques;
        public static DateTime Hentrada;
        public static DateTime Hsalida;
        public UCControlAsistencia()
        {
            InitializeComponent();
            conteo = 0;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnFormAsistencia.Visible = true;
            pnFormAsistencia.Dock = DockStyle.Fill;
            PanelPaginado.Visible = false;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            reset();
        }
        private async void UCControlAsistencia_Load(object sender, EventArgs e)
        {
            CentrarControles();
            MostrarDatos();
            timer1.Enabled = true;
            await CargarDatos();
            pncarga.Visible = false;
            hora();
            lblFecha.Text = DateTime.Now.ToShortDateString();
            panel1.Visible = true;
        }
        private void CentrarControles()
        {
            pncarga.Dock = DockStyle.Fill;
            pncarga.BringToFront();
            pbrCarga.Location = new System.Drawing.Point(pncarga.Width / 2- 220 - pbrCarga.Width / 2, pncarga.Height /2 -50 - pbrCarga.Height / 2);
        }
        public async Task CargarDatos()
        {
            await Task.Delay(1500);
            MostrarAsistencia();

            await Task.Delay(1000);
        }
        private void MostrarDatos()
        {
            asis.ModalidadXProfesor(cbModalidad, Login.idprofesor);
            asis.MostrarTemas(cbContenido, cbCarrera.Text, cbAsignaturas.Text, cbGrupo.Text, Login.idprofesor, cbSemestre.Text);
            asis.CarreraXProfesor(cbCarrera, Login.idprofesor, cbModalidad.Text, cbSemestre.Text);
            Mostrarcod();
            GrupoXporfesor();
            asis.SemestreXProfesor(cbSemestre, Login.idprofesor);
        }
        private void Mostrarcod()
        {
            DCarreras funcion = new DCarreras();
            funcion.MostrarCodigoC(cbCarrera.Text, lblCod);
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
                    asis.GrupoXProfesor(cbGrupo, cbCarrera.Text, Login.idprofesor);
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
            asis.CarreraXProfesor(cbCarrera, Login.idprofesor, cbModalidad.Text, cbSemestre.Text);
            asis.AsignaturaXProfesor(cbAsignaturas, Login.idprofesor, cbModalidad.Text, cbCarrera.Text, cbSemestre.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
            GrupoXporfesor();
            Mostrarcod();

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
        private void CbContenido_SelectedIndexChanged(object sender, EventArgs e)
        {
            var IdTema = (int)cbContenido.SelectedValue;
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
            btnAceptar.Enabled = false;
        }
        private void btnAddBloque_Click(object sender, EventArgs e)
        {
            int idCarera = Convert.ToInt32(cbCarrera.SelectedValue.ToString());
            int idmodalidad = Convert.ToInt32(cbModalidad.SelectedValue.ToString());
            int idgrupo = Convert.ToInt32(cbGrupo.SelectedValue.ToString());
            int idsemestre = Convert.ToInt32(cbSemestre.SelectedValue.ToString());
            int idasignatura = Convert.ToInt32(cbAsignaturas.SelectedValue.ToString());
            int idtema = Convert.ToInt32(cbContenido.SelectedValue.ToString());
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
                idsemestre,Semestre,idCarera,Carrera,idmodalidad,Modalidad,idgrupo,Grupo,idasignatura,Asignatura,idtema,Tema
                    //,Estado
                });
                int j = i + 1;
                lblbloque.Text = Convert.ToString(j);
                i++;
            }
            else
            {
                pnBloques.Enabled = false;
            }
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
                List<LAsis> lst = new List<LAsis>();

                //LLenar
                foreach (DataGridViewRow dr in dtAsistEntrada.Rows)
                {
                    LAsis oConcepto = new LAsis();
                    
                    oConcepto.IdAsignatura = int.Parse(dr.Cells[8].Value.ToString());
                    oConcepto.IdTema = int.Parse(dr.Cells[10].Value.ToString());
                    lst.Add(oConcepto);
                }

                LAsis parametros = new LAsis();

                int hora = int.Parse(txtHora.Text);
                int minuto = int.Parse(txtmin.Text);
                int bloques = int.Parse(nudBloque.Text);
                DateTime horaInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hora, minuto, 0);
                DateTime horaFin = horaInicio.AddMinutes(bloques * 45);

                string horaInicioFormateada = horaInicio.ToString("HH:mm");
                string horaFinFormateada = horaFin.ToString("HH:mm");

                parametros.IdProfesor = Login.idprofesor;
                parametros.Fecha = DateTime.Parse(lblFecha.Text);
                parametros.Bloques = (int)nudBloque.Value;
                parametros.HoraInicio = DateTime.Parse(horaInicioFormateada);
                parametros.HoraFin = DateTime.Parse(horaFinFormateada);
                parametros.Observacion = "Esto es una Asistencia";

                DAsistencia funcion = new DAsistencia();
                funcion.Insertaasistencias(parametros, lst);
                MessageBox.Show("Registro realizado", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void reset()
        {
            pnFormAsistencia.Visible = false;
            i = 1;
            dtAsistEntrada.Rows.Clear();
            pnBloques.Enabled = true;
            nudBloque.Value = 1;
            nudBloque.Enabled = true;
            txtHora.Enabled = true;
            txtmin.Enabled = true;
            btnAceptar.Enabled = true;
            pnBloques.Enabled = false;
            PanelPaginado.Visible = true;
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
            dataAsistencia.Columns[5].Visible = false;
            dataAsistencia.Columns[6].Visible = false;
        }
        private void dataAsistencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataAsistencia.Columns["Editar"].Index)
            {
                PasarIdAsistencia();
            }
           
        }
        private void PasarIdAsistencia()
        {           
            IdAsistencia = Convert.ToInt32(dataAsistencia.SelectedCells[5].Value);
            Fecha = Convert.ToDateTime(dataAsistencia.SelectedCells[7].Value);
            Hentrada = Convert.ToDateTime(dataAsistencia.SelectedCells[8].Value);
            Hsalida = Convert.ToDateTime(dataAsistencia.SelectedCells[9].Value);
            Bloques = Convert.ToInt32(dataAsistencia.SelectedCells[10].Value);
            DetalleAsistencias da = new DetalleAsistencias();
            da.idasistencias = IdAsistencia;
            da.fecha = Fecha;
            da.entrada= Hentrada;
            da.salida = Hsalida;
            da.bloques = Bloques;
            da.ShowDialog();
        }
    }
}
