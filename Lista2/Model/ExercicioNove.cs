using System;

namespace ExercicioNove
{
    public class ExercicioNoveClass
    {
        public static void ExercicioNoveVoid()
        {
            Console.WriteLine($"Informe a altura: ");
            double alt = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o peso: ");
            double peso = Double.Parse(Console.ReadLine());

            double imc = peso/(alt*alt);
            if(imc<18.5)
            Console.WriteLine($"Seu IMC é {imc} e você está abaixo do peso");
            if(imc>=18.6 && imc<=24.9)
            Console.WriteLine($"Seu IMC é {imc} e você está no peso ideal");
            if(imc>=25.0 && imc<=29.9)
            Console.WriteLine($"Seu IMC é {imc} e você está levemente acima do peso");
            if(imc>=30.0 && imc<=34.9)
            Console.WriteLine($"Seu IMC é {imc} e você está com obesidade grau 1");
            if(imc>=35.0 && imc<=34.9)
            Console.WriteLine($"Seu IMC é {imc} e você está com obesidade grau 2");
            if(imc>=40.0)
            Console.WriteLine($"Seu IMC é {imc} e você está com obesidade grau 3");
       }
    }
}