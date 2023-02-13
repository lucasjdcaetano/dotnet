using System;

namespace ExercicioSete
{
    public class ExercicioSeteClass
    {
        public static void ExercicioSeteVoid()
        {
            int cont = 0;
            double somanotas = 0;
            double nota = 0;

            do
            {                
                Console.WriteLine($"Informe a nota: ");
                nota = Double.Parse(Console.ReadLine());
                    if(nota>=0)
                    {
                    somanotas += nota;
                    cont ++;
                    }
            } while (nota >= 0);
            
               double media = ((somanotas) /cont);
               Console.WriteLine($"A médias das notas positivas é: {media}");
        }
    }
}