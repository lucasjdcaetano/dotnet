using System;

namespace ExercicioDois
{
    public class ExercicioDoisClass
    {
        public static void ExercicioDoisVoid()
        {
            Console.WriteLine("Informe o lado A:");
            double ladoA = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o lado B:");
            double ladoB = Double.Parse(Console.ReadLine());
            Console.WriteLine($"A área é {ladoA * ladoB}");

        }
         
    }
}