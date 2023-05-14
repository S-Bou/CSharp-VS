
namespace Delegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creación del objeto delegedo apuntando a MensajeBienvenida
            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);
            //Utilización del delegado para llamar al método SaludoBienvenida
            ElDelegado();

            ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
            ElDelegado();
        }

        //Definición del objeto delegado
        delegate void ObjetoDelegado();
    }

    class MensajeBienvenida
    {
        public static void SaludoBienvenida()
        {
            Console.WriteLine("Hola acabo de llegar. ¿Qué tal?");
        }
    }

    class MensajeDespedida
    {
        public static void SaludoDespedida()
        {
            Console.WriteLine("Hola, ya me marcho. Hasta luego");
        }
    }
}