using System;

namespace ExercicioUm 
{
    public class ExercicioUmClass
    {
        public static void ExercicioUmVoid()
        {
            Console.WriteLine("Informe a primeira nota:");
            double notaUm = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota:");
            double notaDois = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota:");
            double notaTres = Double.Parse(Console.ReadLine());
            double media = ((notaUm + notaDois + notaTres) /3);
            if(media>7)
            {
                Console.WriteLine($"A média é {media}, você foi aprovado");
            }
            else
                Console.WriteLine($"A média é {media}, você foi reprovado");
        }
         
    }
}