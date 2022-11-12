using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Datos
{
    public class RepositorioPregrado : Archivos
    {
        public RepositorioPregrado() : base()
        {
            ruta = "Registro-Academico.dat";
        }

        public List<Pregrado> ObtenerTodoPregrado()
        {
            StreamReader sr = new StreamReader(ruta);
            List<Pregrado> estudiantesPregrado = new List<Pregrado>();

            string LineaDatosPregrado;

            while (!sr.EndOfStream)
            {
                LineaDatosPregrado = sr.ReadLine();
                if (LineaDatosPregrado.Split(';')[0] == "PRE")
                {
                    estudiantesPregrado.Add(MappearPregrado(LineaDatosPregrado));
                }
                
            }
            sr.Close();
            return estudiantesPregrado;
        }

        Pregrado MappearPregrado(String LineaDatosPregrado)
        {
            Pregrado EstudiantePregrado = new Pregrado();

            EstudiantePregrado.Id = (LineaDatosPregrado.Split(';')[0]);
            EstudiantePregrado.NoDocumento = int.Parse(LineaDatosPregrado.Split(';')[1]);
            EstudiantePregrado.Nombre = (LineaDatosPregrado.Split(';')[2]);
            EstudiantePregrado.Apellido = (LineaDatosPregrado.Split(';')[3]);
            EstudiantePregrado.ProgramaPregrado = (LineaDatosPregrado.Split(';')[4]);
            EstudiantePregrado.Semestre = int.Parse(LineaDatosPregrado.Split(';')[5]);
            EstudiantePregrado.PromedioCorte1 = Double.Parse(LineaDatosPregrado.Split(';')[6]);
            EstudiantePregrado.PromedioCorte2 = Double.Parse(LineaDatosPregrado.Split(';')[7]);
            EstudiantePregrado.PromedioCorte3 = Double.Parse(LineaDatosPregrado.Split(';')[8]);
            return EstudiantePregrado;
        }
    }
}