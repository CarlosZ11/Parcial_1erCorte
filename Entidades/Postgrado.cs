using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Postgrado : Estudiantes
    {
        public string ProgramaPostgrado { get; set; }
        public double PromedioSemestre { get; set; }
    }
}