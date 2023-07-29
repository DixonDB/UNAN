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
        public void CarreraXProfesor(ComboBox combo,int Idprofe,string Modalidad,string Semestre)
        {
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conexion.abrir();
                SqlCommand da = new SqlCommand("CarreraXProfesor", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@IdProfesor", Idprofe);
                da.Parameters.AddWithValue("@Modalidad", Modalidad);
                da.Parameters.AddWithValue("@Semestre", Semestre);
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);
                combo.ValueMember = "IdCarreras";
                combo.DisplayMember = "NombreC";
                combo.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["NombreC"].ToString());
                }
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Carrera " + ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public void AsignaturaXProfesor(ComboBox combo, int Idprofe, string Modalidad,string Carrera,string Semestre)
        {
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conexion.abrir();
                SqlCommand da = new SqlCommand("AsignaturaXProfesor", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@IdProfesor", Idprofe);
                da.Parameters.AddWithValue("@Modalidad", Modalidad);
                da.Parameters.AddWithValue("@Carrera", Carrera);
                da.Parameters.AddWithValue("@Semestre", Semestre);
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);
                combo.ValueMember = "IdAsignaturas";
                combo.DisplayMember = "NombreA";
                combo.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["NombreA"].ToString());
                }
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en asignatura "+ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public void ModalidadXProfesor(ComboBox combo,int idprofe)
        {
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conexion.abrir();
                SqlCommand da = new SqlCommand("ModalidadXProfesor", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@IdProfesor", idprofe);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error en Modalidad " + ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public void SemestreXProfesor(ComboBox combo, int idprofe)
        {
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conexion.abrir();
                SqlCommand da = new SqlCommand("SemestreXProfesor", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@IdProfesor", idprofe);
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);
                combo.ValueMember = "IdSemestre";
                combo.DisplayMember = "Semestre";
                combo.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["Semestre"].ToString());
                }
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Semestre " + ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public void MostrarTemas(ComboBox combo, string carrera, string asig, string grupo, int IdProfe, string semestre)
        {
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conexion.abrir();
                SqlCommand da = new SqlCommand("MostrarTemas", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@carrera", carrera);
                da.Parameters.AddWithValue("@IdProfesor", IdProfe);
                da.Parameters.AddWithValue("@Asignatura", asig);
                da.Parameters.AddWithValue("@Grupo", grupo);
                da.Parameters.AddWithValue("@Semestre", semestre);
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);
                combo.ValueMember = "IdTema";
                combo.DisplayMember = "Tema";
                combo.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["Tema"].ToString());
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

        public void MostrarEE(Label EE, int carrera, int asig, int grupo, int IdProfe, int semestre, int Tema)
        {
            try
            {
                Conexion.abrir();
                Conexion.abrir();
                SqlCommand da = new SqlCommand("MostrarEEPorTema", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@Carrera", carrera);
                da.Parameters.AddWithValue("@IdProfesor", IdProfe);
                da.Parameters.AddWithValue("@Asignatura", asig);
                da.Parameters.AddWithValue("@Grupo", grupo);
                da.Parameters.AddWithValue("@Semestre", semestre);
                da.Parameters.AddWithValue("@Tema", Tema);
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    EE.Text = dt.Rows[0]["EstrategiaEvaluacion"].ToString();
                }
                else
                {
                    EE.Text = "--";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion.cerrar();
            }
        }
    }

}
