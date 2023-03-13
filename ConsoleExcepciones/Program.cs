
using System;
using System.Threading.Channels;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int minumero;

            int intentos = 0;

            Console.WriteLine("Introduce un nº entre 0 y 100");

            do
            {
                intentos++;

                try
                {
                    minumero = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("No has introducido un valor numérico válido. Se toma como nº introducido el 0");
                    minumero = 0;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Has introducido uun valor demasiado alto. Se toma como nº introducido el 0");
                    minumero = 0;
                }

                if (minumero > aleatorio) Console.WriteLine("El nº es más bajo");

                if (minumero < aleatorio) Console.WriteLine("El nº es más alto");

            } while (aleatorio != minumero);

            Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

            Console.WriteLine("Más cosas");
        }
    }
}