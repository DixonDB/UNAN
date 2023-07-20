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
        LPlanDidactico plan = new LPlanDidactico();
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
            //dtPlanD.Columns["IdPlan"].Visible = false;
            //dtPlanD.Columns[3].Visible = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //CONFIGURACION DE LA VENTANA PARA BUSCAR EL ARCHIVO
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Worbook|*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cboHojas.Items.Clear();
                dtPlan2.DataSource = null;
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
            try
            {
                List<LPlanDidactico> lst = new List<LPlanDidactico>();

                //LLenar
                foreach(DataGridViewRow dr in dtPlan2.Rows)
                {
                    LPlanDidactico oConcepto = new LPlanDidactico();
                    oConcepto.SemanaInicio = int.Parse(dr.Cells[0].Value.ToString());
                    oConcepto.SemanaFin = int.Parse(dr.Cells[1].Value.ToString());
                    oConcepto.FechaInicio = (dr.Cells[2].Value.ToString());
                    oConcepto.FechaFin = (dr.Cells[3].Value.ToString());
                    oConcepto.Objetivos = dr.Cells[4].Value.ToString();
                    oConcepto.Tema= dr.Cells[5].Value.ToString();
                    oConcepto.EA= dr.Cells[6].Value.ToString();
                    oConcepto.FE= dr.Cells[7].Value.ToString();
                    oConcepto.EE= dr.Cells[8].Value.ToString();
                    oConcepto.Porcentaje = decimal.Parse(dr.Cells[9].Value.ToString());
                    oConcepto.Estado= dr.Cells[10].Value.ToString();
                    lst.Add(oConcepto);
                }

                int id = (int)cbAsignaturas.SelectedValue;
                DPlanDidactico oPlan = new DPlanDidactico();
                oPlan.Add(id,lst);
                MessageBox.Show("Registro realizado");
                pnPlan.Visible = false;
                PanelPaginado.Visible = true;
                panel4.Visible = true;
                dtPlan2.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var fecha = DateTime.Parse(dtFechaInico.Value.ToString("yyyy-MM-dd"));
            var fecha2 = DateTime.Parse(dtFechaFin.Value.ToString("yyyy-MM-dd"));
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
            string Estado = "ACTIVO";
            dtPlan2.Rows.Add(new object[]
            {
                SemanaI,SemanaF,FechaI,FechaF,Objetivo,Tema, EA,FE, EE, Porcentaje,Estado
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
        
    }
}
