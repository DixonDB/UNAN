using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNAN.Logica;

namespace UNAN.Datos
{
    public class DCarreras
    {
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
    }
}
