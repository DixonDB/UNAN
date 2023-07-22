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
        public void InsertaTemas(int IdAsignatura, int IdProfe, List<LPlanDidactico> lst)
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
            SqlCommand cmd = new SqlCommand("InsertarTemas", Conexion.conectar);
            var parameterlst = new SqlParameter("@lstTemas", SqlDbType.Structured);
            parameterlst.TypeName = "Temas";
            parameterlst.Value = dt;
            cmd.CommandType=CommandType.StoredProcedure;

            cmd.Parameters.Add(parameterlst);
            cmd.Parameters.AddWithValue("@IdAsignatura", IdAsignatura);
            cmd.Parameters.AddWithValue("@IdProfesor", IdProfe);
            cmd.ExecuteNonQuery();
            Conexion.cerrar();
        }

        public bool InsertarPlanD(LPlanDidactico parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarPlanD", Conexion.conectar);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProfe", parametros.IdProfe);
                cmd.Parameters.AddWithValue("@IdCarrera", parametros.IdCarrera);
                cmd.Parameters.AddWithValue("@IdAsignatura", parametros.IdAsignatura);
                cmd.Parameters.AddWithValue("@IdModalidad", parametros.IdModalidad);
                cmd.Parameters.AddWithValue("@IdGrupo", parametros.IdGrupo);
                cmd.Parameters.AddWithValue("@IdSemestre", parametros.IdSemestre);
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
    }
}
