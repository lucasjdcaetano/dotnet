using System;

namespace ExercicioUm 
{
    public class ExercicioUmClass
    {
        public static void ExercicioUmVoid()
        {
            Console.WriteLine("Informe o primeiro número:");
            int numUm = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            int numDois = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro número:");
            int numTres = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"A média é {(numUm + numDois + numTres) /3}");

        }
         
    }
}