using System;

namespace UNAN.Logica
{
    public class LPlanDidactico
    {
        public int IdPlan { get; set; }
        public int IdProfe { get; set; }
        public int IdCarrera { get; set; }
        public int IdModalidad { get; set; }
        public int IdTema { get; set; }
        public int IdGrupo { get; set; }
        public int IdSemestre { get; set; }
        public int IdAsignatura { get; set; }
        public string Tema { get; set; }
        public string Estado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int SemanaInicio { get; set; }
        public int SemanaFin { get; set; }
        public string Objetivos { get; set; }
        public string EA { get; set; }
        public string EE { get; set; }
        public string FE { get; set; }
        public decimal Porcentaje { get; set; }

    }
}
