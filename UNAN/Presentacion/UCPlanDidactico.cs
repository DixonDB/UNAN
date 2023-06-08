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
using UNAN.Presentacion;

namespace UNAN.FrmPlanDidactico
{
    public partial class UCPlanDidactico : UserControl
    {
        //Un DataSet es un objeto que almacena n número de DataTables, estas tablas puedes estar conectadas dentro del dataset.
        private DataSet dtsTablas = new DataSet();
        DCarreras carreras = new DCarreras();
        public UCPlanDidactico()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            PCargarPlan.Visible = true;
            PCargarPlan.Size = new Size(511, 178);
            PCargarPlan.Location = new Point(282, 25);
        }

        private void txtSemFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            FrmCarrera carrera = new FrmCarrera();
            carrera.ShowDialog();
            carreras.MostrarCarrera(cbCarrera);
        }

        private void UCPlanDidactico_Load(object sender, EventArgs e)
        {
            carreras.MostrarCarrera(cbCarrera);
            Mostrarcod();
            lblCod.Visible = false;
        }
        public void Mostrarcod()
        {
            DCarreras funcion = new DCarreras();
            funcion.MostrarCodigoC(cbCarrera.Text, lblCod);
        }


        public void DiseñoInicial()
        {
            dtPlan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtPlan.MultiSelect = false;
            dtPlan.ReadOnly = true;
            dtPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtPlan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
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
    }
}
