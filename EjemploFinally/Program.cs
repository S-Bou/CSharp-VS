// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;

                int contador = 0;

                string path = @"C:\\Users\\bouyo\\Desktop\\Prueba.txt";

                archivo = new System.IO.StreamReader (path);

                while ((linea = archivo.ReadLine ()) != null)
                {
                    Console.WriteLine(linea);

                    contador++;
                }
            }
            catch
            {
                Console.WriteLine("Error con la lectura del archivo");
            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close ();
                }
                Console.WriteLine("Conexión con el fichero cerrada");
            }

        }
    }
}
