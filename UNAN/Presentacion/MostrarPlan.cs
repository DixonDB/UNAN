using Microsoft.Office.Interop.Excel;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.FrmPlanDidactico;
using UNAN.Logica;
using DataTable = System.Data.DataTable;

namespace UNAN.Presentacion
{
    public partial class MostrarPlan : Form
    {
        public int idplan;
        UCPlanDidactico planD=new UCPlanDidactico();
        public string Asig;
        public MostrarPlan()
        {
            InitializeComponent();
        }
        private void MostrarPlan_Load(object sender, EventArgs e)
        {
            Bases.DiseñoDtv(ref dtDetallePlan);
            CargarDatos();
            Centrar_botones();
        }
        public void CargarDatos()
        {
            int idPLAN = idplan;
            DataTable dt = new DataTable();
            DPlanDidactico funcion = new DPlanDidactico();
            funcion.DetallePlan(ref dt, idPLAN);
            dtDetallePlan.DataSource = dt;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void Centrar_botones()
        {
            flBotones.Location=new System.Drawing.Point(PnOpciones.Width/2-flBotones.Width/2, PnOpciones.Height/2-flBotones.Height/2);
        }
        private void ExportarDataGridViewExcel(DataGridView grd, string nombreArchivo)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Workbook libros_trabajo;
                Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Worksheet)libros_trabajo.Worksheets.get_Item(1);

                // Agregar encabezados a la hoja de trabajo
                for (int j = 0; j < grd.Columns.Count; j++)
                {
                    hoja_trabajo.Cells[1, j + 1] = grd.Columns[j].HeaderText;
                }

                // Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }

                libros_trabajo.SaveAs(nombreArchivo, XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();

                // Liberar recursos de Excel (opcional)
                Marshal.ReleaseComObject(hoja_trabajo);
                Marshal.ReleaseComObject(libros_trabajo);
                Marshal.ReleaseComObject(aplicacion);
                MessageBox.Show("Datos exportados exitosamente a Excel","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";

            // Aquí asignas el valor de tu variable al FileName

            string asig = UCPlanDidactico.Asignatura;
            string nombreArchivo = asig; // Reemplaza "MiArchivo.xls" con el valor de tu variable
            fichero.FileName = nombreArchivo;

            if (fichero.ShowDialog() == DialogResult.OK)
            {
                ExportarDataGridViewExcel(dtDetallePlan, fichero.FileName);
            }
        }
    }
}
