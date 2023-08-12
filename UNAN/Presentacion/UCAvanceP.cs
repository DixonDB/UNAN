using System;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.Logica;

namespace UNAN.Presentacion
{
    public partial class UCAvanceP : UserControl
    {
        private int conteo;

        int cant, i = 1;
        DAsistencia asis = new DAsistencia();
        DModalidades mod = new DModalidades();
        DAsignatura asig = new DAsignatura();
        DAvanceProgramatico AP = new DAvanceProgramatico();
        public UCAvanceP()
        {
            InitializeComponent();
            conteo = 0;
            cbSemestre.SelectedIndexChanged += CbSemestre_SelectedIndexChanged;
        }
        private void CbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            asis.AsignaturaXProfesor(cbAsignaturas, Login.idprofesor, cbModalidad.Text, cbCarrera.Text, cbSemestre.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnAvanceP.Visible = true;
            pnAvanceP.Dock = DockStyle.Fill;
            PanelPaginado.Visible = false;
            panel4.Visible = false;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnAvanceP.Visible = false;
            PanelPaginado.Visible = true;
            panel4.Visible = true;
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
        private void CargarInformacion()
        {
            txtDocente.Text = Login.nombreprofe;
            asis.ModalidadXProfesor(cbModalidad, Login.idprofesor);
            asis.CarreraXProfesor(cbCarrera, Login.idprofesor, cbModalidad.Text, cbSemestre.Text);
            asis.SemestreXProfesor(cbSemestre, Login.idprofesor);
            GrupoXporfesor();
            Mostrarcod();
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
        private void MostrarUltimoTema()
        {
            try
            {
                int idcarrera;
                int idasignatura;
                idcarrera = int.Parse(cbCarrera.SelectedValue.ToString());
                idasignatura = int.Parse(cbAsignaturas.SelectedValue.ToString());
                AP.MostrarUltimoTema(txtUltimoTema, Login.idprofesor, idcarrera, idasignatura);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void MostrarTemasAtrasados()
        {
            try
            {
                DataTable dt = new DataTable();                
                DAvanceProgramatico funcion = new DAvanceProgramatico();
                LAvanceProgramatico parametros= new LAvanceProgramatico();
                parametros.IdProfesor= Login.idprofesor;
                parametros.IdCarrera= Convert.ToInt32(cbCarrera.SelectedValue.ToString()); ;
                parametros.IdAsignatura= Convert.ToInt32(cbAsignaturas.SelectedValue.ToString()); ;
                funcion.MostrarTemasAtrasados(ref dt,parametros);
                dgvtemasatrasados.DataSource = dt;
                Bases.DiseñoDtv(ref dgvtemasatrasados);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void UCAvanceP_Load(object sender, EventArgs e)
        {
            pncarga.Dock = DockStyle.Fill;
            timer1.Enabled = true;
            await CargarDatos();
            pncarga.Visible = false;
            panel4.Visible = true;
            CargarInformacion();
            Bases.DiseñoDtv(ref dgvtemasatrasados);
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
            MostrarTemasAtrasados();
        }
        private void cbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrarcod();
            GrupoXporfesor();
            asis.AsignaturaXProfesor(cbAsignaturas, Login.idprofesor, cbModalidad.Text, cbCarrera.Text, cbSemestre.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
            MostrarUltimoTema();
            MostrarTemasAtrasados();
        }

        private void cbAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
           MostrarTemasAtrasados();
        }

        public async Task CargarDatos()
        {
            await Task.Delay(1500);
            //Metodo mostrar
            await Task.Delay(1000);
        }
    }
}
