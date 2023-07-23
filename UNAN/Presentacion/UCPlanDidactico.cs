using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public static int IdPlan;
        public static string Asignatura;
        //Un DataSet es un objeto que almacena n número de DataTables, estas tablas puedes estar conectadas dentro del dataset.
        public DataSet dtsTablas = new DataSet();
        DCarreras carreras = new DCarreras();
        DModalidades mod=new DModalidades();
        DAsignatura asig = new DAsignatura();
        DAprendizaje da=new DAprendizaje();
        LPlanDidactico plan = new LPlanDidactico();
        public UCPlanDidactico()
        {
            InitializeComponent();
            carga();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            PCargarPlan.BringToFront();
            PCargarPlan.Visible = true;
            PCargarPlan.Size = new Size(511, 178);
            PCargarPlan.Location = new Point(this.Width/2- PCargarPlan.Width/2,this.Height/2-PCargarPlan.Height/2);
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
            Bases.DiseñoDtv(ref dtPlan2);
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
            dtPlanD.Columns[4].Visible = false;
            dtPlanD.Columns[5].Visible = false;
        }
        private DataSet ReadExcelFile(string filePath)
        {
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);

            // Determine the format of the file based on the extension
            IExcelDataReader reader;
            if (Path.GetExtension(filePath).Equals(".xls", StringComparison.OrdinalIgnoreCase))
            {
                // Reading from a binary Excel file (97-2003 format; .xls)
                reader = ExcelReaderFactory.CreateBinaryReader(stream);
            }
            else if (Path.GetExtension(filePath).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                // Reading from an OpenXml Excel file (2007 format; .xlsx)
                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }
            else
            {
                // Unsupported file format
                MessageBox.Show("El formato del archivo no es compatible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Convert all sheets to a DataSet
            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            reader.Close();
            return result;
        }

        //...

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Workbook|*.xls;*.xlsx"; // Add support for both .xls and .xlsx
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cboHojas.Items.Clear();
                dtPlan2.DataSource = null;
                txtRuta.Text = ofd.FileName;

                // Read Excel file
                dtsTablas = ReadExcelFile(ofd.FileName);

                if (dtsTablas != null)
                {
                    // Get table names and add them to the combo box
                    foreach (DataTable tabla in dtsTablas.Tables)
                    {
                        cboHojas.Items.Add(tabla.TableName);
                    }
                    cboHojas.SelectedIndex = 0;
                    if (txtRuta.Text != "")
                    {
                        btnCargar.Enabled = true;
                    }
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dtPlan2.Columns.Clear();
            dtPlan2.DataSource = dtsTablas.Tables[cboHojas.SelectedIndex];
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
            InsertarTemas();
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
            panel12.Visible=false;
            panel13.Visible = false;
            ConfigurarDataGridView();
        }
            private void btnCerrar_Click(object sender, EventArgs e)
        {
            dtPlan2.DataSource = dtsTablas.Tables[""];
            pnPlan.Visible = false;
            PanelPaginado.Visible = true;
            panel4.Visible = true;
            panel12.Visible = true;
            panel13.Visible = true;
        }
        public void MostrarPlanD()
        {
            int idprofesor = Login.idprofesor;
            DataTable dt = new DataTable();
            DPlanDidactico funcion= new DPlanDidactico();
            funcion.MostrarPlanD(ref dt, idprofesor);
            dtPlanD.DataSource = dt;
            Diseñodt();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string SemanaI = (txtSemInicio.Text);
            string SemanaF = (txtSemFin.Text);
            string FechaI = dtFechaInico.Text;
            string FechaF = dtFechaFin.Text;
            string Objetivo = txtObj.Text;
            string Tema = txtCont.Text;
            string EA = cbEnseApren.Text;
            string FE = cbFormaEvaluacion.Text;
            string EE = cbEstrEvaluacion.Text;
            string Porcentaje = (txtPorcentaje.Text);
            dtPlan2.Rows.Add(new object[]
            {
                SemanaI,SemanaF,FechaI,FechaF,Objetivo,Tema, EA,FE, EE, Porcentaje
                //,Estado
            });
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
        private void ConfigurarDataGridView()
        {
            // Borramos todas las columnas actuales del DataGridView
            dtPlan2.Columns.Clear();

            // Configuramos las columnas con los encabezados deseados
            dtPlan2.Columns.Add("SemanaI", "Semana Inicio");
            dtPlan2.Columns.Add("SemanaF", "Semana Fin");
            dtPlan2.Columns.Add("FechaI", "Fecha Inicio");
            dtPlan2.Columns.Add("FechaF", "Fecha Fin");
            dtPlan2.Columns.Add("Objetivos", "Objetivos");
            dtPlan2.Columns.Add("Contenido", "Contenido");
            dtPlan2.Columns.Add("EstrApren", "Estrategia Aprendizaje");
            dtPlan2.Columns.Add("EstrategiaEvaluacion", "Estrategia Evaluacion");
            dtPlan2.Columns.Add("FormaEvaluacion", "Forma Evaluacion");
            dtPlan2.Columns.Add("Porcentaje", "%");
        }

        private void InsertarTemas()
        {
            try
            {
                List<LPlanDidactico> lst = new List<LPlanDidactico>();

                //LLenar
                foreach (DataGridViewRow dr in dtPlan2.Rows)
                {
                    LPlanDidactico oConcepto = new LPlanDidactico();
                    oConcepto.SemanaInicio = int.Parse(dr.Cells[0].Value.ToString());
                    oConcepto.SemanaFin = int.Parse(dr.Cells[1].Value.ToString());
                    oConcepto.FechaInicio = DateTime.Parse(dr.Cells[2].Value.ToString());
                    oConcepto.FechaFin = DateTime.Parse(dr.Cells[3].Value.ToString());
                    oConcepto.Objetivos = dr.Cells[4].Value.ToString();
                    oConcepto.Tema = dr.Cells[5].Value.ToString();
                    oConcepto.EA = dr.Cells[6].Value.ToString();
                    oConcepto.FE = dr.Cells[7].Value.ToString();
                    oConcepto.EE = dr.Cells[8].Value.ToString();
                    oConcepto.Porcentaje = decimal.Parse(dr.Cells[9].Value.ToString());
                    lst.Add(oConcepto);
                }
                LPlanDidactico parametros = new LPlanDidactico();
                parametros.IdAsignatura = (int)cbAsignaturas.SelectedValue;
                parametros.IdProfe = Login.idprofesor;
                parametros.IdCarrera = (int)cbCarrera.SelectedValue;
                parametros.IdModalidad = (int)cbModalidad.SelectedValue;
                parametros.IdGrupo = (int)cbGrupo.SelectedValue;
                parametros.IdSemestre = (int)cbSemestre.SelectedValue;
                DPlanDidactico funcion = new DPlanDidactico();
                funcion.InsertaTemas(parametros, lst);
                MessageBox.Show("Registro realizado", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarPlanD();
                pnPlan.Visible = false;
                PanelPaginado.Visible = true;
                panel4.Visible = true;
                panel12.Visible = true;
                panel13.Visible = true;
                dtPlan2.DataSource = dtsTablas.Tables[""];
                gbDatos.Dock = DockStyle.Top;
                dtPlan2.Rows.Clear();
                dtPlan2.Columns.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dtPlanD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtPlanD.Columns["VerPlan"].Index)
            {
                PasarIdPlan();                
            }
            if (e.ColumnIndex == dtPlanD.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro de eliminar este Plan Didáctico, Desea Continuar?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    EliminarPlanD();
                }
            }
        }
        /*Con este metodo obtenemos el id del plan que se ha seleccionado y
        se lo mandamos al formulario donde lo estaremos mostrando*/
        private void PasarIdPlan()
        {
            Asignatura = dtPlanD.SelectedCells[7].Value.ToString();
            IdPlan = Convert.ToInt32(dtPlanD.SelectedCells[4].Value);
            MostrarPlan mp = new MostrarPlan();
            mp.idplan = IdPlan;
            mp.ShowDialog();
        }
        private void EliminarPlanD()
        {
            IdPlan = Convert.ToInt32(dtPlanD.SelectedCells[4].Value);
            LPlanDidactico parametros = new LPlanDidactico();
            DPlanDidactico funcion = new DPlanDidactico();
            parametros.IdPlan = IdPlan;
            if (funcion.EliminarPlanD(parametros) == true)
            {
                MostrarPlanD();
            }
        }
       
    }
}

