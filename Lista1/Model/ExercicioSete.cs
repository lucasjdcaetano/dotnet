using System;

namespace ExercicioSete
{
    public class ExercicioSeteClass
    {
        public static void ExercicioSeteVoid()
        {
            Console.WriteLine("Informe o faturamento:");
            double faturamento = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tempo(min) da viagem:");
            double imposto = Double.Parse(Console.ReadLine());
            
            Console.WriteLine($"O percentual de imposto é {faturamento/imposto}%");
        }
         
    }
}