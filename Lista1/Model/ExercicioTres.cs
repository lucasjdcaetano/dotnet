using System;

namespace ExercicioTres
{
    public class ExercicioTresClass
    {
        public static void ExercicioTresVoid()
        {
            Console.WriteLine("Informe a largura:");
            double largura = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura:");
            double altura = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura:");
            double profundidade = Double.Parse(Console.ReadLine());
            Console.WriteLine($"O volume é {largura * altura * profundidade}");

        }
         
    }
}