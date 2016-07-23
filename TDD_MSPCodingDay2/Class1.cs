using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_MSPCodingDay2
{
    public static class CalculoFinanceiro
    {
        public static double CalcularValorComJurosCompostos(
            double valorEmprestimo,
            int numMeses,
            double percTaxa)
        {
            return Math.Round(valorEmprestimo *
                Math.Pow(1.0 + (percTaxa / 100.0), numMeses), 2);
        }
    }
}