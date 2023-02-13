using System;

namespace ExercicioDois 
{
    public class ExercicioDoisClass
    {
        public static void ExercicioDoisVoid()
        {
            Console.WriteLine("Informe um número de 1 a 12");
            int mes = 0;
            do{
                mes = Int32.Parse(Console.ReadLine());
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("O número é referente ao mês de JANEIRO");
                    break;
                    case 2:
                        Console.WriteLine("O número é referente ao mês de FEVEREIRO");
                    break;
                    case 3:
                        Console.WriteLine("O número é referente ao mês de MARÇO");
                    break;
                    case 4:
                        Console.WriteLine("O número é referente ao mês de ABRIL");
                    break;
                    case 5:
                        Console.WriteLine("O número é referente ao mês de MAIO");
                    break;
                    case 6:
                        Console.WriteLine("O número é referente ao mês de JUNHO");
                    break;
                    case 7:
                        Console.WriteLine("O número é referente ao mês de JULHO");
                    break;
                    case 8:
                        Console.WriteLine("O número é referente ao mês de AGOSTO");
                    break;
                    case 9:
                        Console.WriteLine("O número é referente ao mês de SETEMBRO");
                    break;
                    case 10:
                        Console.WriteLine("O número é referente ao mês de OUTUBRO");
                    break;
                    case 11:
                        Console.WriteLine("O número é referente ao mês de NOVEMBRO");
                    break;
                    case 12:
                        Console.WriteLine("O número é referente ao mês de DEZEMBRO");
                    break;
                }
            }while(mes != 0);
        }
    }
}