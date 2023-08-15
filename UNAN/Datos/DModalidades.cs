using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UNAN.Logica;

namespace UNAN.Datos
{
    public class DModalidades
    {
       /// <summary>
       /// La función "MostrarModalidades" recupera datos de una base de datos y completa un control
       /// ComboBox con los datos recuperados, al mismo tiempo que configura la funcionalidad de
       /// autocompletar para el ComboBox.
       /// </summary>
       /// <param name="ComboBox">El parámetro ComboBox es un control en la interfaz de usuario que
       /// permite al usuario seleccionar un elemento de una lista de opciones. En este caso, el método
       /// utiliza el control ComboBox para mostrar una lista de modalidades.</param>
        public void MostrarModalidades(ComboBox combo)
        {
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conexion.abrir();
                SqlCommand da = new SqlCommand("MostrarModalidad", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);
                combo.ValueMember = "IdModalidad";
                combo.DisplayMember = "Modalidad";
                combo.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["Modalidad"].ToString());
                }
                combo.AutoCompleteCustomSource = lista;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        /// <summary>
        /// La función InsertarGrupo inserta un nuevo grupo en una tabla de base de datos mediante un
        /// procedimiento almacenado y devuelve un valor booleano que indica el éxito de la operación.
        /// </summary>
        /// <param name="LModalidad">LModalidad es una clase que representa un tipo específico de
        /// modalidad. Contiene propiedades como "Grupo" (nombre del grupo) e "IdCarrera"
        /// (identificación de la carrera).</param>
        /// <returns>
        /// El método devuelve un valor booleano.
        /// </returns>
        public bool InsertarGrupo(LModalidad parametro)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarGrupo", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreGrupo", parametro.Grupo);
                cmd.Parameters.AddWithValue("@IdCarreras", parametro.IdCarrera);

                SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.VarChar, 100);
                mensajeParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(mensajeParam);

                cmd.ExecuteNonQuery();

                string mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                if (!string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
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
        /// La función "MostrarGrupos" recupera y muestra una lista de grupos basados en una carrera
        /// determinada en un control ComboBox.
        /// </summary>
        /// <param name="ComboBox">El parámetro ComboBox se usa para mostrar la lista de grupos en un
        /// menú desplegable. Se puede acceder al grupo seleccionado a través de este parámetro.</param>
        /// <param name="carrera">El parámetro "carrera" es una cadena que representa la carrera o
        /// especialidad para la cual se deben mostrar los grupos.</param>
        public void MostrarGrupos(ComboBox combo,string carrera)
        {
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conexion.abrir();
                SqlCommand da = new SqlCommand("MostrarGrupo", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@carrera", carrera);
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);
                combo.ValueMember = "IdGrupo";
                combo.DisplayMember = "Grupo";
                combo.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["Grupo"].ToString());
                }
                combo.AutoCompleteCustomSource = lista;
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
        /// <summary>
        /// La función "MostrarSemestre" recupera datos de una base de datos y llena un ComboBox con los
        /// semestres.
        /// </summary>
        /// <param name="ComboBox">El parámetro ComboBox se usa para pasar una referencia al control
        /// ComboBox que mostrará los semestres.</param>
        public void MostrarSemestre(ComboBox combo)
        {
            try
            {
                Conexion.abrir();
                SqlCommand da = new SqlCommand("MostrarSemestre", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);
                combo.ValueMember = "IdSemestre";
                combo.DisplayMember = "Semestre";
                combo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }
        
    }
}
