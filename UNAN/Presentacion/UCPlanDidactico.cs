using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.Logica;
using UNAN.Presentacion;

namespace UNAN.FrmPlanDidactico
{
    public partial class UCPlanDidactico : UserControl
    {
        //Un DataSet es un objeto que almacena n número de DataTables, estas tablas puedes estar conectadas dentro del dataset.
        private DataSet dtsTablas = new DataSet();
        DCarreras carreras = new DCarreras();
        DModalidades mod=new DModalidades();
        DAsignatura asig = new DAsignatura();
        DAprendizaje da=new DAprendizaje();
        frmMenu pri=new frmMenu();
        public UCPlanDidactico()
        {
            InitializeComponent();
            carga();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            PCargarPlan.Visible = true;
            PCargarPlan.Size = new Size(511, 178);
            PCargarPlan.Location = new Point(282, 25);
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            FrmCarrera carrera = new FrmCarrera();
            carrera.ShowDialog();
            carreras.MostrarCarrera(cbCarrera,cbModalidad.Text);
        }
        private void MostrarAprendizaje()
        {
            da.MostrarEstrategiaEvaluacion(cbEstrEvaluacion);
            
            da.MostrarFormaEvaluacion(cbFormaEvaluacion);

            da.MostrarEstrategiaAprendizaje(cbEnseApren);
        }
        private void UCPlanDidactico_Load(object sender, EventArgs e)
        {
            MostrarAprendizaje();
            carreras.MostrarCarrera(cbCarrera, cbModalidad.Text);
            Mostrarcod();
            mod.MostrarModalidades(cbModalidad);
            mod.MostrarGrupos(cbGrupo, cbCarrera.Text);
            Bases.DiseñoDtv(ref dtPlan);
            mod.MostrarSemestre(cbSemestre);
            txtDocente.Text = Login.nombreprofe;
        }
        private void Mostrarcod()
        {
            DCarreras funcion = new DCarreras();
            funcion.MostrarCodigoC(cbCarrera.Text, lblCod);
        }
        private void Diseñodt()
        {
            Bases.DiseñoDtv(ref dtPlanD);
            PanelPaginado.Visible = true;
            dtPlanD.Columns["IdPlan"].Visible = false;
            dtPlanD.Columns[3].Visible = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //CONFIGURACION DE LA VENTANA PARA BUSCAR EL ARCHIVO
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Worbook|*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cboHojas.Items.Clear();
                dtPlan.DataSource = null;
                txtRuta.Text = ofd.FileName;

                //FileStream nos permite leer, escribir, abrir y cerrar archivos en un sistema de archivos, como matrices de bytes
                FileStream fsSource = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);

                //ExcelReaderFactory.CreateBinaryReader = formato XLS
                //ExcelReaderFactory.CreateOpenXmlReader = formato XLSX
                //ExcelReaderFactory.CreateReader = XLS o XLSX
                IExcelDataReader reader = ExcelReaderFactory.CreateReader(fsSource);

