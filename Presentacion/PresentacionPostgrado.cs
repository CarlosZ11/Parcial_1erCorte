using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Logica;

namespace Presentacion
{
    public class PresentacionPostgrado
    {
        ServicioImpPostgrado servicioPostgrado = new ServicioImpPostgrado();

        public void MostrarEstudiantesPostgrado(int l, int t)
        {
            Console.Clear();

            Console.SetCursorPosition(l, t - 1);
            Console.WriteLine("ESTUDIANTES DE POSTGRADO");
            Console.SetCursorPosition(l - 12, t + 2);
            Console.WriteLine("ID");
            Console.SetCursorPosition(l - 5, t + 2);
            Console.WriteLine("N° DOCUMENTO");
            Console.SetCursorPosition(l + 16, t + 2);
            Console.WriteLine("NOMBRES Y APELLIDOS");
            Console.SetCursorPosition(l + 48, t + 2);
            Console.WriteLine("PROGRAMA POST.");
            Console.SetCursorPosition(l + 73, t + 2);
            Console.WriteLine("SEMESTRE");
            Console.SetCursorPosition(l + 86, t + 2);
            Console.WriteLine("PROMEDIO");

            foreach (var EstudiantePostgrado in servicioPostgrado.ObtenerTodoPostgrado())
            {
                Console.SetCursorPosition(l - 12, t + 4);
                Console.WriteLine(EstudiantePostgrado.Id);
                Console.SetCursorPosition(l - 5, t + 4);
                Console.WriteLine(EstudiantePostgrado.NoDocumento);
                Console.SetCursorPosition(l + 11, t + 4);
                Console.WriteLine(EstudiantePostgrado.Nombre);
                Console.SetCursorPosition(l + 28, t + 4);
                Console.WriteLine(EstudiantePostgrado.Apellido);
                Console.SetCursorPosition(l + 48, t + 4);
                Console.WriteLine(EstudiantePostgrado.ProgramaPostgrado);
                Console.SetCursorPosition(l + 77, t + 4);
                Console.WriteLine(EstudiantePostgrado.Semestre);
                Console.SetCursorPosition(l + 89, t + 4);
                Console.WriteLine(EstudiantePostgrado.PromedioSemestre);
                t++;
            }
            Console.SetCursorPosition(l, t + 10);
            Console.ReadKey();
        }


    }
}
