// See dotnet run for more information
using System;
using System.IO;


namespace NamespaceProgram
{

    internal class Program
    {
        static void Main (string[] argd)
        {
            String line;
            String valores = "valores.txt";
            IEnumerable<string> linhas = File.ReadLines(@"C:\Users\lucas.caetano\OneDrive - SENAC-SC\3° SEMESTRE\dotnet\PrimeiraAvaliacao\valores.txt");
            int qtdLinhas = linhas.Count();

            try
            {
                Console.WriteLine($" QTD LINHAS: {qtdLinhas}");
                StreamReader ler = new StreamReader(valores);
            }
                           
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            int[] ListaNova = new int[qtdLinhas];
            int contador = 0;
            foreach(string item in linhas)
            {
                ListaNova[contador] = Int32.Parse(item);
                contador++;
          
            }
            
            for (int j = 0; j < qtdLinhas; j++)
            {
                int nova = ListaNova[j];

                int i = j - 1;  

                while (i > -1 && ListaNova[i] > nova)
                {
                    ListaNova[i + 1] = ListaNova[i];
                    i--;
                }
                ListaNova[i + 1] = nova;
                Console.WriteLine("Ordenando: " + string.Join(",", ListaNova)); 
            }
                        
            using (StreamWriter sw = new StreamWriter("valoresOrdenados.txt"))
            {
                sw.WriteLine($"Valores Ordenados: {string.Join(",", ListaNova)}");
            }
        }
    }

}


