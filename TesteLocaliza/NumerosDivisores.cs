using System;
using System.Collections.Generic;
using System.Text;
using TesteLocaliza.Business;
using TesteLocaliza.DTO;

namespace TesteLocaliza.App
{
    public class NumerosDivisores
    {
       /// <summary>
       /// Retorna todos os divisires de um numero Long
       /// </summary>
       /// <param name="n"></param>
       /// <returns></returns>
        public static NumerosDivisoresDTO GetDivisores(long n)
        {
            return NumerosDivisoresBusiness.GetDivisores(n);
        }

        public static string PrintDivisores(List<long> arrayDeDivisores)
        {
           return PrintBusiness.PrintDivisores(arrayDeDivisores);
        }
    }
}
