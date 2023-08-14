using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UNAN.Logica;

namespace UNAN.Datos
{
    public class DAsignatura
    {

        /// <summary>
        /// Inserta un nuevo registro en la tabla Asignatura
        /// </summary>
        /// <param name="parametro"></param>
        /// <returns></returns>
        public bool InsertarAsignatura(LAsignatura parametro)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarAsignatura", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Asignatura", parametro.NombreA);
                cmd.Parameters.AddWithValue("@CodigoA", parametro.CodigoA);
                cmd.Parameters.AddWithValue("@IdCarrera", parametro.IdCarrera);
                cmd.Parameters.AddWithValue("@IdSemestre", parametro.IdSemestre);
                cmd.Parameters.AddWithValue("@IdGrupo", parametro.IdGrupo);
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

        /// <summary>
        /// Muestra las asignaturas desde la base de datos en un ComboBox que se autocompleta con dicha información.
        /// </summary>
        /// <param name="combo">El ComboBox en el cual se mostrarán las asignaturas.</param>
        /// <param name="semestre">El semestre para filtrar las asignaturas.</param>
        /// <param name="carrera">La carrera para filtrar las asignaturas.</param>
        /// <param name="grupo">El grupo para filtrar las asignaturas.</param>
        public void MostrarAsignatura(ComboBox combo, string semestre, string carrera, string grupo)
        {
            try
            {
                // Crear una colección para el autocompletado
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                // Abrir la conexión a la base de datos
                Conexion.abrir();

                // Crear el comando SQL para el procedimiento almacenado
                SqlCommand da = new SqlCommand("MostrarAsignaturas", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@Carrera", carrera);
                da.Parameters.AddWithValue("@Semestre", semestre);
                da.Parameters.AddWithValue("@Grupo", grupo);

                // Crear un adaptador para ejecutar el comando y llenar el DataTable
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);

                // Configurar el ComboBox para mostrar los datos
                combo.ValueMember = "IdAsignaturas";
                combo.DisplayMember = "NombreA";
                combo.DataSource = dt;

                // Agregar los datos a la colección de autocompletado
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["NombreA"].ToString());
                }

                // Asignar la colección de autocompletado al ComboBox
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                Conexion.cerrar();
            }
        }

        /// <summary>
        /// Muestra el codigo de la asignatura desde la base de datos
        /// </summary>
        /// <param name="asig">Asignatura de la cual se requiere el codigo</param>
        /// <param name="codi">Label donde se msotrará el codigo requerido</param>
        public void MostrarCodigoA(string asig, Label codi)
        {
            try
            {
                //Abrir la conexión a la base de datos
                Conexion.abrir();

                //Crear el comando SQL para el procedimiento almacenado
                SqlDataAdapter da = new SqlDataAdapter("MostrarCodigoA", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Cod", asig);

                //Crear el adapatador para el DataTable
                DataTable codigo = new DataTable();
                da.Fill(codigo);

                //Asignar el resultado obtenido al label
                if (codigo.Rows.Count > 0)
                {
                    codi.Text = codigo.Rows[0]["CodigoA"].ToString();
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
                //Cerrar la conexión a la base de datos
                Conexion.cerrar();
            }
        }
    }
}
