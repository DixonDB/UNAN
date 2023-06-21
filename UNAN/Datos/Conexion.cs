using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace UNAN.Datos
{
    public class Conexion
    {
        public static string conexion = @"Data source=DIXONDB\MSSQLSERVER01; Initial Catalog=UNAN; Integrated Security = True";
        //@"Data source=DESKTOP-MHSIP3Q; Initial Catalog=UNAN; Integrated Security = True";
                                        //Convert.ToString(Logica.Desencryptacion.checkServer());
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State== ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
