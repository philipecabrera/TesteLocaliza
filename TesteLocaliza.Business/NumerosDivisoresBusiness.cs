using System;
using System.Collections.Generic;
using TesteLocaliza.DTO;

namespace TesteLocaliza.Business
{
    public class NumerosDivisoresBusiness
    {
        /// <summary>
        /// Retorna todos os divisires de um numero Long
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static NumerosDivisoresDTO GetDivisores(long n)
        {
            NumerosDivisoresDTO divisoresDTO = new NumerosDivisoresDTO();
            List<long> arrayDeDivisores = new List<long>();
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    arrayDeDivisores.Add(i);

            divisoresDTO.NumerosDivisores = arrayDeDivisores ;
            return divisoresDTO;
        }
    }
}
