using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNAN.Logica
{
    public class LProfesores
    {
        public int IdProfesores { get; set; }
        public string NombreApellido { get; set; }
        public string CorreoP { get; set; }
        public int CelularP { get; set; }
        public string CarnetP { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public byte[] Icono { get; set; }
        public string Estado { get; set; }
    }
}
