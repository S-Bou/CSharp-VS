
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string frase = "Mi nombre es Juan y mi nº de tfno es (+34)123-45-67, (+44)123-45-78 y mi código postal es 29679";

            string frase = "Mi wed es https://www.pildorasinformaticas.es";

            string patron = @"https://(www.)?pildorasinformaticas.es";

            Regex miRegex = new Regex(patron);

            MatchCollection elMatch = miRegex.Matches(frase);

            if (elMatch.Count > 0 ) Console.WriteLine("Se han encontrado núumeros de tfno");
            else Console.WriteLine("No se han encontrado númros");

        }
    }
}