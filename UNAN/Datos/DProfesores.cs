using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UNAN.Logica;
using System.Windows.Forms;

namespace UNAN.Datos
{
    public class DProfesores
    {
        public bool InsertarProfesores(LProfesores parametros)
        {
			try
			{
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarProfesores",Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreApellidos", parametros.NombreApellido);
                cmd.Parameters.AddWithValue("@CorreoP", parametros.CorreoP);
                cmd.Parameters.AddWithValue("@CelularP", parametros.CelularP);
                cmd.Parameters.AddWithValue("@CarnetP", parametros.CarnetP);
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
        public bool EditarProfesores(LProfesores parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("EditarProfesores", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProfesor", parametros.IdProfesores);
                cmd.Parameters.AddWithValue("@NombreApellido", parametros.NombreApellido);
                cmd.Parameters.AddWithValue("@CorreoP", parametros.CorreoP);
                cmd.Parameters.AddWithValue("@CelularP", parametros.CelularP);
                cmd.Parameters.AddWithValue("@CarnetP", parametros.CarnetP);
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
        public bool EliminarProfesores(LProfesores parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("EliminarProfesores", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProfesor", parametros.IdProfesores);
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
        public void MostrarProfesores(ref DataTable dt, int desde, int hasta)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarProfesores", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally { Conexion.cerrar(); }
        }
        public void BuscarProfesores(ref DataTable dt, int desde, int hasta, string buscador)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarProfesores", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                da.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally { Conexion.cerrar(); }
        }
        public void BuscarProfesorIdentidad(ref DataTable dt, string buscador)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarProfesorIdentidad", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
                da.Fill(dt);
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
        public void ContarProfesores(ref int Contador)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("select Count(IdProfesores) from Profesores", Conexion.conectar);
                Contador = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                Contador = 0;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public bool restaurarProfesores(LProfesores parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("restaurar_profesores", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idprofesor", parametros.IdProfesores); ;
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
