using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAluguelCarro
    {
        static public double Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
        {
            double valorDiaria = 95;
            double valorQuilometragem = 0.35;
            double total = dias * valorDiaria + valorQuilometragem * (quilometragemFinal - quilometragemInicial);
            return total;

        }
    }
}
