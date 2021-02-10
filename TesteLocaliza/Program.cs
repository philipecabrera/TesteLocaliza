using System;
using System.Collections.Generic;

namespace TesteLocaliza.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Digite um número: ");
            //Recebe o número digitado
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("---------------//---------------");
            Console.WriteLine();
            Console.WriteLine("Número de Entrada: " + n);
            Console.WriteLine();

            //retorna todos seus Divisores
            List<long> arrayDeDivisores = NumerosDivisores.GetDivisores(n).NumerosDivisores;
            // retorna todos os números primos que estão entre os divisores
            List<long> arrayDePrimos = NumerosPrimos.GetPrimos(arrayDeDivisores).NumerosPrimos;

            //Imprime os Divisores
            Console.WriteLine(NumerosDivisores.PrintDivisores(arrayDeDivisores));
            Console.WriteLine();
            //Imprime os Números primos contidos nos divisores
            Console.WriteLine(NumerosPrimos.PrintPrimos(arrayDePrimos));
            Console.WriteLine();
            Console.WriteLine("---------------//---------------");
        }
    }
}
