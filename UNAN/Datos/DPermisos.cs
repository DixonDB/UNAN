using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UNAN.Logica;

namespace UNAN.Datos
{
    public class DPermisos
    {
        public bool Insertar_Permisos(Lpermisos parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Permisos", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdModulo", parametros.IdModulo);
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.IdProfesor);
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
        public void mostrar_Permisos(ref DataTable dt, Lpermisos parametros)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_Permisos", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@IdProfesor", parametros.IdProfesor);

                da.Fill(dt);

                Conexion.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        public bool Eliminar_Permisos(Lpermisos parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("Eliminar_Permisos", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProfesor", parametros.IdProfesor);
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
    }
}
