using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.FrmPlanDidactico;
using UNAN.Logica;
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
            timer1.Enabled = true;
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
            label1.Visible = true;
            flBotones.Visible = true;
            flBotones.Location = new System.Drawing.Point(PnOpciones.Width / 2 - flBotones.Width / 2, PnOpciones.Height / 2 - flBotones.Height / 2);
            label1.Location = new System.Drawing.Point(panel2.Width / 2 - label1.Width / 2, panel2.Height / 2 - label1.Height / 2);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string asig = UCPlanDidactico.Asignatura;
            ExportarDataExcel(dtDetallePlan, asig);
        }

        private void ExportarDataExcel(DataGridView grd, string nombreArchivo)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
                saveFileDialog.FileName = nombreArchivo + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SLDocument sl = new SLDocument();
                    SLStyle style = new SLStyle();
                    style.Font.FontSize = 20;
                    style.Font.Bold = true;

                    // Encabezados de columnas
                    int ic = 1;
                    foreach (DataGridViewColumn column in grd.Columns)
                    {
                        // Omitir la columna "IdTema" en la exportación
                        if (column.HeaderText != "IdTema")
                        {
                           // sl.SetCellValue(1, ic, column.HeaderText.ToString());
                            sl.SetCellStyle(1, ic, style);
                            ic++;
                        }
                    }

                    // Datos del DataGridView (omitir la columna "IdTema")
                    int IR = 2;
                    foreach (DataGridViewRow row in grd.Rows)
                    {
                        int colIndex = 0;
                        for (int col = 0; col < grd.Columns.Count; col++)
                        {
                            // Omitir la columna "IdTema" en la exportación
                            if (grd.Columns[col].HeaderText != "IdTema")
                            {
                                // Guardar los datos en la celda correcta según la columna actual
                               // sl.SetCellValue(IR, colIndex + 1, row.Cells[col].Value.ToString());
                                colIndex++;
                            }
                        }
                        IR++;
                    }

                    // Ajustar el ancho de las columnas automáticamente
                    sl.AutoFitColumn(1, ic - 2); // Ajustar hasta ic - 2 para omitir la columna "IdTema"

                    // Guardar el archivo
                    sl.SaveAs(saveFileDialog.FileName);

                    MessageBox.Show("Datos exportados exitosamente a Excel", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbrCarga.Location = new System.Drawing.Point(this.Width / 2 - pbrCarga.Width / 2, this.Height / 2 - pbrCarga.Height / 2);
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

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dtDetallePlan.Rows.Count > 0)
            {
                string nombre = UCPlanDidactico.Asignatura;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = nombre + ".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No fue posible guardar los datos en el disco." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dtDetallePlan.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dtDetallePlan.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dtDetallePlan.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Datos exportados con éxito !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registro para exportar !!!", "Info");
            }
        }
    }
}
