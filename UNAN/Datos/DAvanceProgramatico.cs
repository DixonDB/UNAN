using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNAN.Logica;
using System.Security.RightsManagement;
using System.Data.SqlTypes;

namespace UNAN.Datos
{
    public class DAvanceProgramatico
    {
        public void MostrarUltimoTema(TextBox txt, int idProfesor, int idcarrera, int idasignatura)
        {
            try
            {

                Conexion.abrir();
                SqlCommand da = new SqlCommand("MostrarUltimoTema", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@IdProfesor", idProfesor);
                da.Parameters.AddWithValue("@IdCarrera", idcarrera);
                da.Parameters.AddWithValue("@IdAsignatura", idasignatura);
                SqlDataReader reader = da.ExecuteReader();
                if (reader.Read())
                {
                    string tema = reader["Tema"].ToString();
                    txt.Text = tema;
                }
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
        public void MostrarTemasAtrasados(ref DataTable dt,LAvanceProgramatico parametros)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarTemasAtrasados", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@IdProfesor", parametros.IdProfesor);
                da.SelectCommand.Parameters.AddWithValue("@IdCarrera", parametros.IdCarrera);
                da.SelectCommand.Parameters.AddWithValue("@IdAsignatura", parametros.IdAsignatura);
                da.Fill(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Conexion.cerrar(); }
        }
    }
}
