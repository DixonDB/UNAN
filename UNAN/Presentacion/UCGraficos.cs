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
using System.Threading.Tasks;
using System.Windows.Forms;
using UNAN.Datos;

namespace UNAN.Presentacion
{
    public partial class UCGraficos : UserControl
    {
        ArrayList Usuarios = new ArrayList();
        ArrayList Cant= new ArrayList();
        private int conteo;
        public UCGraficos()
        {
            InitializeComponent();
            conteo = 0;
        }

        private async void UCGraficos_Load(object sender, EventArgs e)
        {
            pncarga.Dock = DockStyle.Fill;
            timer1.Enabled = true;
            await CargarDatos();
            await Task.Delay(1000);
            pncarga.Visible = false;
        }
        public async Task CargarDatos()
        {
            await Task.Delay(1500);
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
    }
}
