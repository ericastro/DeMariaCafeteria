using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsCafeteria;

namespace UnitTestCafeteria
{
    [TestClass]
    public class CapsulaTeste
    {
        //[Metodo]_[Condicao]_[ResultadoEsperado]

        [TestMethod]
        public void CapsulaForca_RecebeValorMaiorQue10_DeveRetornarInteiroIgualA0()
        {
            //arrange
            Capsula capsula = new Capsula();
            capsula.Forca = 20;
            int resultadoEsperado = 0;

            //Act
            int resultadoAtual = capsula.Forca;
            //Assert

            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void CapsulaForca_IncluirCapsula_RetornarOK()
        {
            //arrange
            Capsula capsula = new Capsula();
            capsula.Forca = 5;
            capsula.Descricao = "Nescafé Expresso";
            string resultadoEsperado = "ok";

            //Act
            string resultadoAtual = capsula.IncluirCapsula(capsula);
            //Assert

            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
    }
}
