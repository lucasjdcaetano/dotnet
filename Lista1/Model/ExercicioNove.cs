using System;

namespace ExercicioNove
{
    public class ExercicioNoveClass
    {
        public static void ExercicioNoveVoid()
        {
            Console.WriteLine("Informe a primeira string:");
            string primeiraString = Console.ReadLine();
            Console.WriteLine("Informe a segunda string:");
            string segundaString = Console.ReadLine();
                if(String.Equals(primeiraString,segundaString))
                {
                    Console.WriteLine($"As Strings possuem o mesmo valor");
                }            
                else
                    Console.WriteLine($"Valores diferentes");
        }
         
    }
}