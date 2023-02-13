using System;

namespace ExercicioOito
{
    public class ExercicioOitoClass
    {
        public static void ExercicioOitoVoid()
        {
            Console.WriteLine("Informe um número:");
            double num = Double.Parse(Console.ReadLine());
            
                if(num%2==0)
                {
                    Console.WriteLine($"O número é par");
                }
                else
                    Console.WriteLine($"O número é impar");
        }
    }
}