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
        public int IdCarrera { get; set; }
        public int IdAsignatura { get; set; }
        public int IdSemestre { get; set; }
        public int IdGrupo { get; set; }
        public int IdTema { get; set; }
    }
}
