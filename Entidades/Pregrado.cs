using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Pregrado : Estudiantes
    {
        public String ProgramaPregrado { get; set; }
        public double PromedioCorte1 { get; set; }
        public double PromedioCorte2 { get; set; }
        public double PromedioCorte3 { get; set; }
    }
}