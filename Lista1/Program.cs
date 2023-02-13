// See dotnet run for more information
using System;

namespace NamespaceProgram
{
    internal class Program
    {
        static void Main (string[] argd)
        {
            Console.WriteLine("=== EXERCÍCIOS - LISTA 1 ===");

            Console.WriteLine("| 1 - Calcule a Média                                   |");
            Console.WriteLine("| 2 - Calcule a Área                                    |");
            Console.WriteLine("| 3 - Calcule o Volume                                  |");
            Console.WriteLine("| 4 - Valor é maior que o dobro de outro valor          |");
            Console.WriteLine("| 5 - Cálculo de Bhaskara                               |");
            Console.WriteLine("| 6 - Velocidade Média                                  |");
            Console.WriteLine("| 7 - Percentual de Imposto                             |");
            Console.WriteLine("| 8 - Valor é par ou ímpar                              |");
            Console.WriteLine("| 9 - Comparar dois valores de String                   |");
            Console.WriteLine("| 10 - Valor double em string e convertido para inteiro |");
            Console.WriteLine("| 11 - Imposto de renda de um salário                   |");
            Console.WriteLine("| 12 - DESAFIO                                          |");

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
                        ExercicioTres.ExercicioTresClass.ExercicioTresVoid();
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
                        ExercicioDez.ExercicioDez.ExercicioDezVoid();
                    break;
                    case 11:
                        ExercicioOnze.ExercicioOnze.ExercicioOnzeVoid();
                    break;
                    case 12:
                        ExercicioSeis.ExercicioSeisClass.ExercicioSeisVoid();
                    break;
                }
            }while(menu != 0);
            
        }
    }

}


