using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNAN.Logica
{
    public class LPlanDidactico
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int SemanaInicio { get; set; }
        public int SemanaFin { get; set; }
        public string Objetivos { get; set; }
        public string Contenido { get; set; }
        public string CbEASeleccionado { get; set; }
        public string CbEESeleccionado { get; set; }
        public string CbFESeleccionado { get; set; }
        public string Porcentaje { get; set; }
    }
}
