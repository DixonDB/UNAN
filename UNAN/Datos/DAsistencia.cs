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
            dt.Columns.Add("HoraI");
            dt.Columns.Add("HoraF");
            dt.Columns.Add("Observaciones");

            int i = 1;
            foreach (var oElement in lst)
            {
                dt.Rows.Add(i, oElement.HoraI, oElement.HoraF, oElement.Observaciones);
                i++;
            }
            Conexion.abrir();
            SqlCommand cmd = new SqlCommand("InsertarAsistencia", Conexion.conectar);
            var parameterlst = new SqlParameter("@lstAsis", SqlDbType.Structured);
            parameterlst.TypeName = "Asis";
            parameterlst.Value = dt;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(parameterlst);
            cmd.Parameters.AddWithValue("@IdProfe", parametros.Idprofe);
            cmd.Parameters.AddWithValue("@IdCarrera", parametros.IdCarrera);
            cmd.Parameters.AddWithValue("@IdSemestre", parametros.IdSemestre);
            cmd.Parameters.AddWithValue("@IdGrupo", parametros.IdGrupo);
            cmd.Parameters.AddWithValue("@IdAsignatura", parametros.IdAsignatura);
            cmd.Parameters.AddWithValue("@IdTema", parametros.IdTema);
            cmd.Parameters.AddWithValue("Fecha", parametros.Fecha);
            cmd.Parameters.AddWithValue("Bloque", parametros.Bloque);
            cmd.ExecuteNonQuery();
            Conexion.cerrar();
        }
    }
}
