using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UNAN.Logica;
using System.Windows.Forms;
using System;

namespace UNAN.Datos
{
    public class DAsistencia
    {
       /// <summary>
       /// Insertar un nuevo registro de asistencia en la base de datos
       /// </summary>
       /// <param name="parametros">Datos necesarios para el registro</param>
       /// <param name="lst">Se crea una lista con los parametros la cual es la que recibe la base de datos</param>
        public void Insertaasistencias(LAsis parametros, List<LAsis> lst)
        {
            try
            {
                //Se crea el DataTable con los campos necesarios
                var dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add("IdAsignatura");
                dt.Columns.Add("IdTema");

                int i = 1;

                //Se recorre la lista agregando los parametros que seran enviados a la base de datos
                foreach (var oElement in lst)
                {
                    dt.Rows.Add(i, oElement.IdAsignatura, oElement.IdTema);
                    i++;
                }

                //Se abre la conexión a la base de datos
                Conexion.abrir();

                //Crear el comando para el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("InsertarAsistenciaYBloques", Conexion.conectar);
                var parameterlst = new SqlParameter("@ltsAsistencias", SqlDbType.Structured)
                {
                    TypeName = "Asistencias2",
                    Value = dt
                };

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(parameterlst);
                cmd.Parameters.AddWithValue("@IdProfesor", parametros.IdProfesor);
                cmd.Parameters.AddWithValue("@Fecha", parametros.Fecha);
                cmd.Parameters.AddWithValue("@Bloques", parametros.Bloques);
                cmd.Parameters.AddWithValue("@HoraI", parametros.HoraInicio);
                cmd.Parameters.AddWithValue("@HoraF", parametros.HoraFin);
                cmd.Parameters.AddWithValue("@Observacion", parametros.Observacion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Se cierra la conexión a la base de datos
                Conexion.cerrar();  
            }

        }

        /// <summary>
        /// Muestra los registros de asistencia filtrado por profesor
        /// </summary>
        /// <param name="dt">Tabla que contiene los datos requeridos</param>
        /// <param name="idProfesor">El idProfesor para filtrar la información de asistencia</param>
        public void MostrarAsistencia(ref DataTable dt, int idProfesor)
        {
            try
            {
                //Se abre la conexión a la base de datos
                Conexion.abrir();

                //Crea el comando para el procedimiento almacenado
                SqlDataAdapter da = new SqlDataAdapter("MostrarAsistencia", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@IdProfesor", idProfesor);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Se cierra la conexión a la base de datos
                Conexion.cerrar();
            }
        }

        /// <summary>
        /// Muestra el detalle de asistencia que corresponde a un registro de asistencia
        /// </summary>
        /// <param name="dt">Tabla con los resultados requeridos</param>
        /// <param name="idAsistencia">El idAsistencia para filtrar los detalles de asistencia</param>
        public void MostrarDetalleAsistencia(ref DataTable dt, int idAsistencia)
        {
            try
            {
                //Se abre la conexión a la base de datos
                Conexion.abrir();

                //Crea el comando SQL para el procedimiento almacenado
                SqlDataAdapter da = new SqlDataAdapter("MostrarDetalleAsistencia", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@IdAsistencia", idAsistencia);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Se cierra la conexión a la base de datos
                Conexion.cerrar();
            }
        }

        /// <summary>
        /// Mustra las carreras que correspondan a un profesor en un comnbobox que se autocompleta con dicha información.
        /// </summary>
        /// <param name="combo">El combobox en el cual se mostrarán las carreras.</param>
        /// <param name="Idprofe">El idprofe para filtrar las carreras.</param>
        /// <param name="Modalidad">La Modalidad para filtrar las carreras.</param>
        /// <param name="Semestre">El Semestre para filtrar las carreras.</param>
        public void CarreraXProfesor(ComboBox combo, int Idprofe, string Modalidad, string Semestre)
        {
            try
            {
                //Crear una colección para el autocompletado
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                //Abrir la conexión a la base de datos
                Conexion.abrir();

                //Crear el comando SQL para el procedimiento almacenado
                SqlCommand da = new SqlCommand("CarreraXProfesor", Conexion.conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                da.Parameters.AddWithValue("@IdProfesor", Idprofe);
                da.Parameters.AddWithValue("@Modalidad", Modalidad);
                da.Parameters.AddWithValue("@Semestre", Semestre);

                //Crear el adapatador para ejecutar el comando y llenar el DataTable
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);

                //Configurar el combobox para mostrara los datos
                combo.ValueMember = "IdCarreras";
                combo.DisplayMember = "NombreC";
                combo.DataSource = dt;

                //Agregar los datos a la coleccion de autocompletado
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["NombreC"].ToString());
                }

                //Asignar la coleccion de autocompletado al combobox
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Carrera " + ex.Message);
            }
            finally
            {
                //Cerrar la conexión a la base de datos
                Conexion.cerrar();
            }
        }

        /// <summary>
        /// Muestra las asignaturas correspondintes a un profesor desde la base de datos en un ComboBox que se autocompleta con dicha información.
        /// </summary>
        /// <param name="combo">El combobox que mostrará la información</param>
        /// <param name="Idprofe">El idprofe para filtrar las Asignaturas</param>
        /// <param name="Modalidad">La Modalidad para filtra las asignturas</param>
        /// <param name="Carrera">La carrera para filtrar las asignaturas</param>
        /// <param name="Semestre">El semestres para filtrar las asignaturas</param>
        public void AsignaturaXProfesor(ComboBox combo, int Idprofe, string Modalidad, string Carrera, string Semestre)
        {
            try
            {
                //Crear una colección para el autocompletado
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                //Abrir la conexión a la base de datos
                Conexion.abrir();

                //Crea el comando SQL para el procedimiento almacenado
                SqlCommand da = new SqlCommand("AsignaturaXProfesor", Conexion.conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                da.Parameters.AddWithValue("@IdProfesor", Idprofe);
                da.Parameters.AddWithValue("@Modalidad", Modalidad);
                da.Parameters.AddWithValue("@Carrera", Carrera);
                da.Parameters.AddWithValue("@Semestre", Semestre);

                //Crea el adaptador para ejecutar el comando y llenar el DataTable
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);

                //Configurar el combobox para mostrar los datos
                combo.ValueMember = "IdAsignaturas";
                combo.DisplayMember = "NombreA";
                combo.DataSource = dt;

                //Agreagr los datos a la colección
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["NombreA"].ToString());
                }

                //Asignar la colección al combobox
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en asignatura " + ex.Message);
            }
            finally
            {
                //Cerrar la conexión a la base de datos
                Conexion.cerrar();
            }
        }

