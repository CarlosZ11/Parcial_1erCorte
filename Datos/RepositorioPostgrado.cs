using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Datos
{
    public class RepositorioPostgrado : Archivos
    {
        public RepositorioPostgrado() : base()
        {
            ruta = "Registro-Academico.dat";
        }

        public List<Postgrado> ObtenerTodoPostgrado()
        {
            StreamReader sr = new StreamReader(ruta);
            List<Postgrado> estudiantesPostgrado = new List<Postgrado>();

            string LineaDatosPostgrado;

            while (!sr.EndOfStream)
            {
                LineaDatosPostgrado = sr.ReadLine();
                if (LineaDatosPostgrado.Split(';')[0] == "POST")
                {
                    estudiantesPostgrado.Add(MappearPostgrado(LineaDatosPostgrado));
                }
            }
            sr.Close();
            return estudiantesPostgrado;
        }

        Postgrado MappearPostgrado(String LineaDatosPostgrado)
        {
            Postgrado EstudiantePostgrado = new Postgrado();

            EstudiantePostgrado.Id = (LineaDatosPostgrado.Split(';')[0]);
            EstudiantePostgrado.NoDocumento = int.Parse(LineaDatosPostgrado.Split(';')[1]);
            EstudiantePostgrado.Nombre = (LineaDatosPostgrado.Split(';')[2]);
            EstudiantePostgrado.Apellido = (LineaDatosPostgrado.Split(';')[3]);
            EstudiantePostgrado.ProgramaPostgrado = (LineaDatosPostgrado.Split(';')[4]);
            EstudiantePostgrado.Semestre = int.Parse(LineaDatosPostgrado.Split(';')[5]);
            EstudiantePostgrado.PromedioSemestre = double.Parse(LineaDatosPostgrado.Split(';')[6]);
            return EstudiantePostgrado;
        }
    }
}