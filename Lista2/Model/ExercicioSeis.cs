using System;

namespace ExercicioSeis
{
    public class ExercicioSeisClass
    {
        public static void ExercicioSeisVoid()
        { 
         int soma = 0;            
            for(int i =1; i <500; i++)
            {
                if(i%2!=0)
                {
                    if(i%7==0)
                    {
                        soma = soma + i;
                    }
                }
            }
        
        Console.WriteLine($"A soma de todos os números ímpares e múltiplos de 7 entre 1 e 500 é:{soma}");
        }
    }
}