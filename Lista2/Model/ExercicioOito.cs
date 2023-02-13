using System;

namespace ExercicioOito
{
    public class ExercicioOitoClass
    {
        public static void ExercicioOitoVoid()
        {
            int i = 0;
            int num = 0;
            int fat = 0;

            Console.WriteLine($"Informe o numero a ser calculado o fatorial: ");
            num = Int32.Parse(Console.ReadLine());

            fat = num;
            for (i = (num-1); i >= 1; i--)
            {
                fat = fat * i;
            }
         Console.WriteLine($"Fatorial de {num} é {fat}");
       }
    }
}