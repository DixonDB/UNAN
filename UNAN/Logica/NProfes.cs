using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text; using UNAN.Datos;

namespace UNAN.Logica
{
    public class NProfes
    {
        DProfesores objd= new DProfesores();
        public DataTable Nprofes(LProfesores parametros)
        {
            return objd.D_Usuarios(parametros);
        }
    }
}
