using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Windows.Forms;
using UNAN.Logica;

namespace UNAN.Datos
{
    public class DProfesores
    {
        /// <summary>
        /// La función InsertarProfesores inserta un nuevo registro en una tabla de la base de datos
        /// llamada Profesores con los parámetros proporcionados.
        /// </summary>
        /// <param name="LProfesores">LProfesores es una clase que contiene las propiedades de los
        /// parámetros utilizados en el método InsertarProfesores.</param>
        /// <returns>
        /// El método devuelve un valor booleano.
        /// </returns>
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
                cmd.Parameters.AddWithValue("@Usuario", parametros.Usuario);
                cmd.Parameters.AddWithValue("@Password", parametros.Password);
                cmd.Parameters.AddWithValue("@Tusuario", parametros.TUsuario);
                cmd.Parameters.AddWithValue("@Icono", parametros.Icono);
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
        /// <summary>
        /// La función "EditarProfesores" toma un parámetro de tipo "LProfesores" y devuelve un valor
        /// booleano.
        /// </summary>
        /// <param name="LProfesores">LProfesores es una clase o estructura de datos que
        /// representa una colección o lista de Profesores (maestros). Se usarse para pasar
        /// múltiples objetos de profesor o información sobre profesores al método
        /// EditarProfesores.</param>
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
                cmd.Parameters.AddWithValue("@Usuario", parametros.Usuario);
                cmd.Parameters.AddWithValue("@Password", parametros.Password);
                cmd.Parameters.AddWithValue("@Tusuario", parametros.TUsuario);
                cmd.Parameters.AddWithValue("@Icono", parametros.Icono);
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
        /// <summary>
        /// La función "EliminarProfesores" se utiliza para eliminar un registro de un profesor de una
        /// base de datos mediante un procedimiento almacenado.
        /// </summary>
        /// <param name="LProfesores">LProfesores es una clase o estructura de datos que contiene los
        /// parámetros para el método EliminarProfesores.</param>
        /// <returns>
        /// El método devuelve un valor booleano.
        /// </returns>
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
        /// <summary>
        /// La función "MostrarProfesores" recupera un rango de filas de una tabla de base de datos y
        /// llena un objeto DataTable con los resultados.
        /// </summary>
        /// <param name="DataTable">El parámetro DataTable se utiliza para almacenar los datos
        /// recuperados de la base de datos. Se pasa por referencia, lo que significa que cualquier
        /// cambio realizado en DataTable dentro del método también se reflejará fuera del
        /// método.</param>
        /// <param name="desde">El parámetro "desde" es un número entero que representa el índice de
        /// inicio del rango de profesores a mostrar.</param>
        /// <param name="hasta">El parámetro "hasta" representa el punto final o límite del rango de
        /// datos a recuperar o mostrar.</param>
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
        /// <summary>
        /// La función "BuscarProfesores" busca profesores en una base de datos en base a parámetros
        /// especificados y llena un DataTable con los resultados.
        /// </summary>
        /// <param name="DataTable">El parámetro DataTable se utiliza para almacenar los resultados de
        /// la consulta de búsqueda. Se pasa por referencia para que los cambios realizados en DataTable
        /// dentro del método también se reflejen fuera del método.</param>
        /// <param name="desde">El parámetro "desde" es un número entero que representa el punto de
        /// partida de la búsqueda. Se utiliza para especificar el rango de registros a recuperar de la
        /// base de datos.</param>
        /// <param name="hasta">El parámetro "hasta" representa el límite superior o valor máximo para
        /// un rango o intervalo. En el contexto del fragmento de código proporcionado, se utiliza como
        /// parámetro para filtrar o buscar profesores dentro de un rango específico.</param>
        /// <param name="buscador">El parámetro "buscador" es una cadena que representa el término de
        /// búsqueda o palabra clave que se utilizará para buscar profesores en la base de
        /// datos.</param>
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
        /// <summary>
        /// La función "ContarProfesores" cuenta el número de registros en la tabla "Profesores" y
        /// almacena el resultado en la variable "Contador".
        /// </summary>
        /// <param name="Contador">Este es un parámetro de referencia de tipo int. Se utiliza para
        /// almacenar el recuento de profesores devueltos por la consulta de la base de datos. El valor
        /// de Contador se actualizará dentro del método y también se puede acceder fuera del
        /// método.</param>
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
        /// <summary>
        /// La función "restaurarProfesores" restaura una lista de profesores en una base de datos.
        /// </summary>
        /// <param name="LProfesores">"LProfesores" es una clase o una estructura de datos
        /// que contiene los parámetros para el método "restaurarProfesores". El parámetro "parámetros"
        /// en el método es de tipo LProfesores y se utiliza para pasar los datos necesarios al
        /// método.</param>
        /// <returns>
        /// El método devuelve un valor booleano.
        /// </returns>
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

        #region Validar Usuarios Para login
        /// <summary>
        /// La función "D_Usuarios" recupera datos de usuario de una base de datos mediante un
        /// procedimiento almacenado y los devuelve como un DataTable.
        /// </summary>
        /// <param name="LProfesores">LProfesores es una clase </param>
        /// <returns>
        /// El método devuelve un objeto DataTable.
        /// </returns>
        public DataTable D_Usuarios(LProfesores parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("Login", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", parametros.Usuario);
                cmd.Parameters.AddWithValue("@Password", parametros.Password);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        
        /// <summary>
        /// La función "ObtenerIdProfesor" recupera el ID de un profesor en base a su nombre de usuario.
        /// </summary>
        /// <param name="Idprofesor">Esta es una variable entera que almacenará la identificación del
        /// profesor.</param>
        /// <param name="Usuario">El parámetro "Usuario" es una cadena que representa el nombre de
        /// usuario del profesor.</param>
        public void ObtenerIdProfesor(ref int Idprofesor, string Usuario)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("ObtenerIdProfesor", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                Idprofesor = Convert.ToInt32(cmd.ExecuteScalar());
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
        #endregion

        //Mostrar los datos del usuario logueado para editar sus datos
        /// <summary>
        /// La función "MostrarDatos" recupera datos de una tabla de base de datos basada en una
        /// identificación de profesor determinada y los almacena en un DataTable.
        /// </summary>
        /// <param name="idprofesor">El id del profesor cuyos datos necesitan ser mostrados.</param>
        /// <param name="DataTable">El parámetro DataTable se utiliza para almacenar los datos
        /// recuperados de la base de datos. Es una estructura similar a una tabla que puede contener
        /// varias filas y columnas de datos. En este caso, se rellenará con los datos devueltos por el
        /// procedimiento almacenado "MostrarUsuarioLogueado".</param>
        public void MostrarDatos(int idprofesor, DataTable dt)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarUsuarioLogueado", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@IdUsuario", idprofesor);
                
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
