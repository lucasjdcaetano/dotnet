using System;

namespace ExercicioDez
{
    public class ExercicioDezClass
    {
        public static void ExercicioDezVoid()
        {
            
            Console.WriteLine($"Informe o primeiro numero: ");
            double num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o segundo numero: ");
            double num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe qual operação deseja: ");
            Console.WriteLine($"[1] Adição (+) : ");
            Console.WriteLine($"[2] Subtração (-) : ");
            Console.WriteLine($"[3] Multiplicação (*) : ");
            Console.WriteLine($"[4] Divisão (/) : ");
            int op = Int32.Parse(Console.ReadLine());            
            switch (op)
            {
                case 1:
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
                case 2:
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
                case 3:
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
                case 4:
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;
            }
       }
    }
}