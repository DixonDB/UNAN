using System;
using System.Data;
using System.Data.SqlClient;
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

		public void MostrarCarrera(ComboBox combo,string modalidad)
		{
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conexion.abrir();
                SqlCommand da = new SqlCommand("MostrarCarrera", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@Mod", modalidad);
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);
                combo.ValueMember = "IdCarreras";
                combo.DisplayMember = "NombreC";
                combo.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["NombreC"].ToString());
                }
                combo.AutoCompleteCustomSource= lista;
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
                    codi.Text = "--";
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
