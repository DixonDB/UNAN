using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UNAN.Logica;

namespace UNAN.Datos
{
    public class DAsistencia
    {
        public void InsertarAsistencia(LAsistencia parametros,List<LAsistencia> lst)
        {
            var dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Modalidad");
            dt.Columns.Add("Carrera");
            dt.Columns.Add("Grupo");
            dt.Columns.Add("Semestre");
            dt.Columns.Add("Asignatura");
            dt.Columns.Add("Tema");

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
    }
}
