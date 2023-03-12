// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            Random numero = new Random();

            int aleatorio = numero.Next(0 ,100);

            Console.WriteLine("El número es: " + aleatorio);

        }
    }
}