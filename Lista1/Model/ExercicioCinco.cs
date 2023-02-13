using System;

namespace ExercicioCinco
{
    public class ExercicioCincoClass
    {
        public static void ExercicioCincoVoid()
        {
            Console.WriteLine("Informe o valor de A:");
            double valorA = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B:");
            double valorB = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C:");
            double valorC = Double.Parse(Console.ReadLine());

            double delta = ((valorB*valorB)- 4*valorA*valorC);
            double x1 = ((valorB*-1) + Math.Sqrt(delta))/(2*valorA);
            double x2 = ((valorB*-1) - Math.Sqrt(delta))/(2*valorA);

            Console.WriteLine($"O valor de x': {x1}");
            Console.WriteLine($"O valor de x'': {x2}");
        }
         
    }
}