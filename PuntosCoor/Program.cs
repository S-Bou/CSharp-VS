using System;

//using static System.Math;

//using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }

        static void realizarTarea()
        {
                
            Punto origen = new Punto();         //x=0, y=0

            Punto destino = new Punto(128, 80);
         
            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de : {distancia}");

            Console.WriteLine($"Número de objetos creados: {Punto.ContadorDeObjetos()}");

        }

    }
}