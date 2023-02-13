// See dotnet run for more information
using System;

namespace NamespaceProgram
{
    internal class Program
    {
        static void Main (string[] argd)
        {
            Console.WriteLine("=== EXERCÍCIOS - LISTA 2 ===");

            Console.WriteLine("| 1 - Média                                              |");
            Console.WriteLine("| 2 - Mês                                                |");
            Console.WriteLine("| 3 - Forca - FALTOU                                     |");
            Console.WriteLine("| 4 - Tabuada                                            |");
            Console.WriteLine("| 5 - Letra por letra                                    |");
            Console.WriteLine("| 6 - Impares multiplos de 7 até 500                     |");
            Console.WriteLine("| 7 - Média notas positivas                              |");
            Console.WriteLine("| 8 - Fatorial                                           |");
            Console.WriteLine("| 9 - IMC - DÚVIDA                                       |");
            Console.WriteLine("| 10 - Operação                                          |");
            Console.WriteLine("| 12 - DESAFIO                                           |");

            int menu = 0;
            do{
                menu = Int32.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        ExercicioUm.ExercicioUmClass.ExercicioUmVoid();
                    break;
                    case 2:
                        ExercicioDois.ExercicioDoisClass.ExercicioDoisVoid();
                    break;
                    case 3:
                        
                    break;
                    case 4:
                        ExercicioQuatro.ExercicioQuatroClass.ExercicioQuatroVoid();
                    break;
                    case 5:
                        ExercicioCinco.ExercicioCincoClass.ExercicioCincoVoid();
                    break;
                    case 6:
                        ExercicioSeis.ExercicioSeisClass.ExercicioSeisVoid();
                    break;
                    case 7:
                        ExercicioSete.ExercicioSeteClass.ExercicioSeteVoid();
                    break;
                    case 8:
                        ExercicioOito.ExercicioOitoClass.ExercicioOitoVoid();
                    break;
                    case 9:
                       ExercicioNove.ExercicioNoveClass.ExercicioNoveVoid();
                    break;
                    case 10:
                        ExercicioDez.ExercicioDezClass.ExercicioDezVoid();
                    break;
                    case 11:
                        //ExercicioOnze.ExercicioOnze.ExercicioOnzeVoid();
                    break;
                    case 12:
                        //ExercicioSeis.ExercicioSeisClass.ExercicioSeisVoid();
                    break;
                }
            }while(menu != 0);
            
        }
    }

}


