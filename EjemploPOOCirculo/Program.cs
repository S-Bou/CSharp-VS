
using System;

namespace EjemploCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo;  //Creación de objeto Circulo. Variable/objeto de tipo Círculo

            miCirculo = new Circulo();  //Iniciación de variable/objeto. Instanciar una clase. Instanciación

            miCirculo.calculoArea(5);

            Console.WriteLine($"El área es: {miCirculo.calculoArea(5)}");

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine($"El área del segundo circulo es: {miCirculo2.calculoArea(5)}");
        }
    }

    class Circulo                       //Clase circulo
    {
        const double pi = 3.1416;             //Propiedad de la clase. Campo de clase

        public double calculoArea(int radio)   //Método de clase
        {
            return pi * radio * radio;
        }
    }

}

