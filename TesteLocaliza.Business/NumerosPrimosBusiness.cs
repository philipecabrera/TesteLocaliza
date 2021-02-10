using System;
using System.Collections.Generic;
using TesteLocaliza.DTO;

namespace TesteLocaliza.Business
{
	public class NumerosPrimosBusiness
	{
		public static NumerosPrimosDTO GetPrimos(List<long> arrayDeDivisores)
		{
			NumerosPrimosDTO primossDTO = new NumerosPrimosDTO();
			List<long> arrayDePrimos = new List<long>();
			arrayDeDivisores.ForEach(i =>
			{
				var flag = 0;
				long x;
				long m = i / 2;
				for (x = 2; x <= m; x++)
				{
					if (i % x == 0)
					{
						flag = 1;
						break;
					}
				}
				if (flag == 0)
					arrayDePrimos.Add(i);
			});

			primossDTO.NumerosPrimos = arrayDePrimos;
			return primossDTO;
		}
	}
}
