using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Logica;
using System.Linq;
namespace Presentacion
{
    public class PresentacionPregrado
    {
        ServicioImpPregrado servicioPregrado = new ServicioImpPregrado();
        public void MostrarEstudiantesPregrado(int l, int t)
        {
            Console.Clear();

            Console.SetCursorPosition(l, t - 1);
            Console.WriteLine("ESTUDIANTES DE PREGRADO");
            Console.SetCursorPosition(l - 12, t + 2);
            Console.WriteLine("ID");
            Console.SetCursorPosition(l - 5, t + 2);
            Console.WriteLine("N° DOCUMENTO");
            Console.SetCursorPosition(l + 16, t + 2);
            Console.WriteLine("NOMBRES Y APELLIDOS");
            Console.SetCursorPosition(l + 48, t + 2);
            Console.WriteLine("PROGRAMA PRE.");
            Console.SetCursorPosition(l + 63, t + 2);
            Console.WriteLine("SEMESTRE");
            Console.SetCursorPosition(l + 73, t + 2);
            Console.WriteLine("NOTA 1");
            Console.SetCursorPosition(l + 82, t + 2);
            Console.WriteLine("NOTA 2");
            Console.SetCursorPosition(l + 91, t + 2);
            Console.WriteLine("NOTA 3");

            foreach (var EstudiantePregrado in servicioPregrado.ObtenerTodoPregrado())
            {
                Console.SetCursorPosition(l - 12, t + 5);
                Console.WriteLine(EstudiantePregrado.Id);
                Console.SetCursorPosition(l - 5, t + 5);
                Console.WriteLine(EstudiantePregrado.NoDocumento);
                Console.SetCursorPosition(l + 11, t + 5);
                Console.WriteLine(EstudiantePregrado.Nombre);
                Console.SetCursorPosition(l + 28, t + 5);
                Console.WriteLine(EstudiantePregrado.Apellido);
                Console.SetCursorPosition(l + 48, t + 5);
                Console.WriteLine(EstudiantePregrado.ProgramaPregrado);
                Console.SetCursorPosition(l + 67, t + 5);
                Console.WriteLine(EstudiantePregrado.Semestre);
                Console.SetCursorPosition(l + 75, t + 5);
                Console.WriteLine(EstudiantePregrado.PromedioCorte1);
                Console.SetCursorPosition(l + 84, t + 5);
                Console.WriteLine(EstudiantePregrado.PromedioCorte2);
                Console.SetCursorPosition(l + 93, t + 5);
                Console.WriteLine(EstudiantePregrado.PromedioCorte3);
                t++;
            }

            Console.SetCursorPosition(l, t + 10);
            Console.ReadKey();
        }

        public void EstudiantesDestacadosPregrado(int l, int t)
        {
            Console.Clear();
            Console.SetCursorPosition(l, t - 1);
            Console.WriteLine("ESTUDIANTE DESTACADO DE SISTEMAS");
            var promedioMax = servicioPregrado.ObtenerTodoPregrado().Max(e => e.PromedioCorte1);
            Console.WriteLine(promedioMax);
            Console.SetCursorPosition(l, t + 10);
            Console.ReadKey();
        }
    }
}
