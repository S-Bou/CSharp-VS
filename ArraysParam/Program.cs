using System;
using System.Runtime.CompilerServices;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] numeros = new int[4];

            numeros[0] = 7;
            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;

            ProcesaDatos(numeros);

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el main");

            foreach (int i in arrayElementos) Console.WriteLine(i);
        }

        static void ProcesaDatos(int[] datos)
        {
            foreach (int i in datos) 
            {
                Console.WriteLine(i);
            }

            for(int i = 0; i < datos.Length; i++)
            {
                datos[i] += 10;
            }
        }

        static int[] LeerDatos() 
        {
            Console.WriteLine("¿Cuántos elementos quieres que tenga el arrray?");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];    
            
            for (int i = 0; i<numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posición {i}");

                respuesta = Console.ReadLine();

                int datosElemento = int.Parse(respuesta);

                datos[i] = datosElemento;
            }

            return datos;
        }
    }
}