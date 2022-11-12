using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class MenuPrincipal
    {
        public void VerPrincipal(int l, int t)
        {
            PresentacionPregrado presentacionPregrado = new PresentacionPregrado();
            PresentacionPostgrado presentacionPostgrado = new PresentacionPostgrado();  

            int op;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();

                Console.SetCursorPosition(l + 65, t + 22);
                Console.WriteLine("ING. CARLOS ZAMBRANO PADILLA");

                Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU PRINCIPAL DE NOTAS DE ESTUDIANTES DE PREGRADO Y POSTGRADO DE LA U.P.C.");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. ESTUDIANTES DE PREGRADO");
                Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. ESTUDIANTES DE POSTGRADO");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. PROMEDIO POR PROGRAMA");
                Console.SetCursorPosition(l, t + 5); Console.WriteLine("4. ESTUDIANTES DESTACADOS");
                Console.SetCursorPosition(l, t + 7); Console.WriteLine("5. SALIR");
                Console.SetCursorPosition(l, t + 9); Console.WriteLine("Digite una opcion: ");
                Console.SetCursorPosition(l + 19, t + 9); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        presentacionPregrado.MostrarEstudiantesPregrado(15, 5);
                        break;
                    case 2:
                        presentacionPostgrado.MostrarEstudiantesPostgrado(15, 5);
                        break;
                    case 3:
                        int opcB;

                        do
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Clear();
                            Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU DE PROMEDIO POR PROGRAMA");
                            Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. PROMEDIO PREGRADO");
                            Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. PROMEDIO POSTGRADO");
                            Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. REGRESAR AL MENU ANTERIOR");
                            Console.SetCursorPosition(l, t + 6); Console.WriteLine("Digite una opcion: ");
                            Console.SetCursorPosition(l + 19, t + 6); opcB = int.Parse(Console.ReadLine());

                            switch (opcB)
                            {
                                case 1:
                                    int opcPre;

                                    do
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Clear();
                                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU DE PROMEDIO PREGRADO");
                                        Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. PROMEDIO DEL PROGRAMA DE SISTEMAS");
                                        Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. PROMEDIO DEL PROGRAMA DE DERECHO");
                                        Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. PROMEDIO DEL PROGRAMA DE ENFERMERÍA");
                                        Console.SetCursorPosition(l, t + 5); Console.WriteLine("4. PROMEDIO DEL PROGRAMA DE LICENCIATURA");
                                        Console.SetCursorPosition(l, t + 6); Console.WriteLine("5. PROMEDIO DEL PROGRAMA DE MÚSICA");
                                        Console.SetCursorPosition(l, t + 7); Console.WriteLine("6. REGRESAR AL MENU ANTERIOR");
                                        Console.SetCursorPosition(l, t + 9); Console.WriteLine("Digite una opcion: ");
                                        Console.SetCursorPosition(l + 19, t + 9); opcPre = int.Parse(Console.ReadLine());

                                        switch (opcPre)
                                        {
                                            case 1:
                                                break;

                                            case 2:
                                                break;

                                            case 3:
                                                break;

                                            case 4:
                                                break;

                                            case 5:
                                                break;

                                        }
                                    } while (opcPre != 6);

                                    break;
                                case 2:
                                    int opcPost;

                                    do
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Clear();
                                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU DE PROMEDIO POSTGRADO");
                                        Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. PROMEDIO DEL PROGRAMA DE DESARROLLO SOFTWARE");
                                        Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. PROMEDIO DEL PROGRAMA DE DERECHO ADMINISTRATIVO");
                                        Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. PROMEDIO DEL PROGRAMA DE AUDITORIA EN SALUD");
                                        Console.SetCursorPosition(l, t + 5); Console.WriteLine("4. REGRESAR AL MENU ANTERIOR");
                                        Console.SetCursorPosition(l, t + 7); Console.WriteLine("Digite una opcion: ");
                                        Console.SetCursorPosition(l + 19, t + 7); opcPost = int.Parse(Console.ReadLine());

                                        switch (opcPost)
                                        {
                                            case 1:
                                                break;

                                            case 2:
                                                break;

                                            case 3:
                                                break;

                                        }
                                    } while (opcPost != 4);

                                    break;
                            }


                        } while (opcB != 3); //Menu selector para buscar contactos
                        break;
                    case 4:
                        int opcEstudiantesD;

                        do
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Clear();
                            Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU DE ESTUDIANTES DESTACADOS POR PROGRAMA");
                            Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. ESTUDIANTES DESTACADOS DE PREGRADO");
                            Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. ESTUDIANTES DESTACADOS DE POSTGRADO");
                            Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. REGRESAR AL MENU ANTERIOR");
                            Console.SetCursorPosition(l, t + 6); Console.WriteLine("Digite una opcion: ");
                            Console.SetCursorPosition(l + 19, t + 6); opcEstudiantesD = int.Parse(Console.ReadLine());

                            switch (opcEstudiantesD)
                            {
                                case 1:
                                    int opcEstudiantesDestacadosPre;

                                    do
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Clear();
                                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU DE ESTUDIANTES DESTACADOS DE PREGRADO");
                                        Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. ESTUDIANTE DESTACADOS DEL PROGRAMA DE SISTEMAS");
                                        Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. ESTUDIANTE DESTACADOS DEL PROGRAMA DE DERECHO");
                                        Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. ESTUDIANTE DESTACADOS DEL PROGRAMA DE ENFERMERÍA");
                                        Console.SetCursorPosition(l, t + 5); Console.WriteLine("4. ESTUDIANTE DESTACADOS DEL PROGRAMA DE LICENCIATURA");
                                        Console.SetCursorPosition(l, t + 6); Console.WriteLine("5. ESTUDIANTE DEL PROGRAMA DE MÚSICA");
                                        Console.SetCursorPosition(l, t + 7); Console.WriteLine("6. REGRESAR AL MENU ANTERIOR");
                                        Console.SetCursorPosition(l, t + 9); Console.WriteLine("Digite una opcion: ");
                                        Console.SetCursorPosition(l + 19, t + 9); opcEstudiantesDestacadosPre = int.Parse(Console.ReadLine());

                                        switch (opcEstudiantesDestacadosPre)
                                        {
                                            case 1:
                                                presentacionPregrado.EstudiantesDestacadosPregrado(15, 5);
                                                break;

                                            case 2:
                                                break;

                                            case 3:
                                                break;

                                            case 4:
                                                break;

                                            case 5:
                                                break;

                                        }
                                    } while (opcEstudiantesDestacadosPre != 6);

                                    break;
                                case 2:
                                    int opcEstudiantesDestacadosPost;

                                    do
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Clear();
                                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU DE ESTUDIANTES DESTACADOS DE POSTGRADO");
                                        Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. ESTUDIANTE DESTACADO DEL PROGRAMA DE DESARROLLO SOFTWARE");
                                        Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. ESTUDIANTE DESTACADO DEL PROGRAMA DE DERECHO ADMINISTRATIVO");
                                        Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. ESTUDIANTE DESTACADO DEL PROGRAMA DE AUDITORIA EN SALUD");
                                        Console.SetCursorPosition(l, t + 5); Console.WriteLine("4. REGRESAR AL MENU ANTERIOR");
                                        Console.SetCursorPosition(l, t + 7); Console.WriteLine("Digite una opcion: ");
                                        Console.SetCursorPosition(l + 19, t + 7); opcEstudiantesDestacadosPost = int.Parse(Console.ReadLine());

                                        switch (opcEstudiantesDestacadosPost)
                                        {
                                            case 1:
                                                break;

                                            case 2:
                                                break;

                                            case 3:
                                                break;

                                        }
                                    } while (opcEstudiantesDestacadosPost != 4);
                                    break;
                            }

                        } while (opcEstudiantesD != 3);

                        break;
                    case 5:
                        Console.Clear();
                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("GRACIAS, VUELVA PRONTO");
                        Console.SetCursorPosition(l + 22, t - 2); Console.ReadKey();
                        break;
                }

            } while (op != 5);
        }
    }
}
