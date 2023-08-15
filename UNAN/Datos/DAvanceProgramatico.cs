using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UNAN.Logica;

namespace UNAN.Datos
{
    public class DAvanceProgramatico
    {
        /// <summary>
        /// Muestra el ultimo tema por profesor desde la base de datos en un ComboBox que se autocompleta con dicha información.
        /// </summary>
        /// <param name="txt">El combobox en el cual se mostrará el último tema</param>
        /// <param name="idProfesor">El idprofesor para filtrar el tema</param>
        /// <param name="idcarrera">El idcarrera para filtrar el tema</param>
        /// <param name="idasignatura">El idasignatura para filtrar el tema</param>
        public void MostrarUltimoTema(TextBox txt, int idProfesor, int idcarrera, int idasignatura)
        {
            try
            {
                //Abrir la conexión a la base de datos
                Conexion.abrir();

                //Crear el comando SQL para el procedimiento almacenado
                SqlCommand da = new SqlCommand("MostrarUltimoTema", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@IdProfesor", idProfesor);
                da.Parameters.AddWithValue("@IdCarrera", idcarrera);
                da.Parameters.AddWithValue("@IdAsignatura", idasignatura);
                SqlDataReader reader = da.ExecuteReader();

                //Ejecutar el comando y leer el resultado
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
                //Cerrar la conexión a l abase de datos
                Conexion.cerrar();
            }
        }

        /// <summary>
        /// Muestra los temas no impartidos por profesor desde la base de datos en un DataTable que se autocompleta con dicha información.
        /// </summary>
        /// <param name="dt">DataTable en el cual se mostrarán los datos</param>
        /// <param name="parametros">Variables de filtro para los temas</param>
        public void MostrarTemasAtrasados(ref DataTable dt,LAvanceProgramatico parametros)
        {
            try
            {
                //Abrir la conexión a la base de datos
                Conexion.abrir();

                //Cerar el comando SQL para el procedimiento almacenado
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
            finally
            { 
                //Cerrar la conexión a la bade de datos
                Conexion.cerrar(); 
            }
        }
    }
}
