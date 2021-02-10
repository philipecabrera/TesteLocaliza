using System;
using System.Collections.Generic;
using System.Text;
using TesteLocaliza.Business;
using TesteLocaliza.DTO;

namespace TesteLocaliza.App
{
    public class NumerosPrimos
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrayDeDivisores"></param>
        /// <returns></returns>
        public static NumerosPrimosDTO GetPrimos(List<long> arrayDeDivisores)
        {
            return NumerosPrimosBusiness.GetPrimos(arrayDeDivisores);
        }
        public static string PrintPrimos(List<long> arrayDePrimos)
        {
            return PrintBusiness.PrintPrimos(arrayDePrimos);

        }
    }
}
