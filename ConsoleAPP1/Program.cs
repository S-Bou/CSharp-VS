// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 18;

            bool puertaAbierta = true;

            Console.WriteLine("Vamos a evaluar si eres mayor de edad \n");

            if(edad >= 18 && puertaAbierta) Console.WriteLine("Si eres mayor de edad o la puerta está abierta \n");
            
            else Console.WriteLine("No eres mayor de edad o la puerta está cerrada \n");

            Console.WriteLine("Fin del programa");
        }
    }
}