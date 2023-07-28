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
        public void InsertarAsistencia(LAsistencia parametros,List<LAsistencia> lst)
        {
            var dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Asignatura");
            dt.Columns.Add("NombreC");
            dt.Columns.Add("Semestre");
            dt.Columns.Add("Grupo");
            dt.Columns.Add("Tema");
            dt.Columns.Add("Modalidad");

            int i = 1;
            foreach (var oElement in lst)
            {
                dt.Rows.Add(i, oElement.Modalidad, oElement.Carrera, oElement.Grupo,oElement.Semestre,oElement.Asignatura,oElement.Tema);
                i++;
            }
            Conexion.abrir();
            SqlCommand cmd = new SqlCommand("InsertarAsistencia", Conexion.conectar);
            var parameterlst = new SqlParameter("@lstNombre", SqlDbType.Structured);
            parameterlst.TypeName = "AsisNombre";
            parameterlst.Value = dt;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(parameterlst);
            cmd.Parameters.AddWithValue("@IdProfe", parametros.Idprofe);
            cmd.Parameters.AddWithValue("@Observaciones", parametros.Observaciones);
            cmd.Parameters.AddWithValue("@HoraI", parametros.HoraI);
            cmd.Parameters.AddWithValue("@HoraF", parametros.HoraF);
            cmd.Parameters.AddWithValue("Fecha", parametros.Fecha);
            cmd.Parameters.AddWithValue("Bloque", parametros.Bloque);
            cmd.ExecuteNonQuery();
            Conexion.cerrar();
        }
        public void MostrarAsistencia(ref DataTable dt, int idProfesor)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarDetalleAsistencia", Conexion.conectar);
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
                Conexion.cerrar();
            }
        }
    }

}
