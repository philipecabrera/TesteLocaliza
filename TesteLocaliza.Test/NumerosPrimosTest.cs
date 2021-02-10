using System;
using System.Collections.Generic;
using TesteLocaliza.Business;
using Xunit;

namespace TesteLocaliza.Test
{
    public class NumerosPrimosTest
    {
        [Theory]
        [InlineData(new long[] { 1, 3, 5 }, 45)]
        public void RetornaPrimosParaListaDeDivisorDoNumeroInformado(long[] esperado, long entrada)
        {
            Assert.Equal(String.Join(" ", NumerosPrimosBusiness.GetPrimos(NumerosDivisoresBusiness.GetDivisores(entrada).NumerosDivisores).NumerosPrimos.ToArray()), String.Join(" ", new List<long>(esperado).ToArray()));
        }

        [Theory]
        [InlineData(new long[] { 1, 3, 5 }, 45)]
        public void RetornaPrintPrimosParaListaDeDivisorDoNumeroInformado(long[] esperado, long entrada)
        {
            Assert.Equal
            (
                PrintBusiness.PrintPrimos
                (
                    NumerosPrimosBusiness.GetPrimos
                    (
                        NumerosDivisoresBusiness.GetDivisores
                        (
                            entrada
                        ).NumerosDivisores
                    ).NumerosPrimos
                ),
                "Divisores Primos:  " + String.Join
                (
                    " ",
                    new List<long>(esperado).ToArray()
                )
            );
        }
    }


}
