using ExcelDataReader;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Security.Policy;
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
        public UCPlanDidactico()
        {
            InitializeComponent();
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

        private void UCPlanDidactico_Load(object sender, EventArgs e)
        {
            carreras.MostrarCarrera(cbCarrera, cbModalidad.Text);
            Mostrarcod();
            mod.MostrarModalidades(cbModalidad);
            mod.MostrarGrupos(cbGrupo,cbCarrera.Text);
            Diseñodt();
            mod.MostrarSemestre(cbSemestre);
        }
        private void Mostrarcod()
        {
            DCarreras funcion = new DCarreras();
            funcion.MostrarCodigoC(cbCarrera.Text, lblCod);
        }
        private void Diseñodt()
        {
            Bases.DiseñoDtv(ref dtPlan);

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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAsignatura asig = new FrmAsignatura();
            asig.ShowDialog();
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
    }
}
