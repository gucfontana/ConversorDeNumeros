using System.Text;

namespace ConversorDeNumeros
{
    public class ConversorNumeros
    {
        readonly private static Dictionary<char, int> DicionarioRomano = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public int ConverterRomanoParaArabico(string numeroRomano)
        {
            int total = 0;
            int valorPrevio = 0;

            foreach (char numeral in numeroRomano)
            {
                int valor = DicionarioRomano[numeral];

                if (valor > valorPrevio)
                {
                    total += valor - 2 * valorPrevio;
                }
                else
                {
                    total += valor;
                }

                valorPrevio = valor;
            }

            return total;
        }

        public string ConverterArabicoParaRomano(int numeroArabico)
        {
            if (numeroArabico < 1 || numeroArabico > 3999)
                throw new ArgumentOutOfRangeException(nameof ( numeroArabico ));

            var valores = new[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var simbolosRomanos = new[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            var resultadoEmNumeroRomano = new StringBuilder();

            for ( int i = 0 ; i < valores.Length ; i++ )
            {
                while ( numeroArabico >= valores[i] )
                {
                    numeroArabico -= valores[i];
                    resultadoEmNumeroRomano.Append(simbolosRomanos[i]);
                }
            }

            return resultadoEmNumeroRomano.ToString();
        }
    }
}

