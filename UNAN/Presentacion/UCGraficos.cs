using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using UNAN.Datos;

namespace UNAN.Presentacion
{
    public partial class UCGraficos : UserControl
    {
        ArrayList Usuarios = new ArrayList();
        ArrayList Cant= new ArrayList();
        public UCGraficos()
        {
            InitializeComponent();
        }

        private void UCGraficos_Load(object sender, EventArgs e)
        {
            carga();
            GraficoUsuarios();
            ObtenerTotalUsuarios();
        }

        private void GraficoUsuarios()
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("CantRoles", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd= cmd.ExecuteReader();
                //cmd.ExecuteNonQuery();
                while (rd.Read())
                {
                    Usuarios.Add(rd.GetString(0));
                    Cant.Add(rd.GetInt32(1));
                }
                chartUsuariosRol.Series[0].Points.DataBindXY(Usuarios, Cant);
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        public int ObtenerTotalUsuarios()
        {
            int totalUsuarios = 0;
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("TotalUsuarios", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter outputParameter = new SqlParameter("@TotalUsuarios", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParameter);

                cmd.ExecuteNonQuery();

                totalUsuarios = (int)outputParameter.Value;
                lblCantUsuarios.Text = totalUsuarios.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el total de usuarios: " + ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
            return totalUsuarios;
        }
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
            pncarga.Visible = false;
        }
    }
}
