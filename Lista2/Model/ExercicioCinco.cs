using System;

namespace ExercicioCinco 
{
    public class ExercicioCincoClass
    {
        public static void ExercicioCincoVoid()
        {
            Console.WriteLine("Informe a palavra desejada:");
            string palavra = Console.ReadLine();
            
            foreach( char letra in palavra)
            {
                Console.WriteLine($"{letra}");
            }
        }
    }
}