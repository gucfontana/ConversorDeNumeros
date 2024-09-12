using ConversorDeNumeros;

namespace ConversorDeNumerosTeste
{
    [TestClass]
    public class ConverterArabicoParaRomanoTeste
    {
        [TestMethod]
        public void DeveConverterNumeroArabicoParaRomano()
        {
            // arrange
            ConversorNumeros conversor = new ConversorNumeros();
            int numeroArabico = 10;
            // action
            string resultado = conversor.ConverterArabicoParaRomano(numeroArabico);
            // assert
            Assert.AreEqual("X", resultado);
        }
    }
}
