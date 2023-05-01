
using System;

namespace EjemploCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Circulo miCirculo;  //Creación de objeto Circulo. Variable/objeto de tipo Círculo

            miCirculo = new Circulo();  //Iniciación de variable/objeto. Instanciar una clase. Instanciación

            miCirculo.CalculoArea(5);

            Console.WriteLine($"El área es: {miCirculo.CalculoArea(5)}");

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine($"El área del segundo circulo es: {miCirculo2.CalculoArea(5)}");
            */

            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.CambiaValorEuro(1.45);

            Console.WriteLine(obj.Convierte(50));

        }
    }

    class Circulo                             //Clase circulo
    {
        private const double pi = 3.1416;      //Propiedad de la clase. Campo de clase

        public double CalculoArea(int radio)   //Método de clase
        {
            return pi * radio * radio;
        }
    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void CambiaValorEuro(double nuevoValor)
        {
            if(nuevoValor < 0)
            { 
                euro = 1.253; 
            
            }else{

                euro = nuevoValor;
            }
        }
    }

}

