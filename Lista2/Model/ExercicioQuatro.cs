using System;

namespace ExercicioQuatro 
{
    public class ExercicioQuatroClass
    {
        public static void ExercicioQuatroVoid()
        {
            Console.WriteLine("Informe a tabuada desejada:");
            double tabuada = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe até qual número você deseja a tabuada:");
            int limite = Int32.Parse(Console.ReadLine());
            for(int i = 1; i < (limite+1); i++)
            {
                Console.WriteLine($"{tabuada} X {i} = {tabuada*i}");
            }
         
        }
         
    }
}