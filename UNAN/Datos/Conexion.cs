using System.Data;
using System.Data.SqlClient;

namespace UNAN.Datos
{
    public class Conexion
    {
        /// <summary>
        /// Se declara una variable de tipo string la cual es estatica y contendra la conexión a la base de datos
        /// </summary>
        //public static string conexion = @"Data source=DIXONB; Initial Catalog=UNAN; Integrated Security = True";
        public static string conexion = @"Data source=Felix\MSSQLSERVER01; Initial Catalog=UNAN; Integrated Security = True";
        //Convert.ToString(Logica.Desencryptacion.checkServer());

        /// <summary>
        /// Declaramos de manera publica un comando para hacer efectiva la conexion al servidor
        /// </summary>
        public static SqlConnection conectar = new SqlConnection(conexion);

        /// <summary>
        /// Creamos un metodo para abrir la conexión
        /// </summary>
        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        /// <summary>
        /// Creamos un metodo para cerrar la conexión
        /// </summary>
        public static void cerrar()
        {
            if (conectar.State== ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
