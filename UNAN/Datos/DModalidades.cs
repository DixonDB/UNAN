using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Schema;
using UNAN.Presentacion;
using UNAN.Logica;

namespace UNAN.Datos
{
    public class DModalidades
    {
        public void MostrarModalidades(ComboBox combo)
        {
            Conexion.abrir();
            SqlCommand da = new SqlCommand("MostrarModalidad", Conexion.conectar);
            da.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter cb = new SqlDataAdapter(da);
            DataTable dt = new DataTable();
            cb.Fill(dt);
            combo.ValueMember = "IdModalidad";
            combo.DisplayMember = "Modalidad";
            combo.DataSource = dt;
        }
        public bool InsertarGrupo(LModalidad parametro)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarGrupo", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreGrupo", parametro.Grupo);
                cmd.Parameters.AddWithValue("@IdModalidad", parametro.IdModalidad);
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
        public void MostrarGrupos(ComboBox combo,string carrera)
        {
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
        }
    }
}
