using System;

namespace ExercicioOnze
{
    public class ExercicioOnze
    {
        public static void ExercicioOnzeVoid()
        {
            Console.WriteLine("Informe o salário: R$");
            double salario = Double.Parse(Console.ReadLine());
            if(salario<=1903.98)
            {
                Console.WriteLine($"Você é isento do imposto de renda");
            }   
            else if(salario>=1903.99 && salario<=2826.65)
            {
                Console.WriteLine($"O valor do imposto de renda é R$ {salario*0.075}");
            }
            else if(salario>2826.65 && salario<=3751.05)
            {
                Console.WriteLine($"O valor do imposto de renda é R$ {salario*0.15}");
            }
            else if(salario>3751.05 && salario<4664.68)
            {
                Console.WriteLine($"O valor do imposto de renda é R$ {salario*0.225}");
            }                    
            else
                Console.WriteLine($"O valor do imposto de renda é R$ {salario*0.275}");
        }
         
    }
}