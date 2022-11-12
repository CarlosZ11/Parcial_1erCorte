using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Logica
{
    public class ServicioImpPregrado : IServicioPregrado
    {
        List<Pregrado> EstudiantesPregrado;
        RepositorioPregrado repositorioPregrado;

        public ServicioImpPregrado()
        {
            repositorioPregrado = new RepositorioPregrado();
            EstudiantesPregrado = repositorioPregrado.ObtenerTodoPregrado();
        }

        public List<Pregrado> ObtenerTodoPregrado()
        {
            return EstudiantesPregrado;
        }
    }
}