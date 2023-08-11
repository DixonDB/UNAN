using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNAN.Logica
{
    public class LAsis
    {
        public int IdAsistencia { get; set; }
        public int IdProfesor { get; set; }
        public DateTime Fecha { get; set; }
        public int Bloques { get; set; }
        public int IdDetalleAsistencia { get; set; }
        public int IdAsignatura { get; set; }
        public int IdTema { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string Observacion { get; set; }
    }
}
