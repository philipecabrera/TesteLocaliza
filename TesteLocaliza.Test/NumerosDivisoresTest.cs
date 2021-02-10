using System;
using System.Collections.Generic;
using TesteLocaliza.Business;
using Xunit;

namespace TesteLocaliza.Test
{
    public class NumerosDivisiresTest
    {
        [Theory]
        [InlineData(new long[] { 1, 3, 5, 9, 15, 45 }, 45)]
        public void RetornaPrimosParaListaDeDivisorDoNumeroInformado(long[] esperado, long entrada)
        {
            Assert.Equal(String.Join(" ", NumerosDivisoresBusiness.GetDivisores(entrada).NumerosDivisores.ToArray()), String.Join(" ", new List<long>(esperado).ToArray()));
        }

        [Theory]
        [InlineData(new long[] { 1, 3, 5, 9, 15, 45 }, 45)]
        public void RetornaPrintPrimosParaListaDeDivisorDoNumeroInformado(long[] esperado, long entrada)
        {
            Assert.Equal
            (
                PrintBusiness.PrintDivisores
                (
                    NumerosDivisoresBusiness.GetDivisores
                    (
                        entrada
                    ).NumerosDivisores
                ),
                "Números divisores:  " + String.Join
                (
                    " ",
                    new List<long>
                    (
                        esperado
                    ).ToArray()
                )
            );
        }
    }
}
