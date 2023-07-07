using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UNAN.Logica;

namespace UNAN.Logica
{
    public class LAprendizaje
    {
        public int IdEsAprendizaje { get; set; }

        public string NombreEstApren { get; set; }

        public int IdFrmEva { get; set; }

        public string NombreFrmEva { get; set; }

        public int IdEsEvaluacion { get; set; }

        public string NombreEsEvaluacion { get; set; }
    }
}
