

namespace DelegadosPredicados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> listaNumeros = new List<int>();
            listaNumeros.AddRange(new int[]{ 1, 2, 3, 4, 5, 6, 7,  8, 9, 10});

            //Declaramos delegado predicado
            Predicate<int> elDelegadoPred = new Predicate<int>(DamePares);

            List<int> numPares = listaNumeros.FindAll(elDelegadoPred);

            foreach (int i in numPares)
            {
                Console.WriteLine(i);
            }
            */

            List<Personas> gente = new List<Personas>();

            Personas P1 = new Personas();
            P1.Nombre = "Juan";
            P1.Edad = 18;

            Personas P2 = new Personas();
            P2.Nombre = "María";
            P2.Edad = 28;

            Personas P3 = new Personas();
            P3.Nombre = "Ana";
            P3.Edad = 37;

            gente.AddRange(new Personas[] { P1, P2, P3 });

            Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteJuan);
            //Predicate<Personas> elPredicado = new Predicate<Personas>(ExistenMayoresEdad);

            bool existe = gente.Exists(elPredicado);

            if (existe) { Console.WriteLine("Hay personas que se llaman Juan o hay mayores de edad."); }
            else { Console.WriteLine("No hay nadie llamando Juan o no hay mayores de edad."); }
        }
        static bool ExisteJuan(Personas persona)
        {
            if (persona.Nombre == "Juan") return true;
            else return false;
        }
        static bool ExistenMayoresEdad(Personas persona)
        {
            if (persona.Edad >= 18) return true;
            else return false;
        }
        static bool DamePares(int num)
        {
            if(num % 2 == 0)return true;
            else return false;
        }
    }
    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }

}