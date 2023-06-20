using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNAN.Logica;
using System.Collections;

namespace UNAN.Datos
{
    public class DAsignatura
    {
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
        public void MostrarAsignatura(ComboBox combo, string semestre,string carrera,string grupo)
        {
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conexion.abrir();
                SqlCommand da = new SqlCommand("MostrarAsignaturas", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@Carrera", carrera);
                da.Parameters.AddWithValue("@Semestre", semestre);
                da.Parameters.AddWithValue("@Grupo", grupo);
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }

        }
        public void MostrarCodigoA(string asig, Label codi)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarCodigoA", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Cod", asig);
                DataTable codigo = new DataTable();
                da.Fill(codigo);

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
                Conexion.cerrar();
            }
        }
    }
}
