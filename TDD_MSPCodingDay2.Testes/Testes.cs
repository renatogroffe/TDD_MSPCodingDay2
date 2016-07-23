using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_MSPCodingDay2.Testes
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void Teste1()
        {
            double valor = CalculoFinanceiro
                .CalcularValorComJurosCompostos(
                    10000, 12, 2);
            Assert.AreEqual(12682.42, valor);
        }

        [TestMethod]
        public void Teste2()
        {
            double valor = CalculoFinanceiro
                .CalcularValorComJurosCompostos(
                    11937.28, 24, 4);
            Assert.AreEqual(30598.88, valor);
        }

        [TestMethod]
        public void Teste3()
        {
            double valor = CalculoFinanceiro
                .CalcularValorComJurosCompostos(
                    15000, 36, 6);
            Assert.AreEqual(122208.78, valor);
        }
    }
}