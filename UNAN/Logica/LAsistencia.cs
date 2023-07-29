using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNAN.Logica
{
    public class LAsistencia
    {
        public int IdAsistencia { get; set; }
        public string Observaciones { get; set; }
        public DateTime HoraI { get; set; }
        public DateTime HoraF { get; set; }
        public DateTime Fecha { get; set; }
        public int Bloque { get; set; }
        public int Idprofe { get; set; }
        public string Carrera { get; set; }
        public string Asignatura { get; set; }
        public string Semestre { get; set; }
        public string Grupo { get; set; }
        public string Tema { get; set; }
        public string Modalidad { get; set; }
        public int IdModalidad { get; set; }
    }
}
