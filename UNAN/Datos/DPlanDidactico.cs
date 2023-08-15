using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UNAN.Logica;

namespace UNAN.Datos
{
    public class DPlanDidactico
    {
        /// <summary>
        /// La función "MostrarPlanD" recupera una DataTable que contiene los detalles del plan de un
        /// profesor de una base de datos utilizando un procedimiento almacenado.
        /// </summary>
        /// <param name="DataTable">El parámetro DataTable se utiliza para almacenar los datos
        /// recuperados de la base de datos. Se pasa por referencia para que cualquier cambio realizado
        /// en DataTable dentro del método también se refleje fuera del método.</param>
        /// <param name="idProfesor">La identificación del profesor para quien se debe mostrar el
        /// plan.</param>
        public void MostrarPlanD(ref DataTable dt,int idProfesor)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarPlanD", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Idprofesor", idProfesor);
                da.Fill(dt);
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
        /// La función "InsertarTemas" inserta una lista de temas en una tabla de base de datos.
        /// </summary>
        /// <param name="LPlanDidactico">LPlanDidactico es una clase que representa un plan de
        /// enseñanza. Contiene propiedades como IdProfe (ID del docente), IdCarrera (ID de la carrera),
        /// IdAsignatura (ID de la asignatura), IdModalidad (ID del modo de enseñanza), IdGrupo (ID del
        /// grupo) e IdSem</param>
        /// <param name="lst">El parámetro "lst" es una lista de objetos LPlanDidactico. Cada objeto
        /// representa un conjunto de parámetros para insertar una fila en la tabla "Temas".</param>
        public void InsertaTemas(LPlanDidactico parametros, List<LPlanDidactico> lst)
        {
            var dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("SemanaI");
            dt.Columns.Add("SemanaF");
            dt.Columns.Add("FechaI");
            dt.Columns.Add("FechaF");
            dt.Columns.Add("Objetivos");
            dt.Columns.Add("Tema");
            dt.Columns.Add("EstrategiaAprendizaje");
            dt.Columns.Add("FormaEvaluacion");
            dt.Columns.Add("EstrategiaEvaluacion");
            dt.Columns.Add("Porcetaje");
            dt.Columns.Add("Estado");

            int i = 1;
            foreach (var oElement in lst)
            {
                dt.Rows.Add(i, oElement.SemanaInicio, oElement.SemanaFin, oElement.FechaInicio, oElement.FechaFin,
                oElement.Objetivos, oElement.Tema, oElement.EA, oElement.FE, oElement.EE, oElement.Porcentaje
                , oElement.Estado);
                i++;
            }

            Conexion.abrir();
            SqlCommand cmd = new SqlCommand("InsertarPlanYTemas", Conexion.conectar);
            var parameterlst = new SqlParameter("@lstTemas", SqlDbType.Structured);
            parameterlst.TypeName = "Temas";
            parameterlst.Value = dt;
            cmd.CommandType=CommandType.StoredProcedure;

            cmd.Parameters.Add(parameterlst);
            cmd.Parameters.AddWithValue("@IdProfe", parametros.IdProfe);
            cmd.Parameters.AddWithValue("@IdCarrera", parametros.IdCarrera);
            cmd.Parameters.AddWithValue("@IdAsignatura", parametros.IdAsignatura);
            cmd.Parameters.AddWithValue("@IdModalidad", parametros.IdModalidad);
            cmd.Parameters.AddWithValue("@IdGrupo", parametros.IdGrupo);
            cmd.Parameters.AddWithValue("@IdSemestre", parametros.IdSemestre);
            cmd.ExecuteNonQuery();
            Conexion.cerrar();
        }

        
        /// <summary>
        /// La función "DetallePlan" recupera los detalles de un plan de una base de datos y llena un
        /// DataTable con los resultados.
        /// </summary>
        /// <param name="DataTable">El parámetro DataTable se usa para pasar una referencia a un objeto
        /// DataTable. Este objeto DataTable se llenará con datos recuperados de la base de
        /// datos.</param>
        /// <param name="idPlan">La identificación del plan para el que desea recuperar los
        /// detalles.</param>
        public void DetallePlan( ref DataTable dt,int idPlan)
        {
            {
                try
                {
                    Conexion.abrir();
                    SqlDataAdapter da = new SqlDataAdapter("MostrarDetallePlan", Conexion.conectar);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@IdPlan", idPlan);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Conexion.cerrar();
                }
            }
        }
        /// <summary>
        /// Esta función se usa para eliminar un plan de una base de datos mediante un
        /// procedimiento almacenado.
        /// </summary>
        /// <param name="LPlanDidactico">LPlanDidactico es una clase o estructura de datos que contiene
        /// la información necesaria para eliminar un plan.</param>
        /// <returns>
        /// El método devuelve un valor booleano. Si la ejecución del código dentro del bloque try es
        /// exitosa, devolverá verdadero. Si ocurre una excepción, mostrará un cuadro de mensaje con el
        /// mensaje de excepción y devolverá falso.
        /// </returns>
        public bool EliminarPlanD(LPlanDidactico parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("EliminarPlanD", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPlan", parametros.IdPlan);
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
        /// La función "EditarPlanD" toma una lista de parámetros y una lista de objetos, convierte los
        /// objetos en un DataTable y luego ejecuta un procedimiento almacenado con el DataTable y los
        /// parámetros.
        /// </summary>
        /// <param name="LPlanDidactico">LPlanDidactico es una clase que representa un plan didáctico
        /// (plan didáctico) con las siguientes propiedades:</param>
        /// <param name="lst">Una lista de objetos LPlanDidactico que contiene los datos a
        /// editar.</param>
        public void EditarPlanD(LPlanDidactico parametros, List<LPlanDidactico> lst)
        {
            var dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("SemanaI");
            dt.Columns.Add("SemanaF");
            dt.Columns.Add("FechaI");
            dt.Columns.Add("FechaF");
            dt.Columns.Add("Objetivos");
            dt.Columns.Add("Tema");
            dt.Columns.Add("EstrategiaAprendizaje");
            dt.Columns.Add("FormaEvaluacion");
            dt.Columns.Add("EstrategiaEvaluacion");
            dt.Columns.Add("Porcetaje");
            dt.Columns.Add("Estado");

            foreach (var oElement in lst)
            {
                dt.Rows.Add(oElement.IdTema, oElement.SemanaInicio, oElement.SemanaFin, oElement.FechaInicio, oElement.FechaFin,
                oElement.Objetivos, oElement.Tema, oElement.EA, oElement.FE, oElement.EE, oElement.Porcentaje
                , oElement.Estado);
            }

            Conexion.abrir();
            SqlCommand cmd = new SqlCommand("EditarPlanD", Conexion.conectar);
            var parameterlst = new SqlParameter("@lstTemas", SqlDbType.Structured);
            parameterlst.TypeName = "Temas";
            parameterlst.Value = dt;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(parameterlst);
            cmd.Parameters.AddWithValue("@IdPlan", parametros.IdPlan);
            cmd.ExecuteNonQuery();
            Conexion.cerrar();
        }
    }
}
