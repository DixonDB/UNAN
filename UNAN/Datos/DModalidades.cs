using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Schema;
using UNAN.Presentacion;

namespace UNAN.Datos
{
    public  class DModalidades
    {
        public void MostrarModalidades(ComboBox combo)
        {
            Conexion.abrir();
            SqlCommand da=new SqlCommand("MostrarModalidad",Conexion.conectar);
            da.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter cb = new SqlDataAdapter(da);
            DataTable dt = new DataTable();
            cb.Fill(dt);
            combo.ValueMember = "IdModalidad";
            combo.DisplayMember = "Modalidad";
            combo.DataSource = dt;
        }
    }
}
