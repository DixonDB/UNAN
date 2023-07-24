using Microsoft.Office.Interop.Excel;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.FrmPlanDidactico;
using UNAN.Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using DataTable = System.Data.DataTable;

namespace UNAN.Presentacion
{
    public partial class MostrarPlan : Form
    {
        private int conteo;
        public int idplan;
        UCPlanDidactico planD=new UCPlanDidactico();
        public string Asig;
        DataTable dt = new DataTable();
        public MostrarPlan()
        {
            InitializeComponent();
        }
        private async void MostrarPlan_Load(object sender, EventArgs e)
        {
            pncarga.Dock = DockStyle.Fill;
            Bases.DiseñoDtv(ref dtDetallePlan);
            await CargarDatos();
            pncarga.Visible = false; // Ocultar el PictureBox cuando los datos estén cargados
            dtDetallePlan.DataSource = dt;
            dtDetallePlan.Columns[0].Visible = false;

            Centrar_botones();
        }
        public async Task CargarDatos()
        {
            await Task.Delay(1500);
            int idPLAN = idplan;
            DPlanDidactico funcion = new DPlanDidactico();
            funcion.DetallePlan(ref dt, idPLAN);
            await Task.Delay(1000);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void Centrar_botones()
        {
            flBotones.Location = new System.Drawing.Point(PnOpciones.Width / 2 - flBotones.Width / 2, PnOpciones.Height / 2 - flBotones.Height / 2);
            label1.Location = new System.Drawing.Point(panel2.Width / 2 - label1.Width / 2, panel2.Height / 2 - label1.Height / 2);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text=="Editar")
            {
                btnGuardar.Text = "Actualizar";
                label1.Text = "Editar Temas";
                dtDetallePlan.ReadOnly= false;
            }
            else
            {
                EditarPlanD();
                dtDetallePlan.ReadOnly = true;
            }
        }
        private void EditarPlanD()
        {
            try
            {
                List<LPlanDidactico> lst = new List<LPlanDidactico>();

                //LLenar
                foreach (DataGridViewRow dr in dtDetallePlan.Rows)
                {
                    LPlanDidactico oConcepto = new LPlanDidactico();
                    oConcepto.IdTema = int.Parse(dr.Cells[0].Value.ToString());
                    oConcepto.SemanaInicio = int.Parse(dr.Cells[1].Value.ToString());
                    oConcepto.SemanaFin = int.Parse(dr.Cells[2].Value.ToString());
                    oConcepto.FechaInicio = DateTime.Parse(dr.Cells[3].Value.ToString());
                    oConcepto.FechaFin = DateTime.Parse(dr.Cells[4].Value.ToString());
                    oConcepto.Objetivos = dr.Cells[5].Value.ToString();
                    oConcepto.Tema = dr.Cells[6].Value.ToString();
                    oConcepto.EA = dr.Cells[7].Value.ToString();
                    oConcepto.FE = dr.Cells[8].Value.ToString();
                    oConcepto.EE = dr.Cells[9].Value.ToString();
                    oConcepto.Porcentaje = decimal.Parse(dr.Cells[10].Value.ToString());
                    lst.Add(oConcepto);
                }
                LPlanDidactico parametros = new LPlanDidactico();
                parametros.IdPlan = idplan;
                DPlanDidactico funcion = new DPlanDidactico();
                funcion.EditarPlanD(parametros, lst);
                MessageBox.Show("Registro Editado", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Text = "Editar";
                label1.Text = "Detalle Plan Didáctico";
                planD.MostrarPlanD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
