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
        public void Add(int IdAsignatura,List<LPlanDidactico> lst)
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
                var fecha = oElement.FechaInicio;
                var fecha2 = oElement.FechaFin;
                string textoInvertido = InvertirCadena(fecha);
                string texto = InvertirCadena(fecha2);
                oElement.FechaInicio = fecha;
                dt.Rows.Add(i, oElement.SemanaInicio, oElement.SemanaFin, oElement.FechaInicio, oElement.FechaFin,
                oElement.Objetivos, oElement.Tema, oElement.EA, oElement.FE, oElement.EE, oElement.Porcentaje
                , oElement.Estado);
                i++;
            }

            Conexion.abrir();
            SqlCommand cmd = new SqlCommand("InsertarTemas", Conexion.conectar);
            var parameterlst = new SqlParameter("@lstTemas", SqlDbType.Structured);
            parameterlst.TypeName = "Tema";
            parameterlst.Value = dt;
            cmd.CommandType=CommandType.StoredProcedure;

            cmd.Parameters.Add(parameterlst);
            cmd.Parameters.AddWithValue("@IdAsignatura", IdAsignatura);
            cmd.ExecuteNonQuery();
            Conexion.cerrar();
        }

        public static string InvertirCadena(string texto)
        {
            char[] caracteres = texto.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}