        /// <summary>
        /// Muestra las modalidades de un porfesor desde la base de datos en un ComboBox que se autocompleta con dicha información.
        /// </summary>
        /// <param name="combo">El combobox en el cual se mostrarán las modalidades</param>
        /// <param name="idprofe">El idprofe para filtrar las modalidades</param>
        public void ModalidadXProfesor(ComboBox combo, int idprofe)
        {
            try
            {
                //Crea la colección para el autocompletado
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                //Abrir la conexion a la base de datos
                Conexion.abrir();

                //Creal el comando SQL para el procedimiento almacenado
                SqlCommand da = new SqlCommand("ModalidadXProfesor", Conexion.conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                da.Parameters.AddWithValue("@IdProfesor", idprofe);

                //Crea el adaptador para ejecutar el comando y llenar el DataTable
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);

                //Configurar el combobox para mostrar los datos
                combo.ValueMember = "IdModalidad";
                combo.DisplayMember = "Modalidad";
                combo.DataSource = dt;

                //Agregar los datos a la colección de autocompletado
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["Modalidad"].ToString());
                }

                //Asignar la colección de autocompletado al combobox
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Modalidad " + ex.Message);
            }
            finally
            {
                //Cerrar la conexión a la base de datos
                Conexion.cerrar();
            }
        }

        /// <summary>
        /// Muestra los semestre por profesor desde la base de datos en un ComboBox que se autocompleta con dicha información.
        /// </summary>
        /// <param name="combo">El combobox en el cual se mostrarán los semestres</param>
        /// <param name="idprofe">El idprofe para filtrar los semestres</param>
        public void SemestreXProfesor(ComboBox combo, int idprofe)
        {
            try
            {
                //Crear la coleccion de autocompletado
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                //Abrir la conexión a la base de datos
                Conexion.abrir();

                //Crear el comando SQL para el procedimiento almacenado
                SqlCommand da = new SqlCommand("SemestreXProfesor", Conexion.conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                da.Parameters.AddWithValue("@IdProfesor", idprofe);

                //Crear el adaptador para ejecutar el comando y llenar el DataTable
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);

                //Configurar el combobox para mostrar los datos
                combo.ValueMember = "IdSemestre";
                combo.DisplayMember = "Semestre";
                combo.DataSource = dt;

                //Agregar los datos a la colección de autocompletado
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["Semestre"].ToString());
                }

                //ASignar la colección de autocompletado al combobox
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Semestre " + ex.Message);
            }
            finally
            {
                //Cerrar la conexión a la base de datos
                Conexion.cerrar();
            }
        }

        /// <summary>
        /// Muestra los temas de un profesor desde la base de datos en un ComboBox que se autocompleta con dicha información.
        /// </summary>
        /// <param name="combo">El combobox en el cual se mostrarán los temas</param>
        /// <param name="carrera">La carrera para filtrar los temas</param>
        /// <param name="asig">La asignatura para filtrar los temas</param>
        /// <param name="grupo">El gruupo para filtrar los temas</param>
        /// <param name="IdProfe">El idprofe para filtrar los temas</param>
        /// <param name="semestre">El semestre para filtrar los temas</param>
        public void MostrarTemas(ComboBox combo, string carrera, string asig, string grupo, int IdProfe, string semestre)
        {
            try
            {
                //Crear la colección para el autocompletado
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                //Abrir la conexión a la base de datos
                Conexion.abrir();

                //Crear el comando SQL para el procedimiento almacenado
                SqlCommand da = new SqlCommand("MostrarTemas", Conexion.conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                da.Parameters.AddWithValue("@carrera", carrera);
                da.Parameters.AddWithValue("@IdProfesor", IdProfe);
                da.Parameters.AddWithValue("@Asignatura", asig);
                da.Parameters.AddWithValue("@Grupo", grupo);
                da.Parameters.AddWithValue("@Semestre", semestre);

                //Crear el adapatador para ejecutar el comando y llenar el DataTable
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);

                //Configurar el combobox para mostrar los datos
                combo.ValueMember = "IdTema";
                combo.DisplayMember = "Tema";
                combo.DataSource = dt;

                //Agregar los datos a la colección de autocompletado
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["Tema"].ToString());
                }

                //Asignar la colección de autocompletado al combobox
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Cerrar la conexión a la base de datos
                Conexion.cerrar();
            }
        }

        /// <summary>
        /// Muestra los grupos por profesor desde la base de datos en un ComboBox que se autocompleta con dicha información.
        /// </summary>
        /// <param name="combo">El combobox en el cual de mostrarán los grupos</param>
        /// <param name="carrera">La carrera para filtrar los grupos</param>
        /// <param name="IdProfe">El idprofe para filtrar los grupos</param>
        public void GrupoXProfesor(ComboBox combo, string carrera, int IdProfe)
        {
            try
            {
                //Crear la colección para el autocompletado
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                //Abrir la conexión a la base de datos
                Conexion.abrir();

                //Crear el comando SQL apar el procedimiento almacenado
                SqlCommand da = new SqlCommand("GrupoXProfesor", Conexion.conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                da.Parameters.AddWithValue("@carrera", carrera);
                da.Parameters.AddWithValue("@IdProfesor", IdProfe);

                //CRear el adaptador para ejecutar el comando y llenar el DataTable
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);

                //Configurar el combobox para mostrar los datos
                combo.ValueMember = "IdGrupo";
                combo.DisplayMember = "Grupo";
                combo.DataSource = dt;

                //Agregar los datos a la colección de autocompletado
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["Grupo"].ToString());
                }

                //Asignar la colección de autocompletado al combobox
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en GrupoXProfesor " + ex.Message);
            }
            finally
            {
                //Cerrar la conexion a la base de datos
                Conexion.cerrar();
            }
        }

    }

}
