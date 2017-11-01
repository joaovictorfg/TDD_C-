using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sistema1;

namespace Sistema1Teste
{
    /// <summary>
    /// Descrição resumida para UnitTest2
    /// </summary>
    [TestClass]
    public class ConversorTemperaturaTeste
    {
        public ConversorTemperaturaTeste()
        {
            //
            // TODO: Adicionar lógica de construtor aqui
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtém ou define o contexto do teste que provê
        ///informação e funcionalidade da execução de teste atual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de teste adicionais
        //
        // É possível usar os seguintes atributos adicionais enquanto escreve os testes:
        //
        // Use ClassInitialize para executar código antes de executar o primeiro teste na classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para executar código após a execução de todos os testes em uma classe
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize para executar código antes de executar cada teste 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para executar código após execução de cada teste
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestConversorTemperaturaFahrenheit()
        {
            double a = 0;
            double expected = 1.8 * a + 32;
            //ConversorTemperatura target = new ConversorTemperatura();
            double actual = ConversorTemperatura.converteCelsiusParaFahrenheit(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestConversorTemperaturaCelsius()
        {
            double a = 0;
            double expected = (5 / 9) * (a - 32);
            //ConversorTemperatura target = new ConversorTemperatura(a);
            double actual = ConversorTemperatura.converteFahrenheitParaCelsius(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
