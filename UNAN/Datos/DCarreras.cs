using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UNAN.Logica;

namespace UNAN.Datos
{
    public class DCarreras
    {
        //variable para guardar el codigo de la carrera
		public string cod;

        /// <summary>
        /// Inserta una nueva carrera en la base de datos.
        /// </summary>
        /// <param name="parametros">Un objeto de tipo LCarreras que contiene los parámetros para la inserción.</param>
        /// <returns>Devuelve true si la inserción fue exitosa; de lo contrario, devuelve false.</returns>
        public bool InsertarCarrera(LCarreras parametros)
		{
			try
			{
                //Abrir la conexión a la base de datos
				Conexion.abrir();

                //Crear el comando SQL para el procedimiento almacenado
				SqlCommand cmd = new SqlCommand("Insertar_Carrera", Conexion.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@NombreC", parametros.NombreC);
				cmd.Parameters.AddWithValue("@CodigoC", parametros.CodigoC);
				cmd.Parameters.AddWithValue("@IdModalidad", parametros.IdModalidad);
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
                //Cerrar la conexión a la base de datos
				Conexion.cerrar();
			}
		}

        /// <summary>
        /// Muestra las carreras desde la base de datos en un ComboBox que se autocompleta con dicha información.
        /// </summary>
        /// <param name="combo">Combobox en el cual se mostraran las carreras</param>
        /// <param name="modalidad">Modalidad parafiltrar las carreras</param>
		public void MostrarCarrera(ComboBox combo,string modalidad)
		{
            try
            {
                //Crear la colección para el autocompletado
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                //Abrir la conexión a la base de datos
                Conexion.abrir();

                //Crear el comando SQL para el procedimiento almacenado
                SqlCommand da = new SqlCommand("MostrarCarrera", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@Mod", modalidad);

                //Crear el adapatador para ejecuatr el comando y llenar los datos en el DataTable
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);

                //Configurar el combobox para mostrar los datos
                combo.ValueMember = "IdCarreras";
                combo.DisplayMember = "NombreC";
                combo.DataSource = dt;

                //Agregar los datos a la colección de autocompletado
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["NombreC"].ToString());
                }

                //Asignar la colección de autocompletado al combobox
                combo.AutoCompleteCustomSource= lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Cerrar la conexión a la base de datos
                Conexion.cerrar();
            }
        }

        /// <summary>
        /// Muestra el codigo de carrera desde la base de datos en un Label que se autocompleta con dicha información.
        /// </summary>
        /// <param name="carr">Carr para filtrar el codigo</param>
        /// <param name="codi">codi para asignar el codigo de carrera</param>
        public void MostrarCodigoC(string carr, Label codi)
        {
            try
            {
                //Abrir la conexión a la base de datos
                Conexion.abrir();

                //Crear el comando SQL para el procedimeinto almacenado
                SqlDataAdapter da = new SqlDataAdapter("MostrarCodigoC", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Cod", carr);
                DataTable codigo = new DataTable();
                da.Fill(codigo);

                //ASignar el dato al label
                if (codigo.Rows.Count > 0)
                {
                    codi.Text = codigo.Rows[0]["CodigoC"].ToString();
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
                //Cerrar la conexión a la base de datos
                Conexion.cerrar();
            }
        }

    }
}
