using System;

namespace MyApp 
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var valores = new[] { 15, 28, 35, 75.5, 30.30, 90, 666 };

            //Arrays de objetos

            Empleados[] arrayEmpleados = new Empleados[3];

            arrayEmpleados[0] = new Empleados("Sara", 37);

            Empleados Ana = new Empleados("Ana", 27);

            arrayEmpleados[1] = Ana;

            arrayEmpleados[2] = new Empleados("Manuel", 51); 

            //Array de tipo o clases anónimas

            var personas = new[]
            {
                new { Nombre = "Juan", Edad = 19 },

                new { Nombre = "María", Edad = 49 },

                new { Nombre = "Diana", Edad = 35 }

            };

            for(int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            for (int i = 0; i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }

            foreach (var item in valores)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public String getInfo()
        {
            return "Nombre del empleado: " + nombre + "; Edad: " + edad;
        }

        private String nombre;
        private int edad;
    }
}



