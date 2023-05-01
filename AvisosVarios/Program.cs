using System;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();

            av1.mostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Jefatura Provincial Madris", "Sanción de velocidad: 300 $", "02.05.09");

            Console.WriteLine(av2.getFecha());
            
            av2.mostrarAviso();
        }
    }
}
