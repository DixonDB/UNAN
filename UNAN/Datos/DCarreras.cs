using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using UNAN.Logica;

namespace UNAN.Datos
{
    public class DCarreras
    {
		public string cod;
        private DataSet dt;

        public bool InsertarCarrera(LCarreras parametros)
		{
			try
			{
				Conexion.abrir();
				SqlCommand cmd = new SqlCommand("Insertar_Carrera", Conexion.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@NombreC", parametros.NombreC);
				cmd.Parameters.AddWithValue("@CodigoC", parametros.CodigoC);
				cmd.Parameters.AddWithValue("@IdModalidad", parametros.IdModalidad);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
			finally
			{
				Conexion.cerrar();
			}
		}

		public void MostrarCarrera(ComboBox combo)
		{
			Conexion.abrir();
			SqlCommand da = new SqlCommand("MostrarCarrera", Conexion.conectar);
			da.CommandType= CommandType.StoredProcedure;
			SqlDataAdapter cb = new SqlDataAdapter(da);
			DataTable dt = new DataTable();
			cb.Fill(dt);
			combo.ValueMember = "IdCarreras";
			combo.DisplayMember = "NombreC";
			combo.DataSource = dt;

        }

        public void MostrarCodigoC(string carr, Label codi)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarCodigoC", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Cod", carr);
                DataTable codigo = new DataTable();
                da.Fill(codigo);

                if (codigo.Rows.Count > 0)
                {
                    codi.Text = codigo.Rows[0]["CodigoC"].ToString();
                }
                else
                {
                    codi.Text = "No se encontró el código";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion.cerrar();
            }
        }

    }
}
