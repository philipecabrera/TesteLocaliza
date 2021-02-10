using System;
using System.Collections.Generic;
using System.Text;

namespace TesteLocaliza.Business
{
    public class PrintBusiness
    {
        public static string PrintDivisores(List<long> arrayDeDivisores)
        {
            return ("Números divisores:  " + String.Join(" ", arrayDeDivisores.ToArray()));
        }

        public static string PrintPrimos(List<long> arrayDePrimos)
        {
            return ("Divisores Primos:  " + String.Join(" ", arrayDePrimos.ToArray()));
        }

    }
}
