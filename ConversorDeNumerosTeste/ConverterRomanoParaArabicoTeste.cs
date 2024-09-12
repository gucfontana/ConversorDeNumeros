using ConversorDeNumeros;

namespace ConversorDeNumerosTeste;

[TestClass]
public class ConverterRomanoParaArabicoTeste
{
    [TestMethod]
    public void DeveConverterNumeroRomanoParaArabico()
    {
        // arrange
        ConversorNumeros converter = new ConversorNumeros();
        string numeroRomano = "X";
        // action
        int resultado = converter.ConverterRomanoParaArabico(numeroRomano);
        // assert
        Assert.AreEqual(10, resultado);
    }
}
