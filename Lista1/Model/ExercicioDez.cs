using System;

namespace ExercicioDez
{
    public class ExercicioDez
    {
        public static void ExercicioDezVoid()
        {
            Console.WriteLine("Informe o primeiro valor:");
            double valorUm = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            double valorDois = Double.Parse(Console.ReadLine());
            if(valorUm>(valorDois * 2))
            {
                Console.WriteLine($"O primeiro valor é maior que o dobro do segundo valor");
            }            
            else
                Console.WriteLine($"O primeiro valor é menor que o dobro do segundo valor");
        }
         
    }
}