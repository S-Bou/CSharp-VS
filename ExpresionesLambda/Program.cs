

using System.Threading.Channels;

namespace ExpresionesLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personas P1 = new Personas();
            P1.Nombre = "Juan";
            P1.Edad = 18;

            Personas P2 = new Personas();
            P2.Nombre = "Juan";
            P2.Edad = 18;
            
            ComparaPersonas comparaEdad = (persona1, persona2) => persona1 == persona2;
            Console.WriteLine(comparaEdad(P1.Nombre, P2.Nombre));

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);

            //foreach(int numero in numerosPares) Console.WriteLine(numero);

            numerosPares.ForEach(numero =>
            {
                Console.WriteLine("El número par es: ");
                Console.WriteLine(numero);
            });

            //Uso del delegado
            //OperacionesMatematicas operacion = new OperacionesMatematicas(Cuadrado);
            //Console.WriteLine(operacion(4));

            //Uso del delegado con expresión lambda
            //OperacionesMatematicas operacion = new OperacionesMatematicas(num => num*num);
            //Console.WriteLine(operacion(4));

            //OperacionesMatematicas operacion = new OperacionesMatematicas((num1, num2) => num1 + num2);
            //Console.WriteLine(operacion(4, 7));
        }

        //public delegate int OperacionesMatematicas(int numero);
        public delegate int OperacionesMatematicas(int numero1, int numero2);

        //public delegate bool ComparaPersonas(int edad1, int edad2);
        public delegate bool ComparaPersonas(String n1, String n2);

        /*public static int Cuadrado(int num)
        {
            return num * num;
        }*/
        /*
        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }*/
    }
    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
