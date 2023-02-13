using System;

namespace ExercicioSeis
{
    public class ExercicioSeisClass
    {
        public static void ExercicioSeisVoid()
        {
            Console.WriteLine("Informe a distância(km) da viagem:");
            double distancia = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tempo(min) da viagem:");
            double tempo = Double.Parse(Console.ReadLine());
            
            Console.WriteLine($"A velocidade média da viagem é : {distancia/tempo}");
        }
         
    }
}