                //convierte todas las hojas a un DataSet
                dtsTablas = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });

                //obtenemos las tablas y añadimos sus nombres en el desplegable de hojas
                foreach (DataTable tabla in dtsTablas.Tables)
                {
                    cboHojas.Items.Add(tabla.TableName);
                }
                cboHojas.SelectedIndex = 0;
                reader.Close();
                if (txtRuta.Text!="")
                {
                    btnCargar.Enabled = true;
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dtPlan.DataSource = dtsTablas.Tables[cboHojas.SelectedIndex];
            PCargarPlan.Visible = false;
            PCargarPlan.Size = new Size(77, 48);
            PCargarPlan.Location = new Point(960, 238);
            gbDatos.Dock = DockStyle.None;
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            PCargarPlan.Visible = false;
            PCargarPlan.Size = new Size(77, 48);
            PCargarPlan.Location = new Point(960, 238);
        }

        private void cbCarrera_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Mostrarcod();
            lblCod.Visible = true;
        }


        private void btnAddGrupo_Click(object sender, EventArgs e)
        {
            frmGrupo fg=new frmGrupo();
            fg.ShowDialog();
            mod.MostrarGrupos(cbGrupo, cbCarrera.Text);
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
        private void cbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            asig.MostrarAsignatura(cbAsignaturas, cbSemestre.Text, cbCarrera.Text,cbGrupo.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
        }

        private void cbAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
        }

        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            asig.MostrarAsignatura(cbAsignaturas, cbSemestre.Text, cbCarrera.Text, cbGrupo.Text);
            asig.MostrarCodigoA(cbAsignaturas.Text, lblCodAsig);
        }

        private void btnSubirPlan_Click(object sender, EventArgs e)
        {
            gbDatos.Dock=DockStyle.Top;
        }

        private void btnAddAsig_Click(object sender, EventArgs e)
        {
            FrmAsignatura asig = new FrmAsignatura();
            asig.ShowDialog();
        }

        private void btnEEA_Click(object sender, EventArgs e)
        {
            FrmFormaEstrag fr = new FrmFormaEstrag();
            fr.PnEstraEnseApren.Visible=true;
            fr.PnEstraEnseApren.Dock=DockStyle.Fill;
            fr.ShowDialog();
        }

        private void btnFE_Click(object sender, EventArgs e)
        {
            FrmFormaEstrag fr = new FrmFormaEstrag();
            fr.lblTitulo.Text = "Forma de Evaluación";
            fr.pnForEva.Visible = true;
            fr.pnForEva.Dock = DockStyle.Fill;
            fr.ShowDialog();
        }

        private void btnEE_Click(object sender, EventArgs e)
        {
            FrmFormaEstrag fr = new FrmFormaEstrag();
            fr.lblTitulo.Text = "Estrategia de Evaluación";
            fr.pnEstraEva.Visible = true;
            fr.pnEstraEva.Dock = DockStyle.Fill;
            fr.ShowDialog();
        }

        //Vista de progreso
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
            MostrarPlanD();
            pncarga.Visible = false;
            pnBotones.Visible = true;
            gbDatos.Visible = true;
            GBDetalles.Visible = true;
            flowLayoutPanel1.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnPlan.Visible = true;
            pnPlan.Dock = DockStyle.Fill;
            PanelPaginado.Visible = false;
            panel4.Visible= false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnPlan.Visible = false;
            PanelPaginado.Visible = true;
            panel4.Visible = true;
        }
        private void MostrarPlanD()
        {
            int idprofesor = Login.idprofesor;
            DataTable dt = new DataTable();
            DPlanDidactico funcion= new DPlanDidactico();
            funcion.MostrarPlanD(ref dt, idprofesor);
            dtPlanD.DataSource = dt;
            Diseñodt();
        }

        //Llenar data de forma manual
        /// <summary>
        /// Defino cada control
        /// </summary>
        public class DatosRegistro
        {
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }
            public int SemanaInicio { get; set; }
            public int SemanaFin { get; set; }
            public string Objetivos { get; set; }
            public string Contenido { get; set; }
            public string CbEASeleccionado { get; set; }
            public string CbEESeleccionado { get; set; }
            public string CbFESeleccionado { get; set; }
            public string Porcentaje { get; set; }
        }
        /// <summary>
        /// Se define la lista que almacenara los datos
        /// </summary>
        List<DatosRegistro> listaRegistros = new List<DatosRegistro>();
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            // Obtener los datos de los controles
            DateTime fechaInicio = dtFechaInico.Value;
            DateTime fechaFin = dtFechaFin.Value;
            int semanaInicio = int.Parse(txtSemInicio.Text);
            int semanaFin = int.Parse(txtSemFin.Text);
            string objetivos = txtObj.Text;
            string contenido = txtCont.Text;
            string cbEASeleccionado = cbEnseApren.Text;
            string cbEESeleccionado = cbEstrEvaluacion.Text;
            string cbFESeleccionado = cbFormaEvaluacion.Text;
            string porcentaje = txtPorcentaje.Text;

            // Crear un nuevo objeto DatosRegistro
            DatosRegistro nuevoRegistro = new DatosRegistro()
            {
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                SemanaInicio = semanaInicio,
                SemanaFin = semanaFin,
                Objetivos = objetivos,
                Contenido = contenido,
                CbEASeleccionado = cbEASeleccionado,
                CbEESeleccionado = cbEESeleccionado,
                CbFESeleccionado = cbFESeleccionado,
                Porcentaje=porcentaje
            };

            // Agregar el objeto a la lista
            listaRegistros.Add(nuevoRegistro);
            MostrarDatosEnDataGridView();
            // Limpiar los controles
            LimpiarControles();
        }
        private void LimpiarControles()
        {
            dtFechaInico.Value = DateTime.Now;
            dtFechaFin.Value = DateTime.Now;
            txtSemInicio.Text = string.Empty;
            txtSemFin.Text = string.Empty;
            txtObj.Text = string.Empty;
            txtCont.Text = string.Empty;
            txtPorcentaje.Text = string.Empty;
        }
        private void MostrarDatosEnDataGridView()
        {
            //dtPlan.Rows.Clear();
            foreach (var registro in listaRegistros)
            {
                dtPlan.Rows.Add(
                    registro.FechaInicio.ToShortDateString(),
                    registro.FechaFin.ToShortDateString(),
                    registro.SemanaInicio,
                    registro.SemanaFin,
                    registro.Objetivos,
                    registro.Contenido,
                    registro.CbEASeleccionado,
                    registro.CbEESeleccionado,
                    registro.CbFESeleccionado,
                    registro.Porcentaje
                );
            }
        }
        private void ConfigurarDataGridView()
        {
            // Borramos todas las columnas actuales del DataGridView
            dtPlan.Columns.Clear();

            // Configuramos las columnas con los encabezados deseados
            dtPlan.Columns.Add("ColumnFechaInicio", "Fecha Inicio");
            dtPlan.Columns.Add("ColumnFechaFin", "Fecha Fin");
            dtPlan.Columns.Add("ColumnSemanaInicio", "Semana Inicio");
            dtPlan.Columns.Add("ColumnSemanaFin", "Semana Fin");
            dtPlan.Columns.Add("ColumnObjetivos", "Objetivos");
            dtPlan.Columns.Add("ColumnContenido", "Contenido");
            dtPlan.Columns.Add("ColumnEA", "EA");
            dtPlan.Columns.Add("ColumnEE", "EE");
            dtPlan.Columns.Add("ColumnFE", "FE");
            dtPlan.Columns.Add("Porcentaje", "%");
        }

    }
}
