
namespace Stack_LIFO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();

            //Rellenando o agregando elementos a la cola

            foreach(int numero in new int[] {2, 4, 6, 8, 10 })
            {
                numeros.Push(numero);
            }

            //Recorriendo la Stack
            Console.WriteLine("Recorriendo el Stack");
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //Eliminando elementos del Stack
            Console.WriteLine("Eliminando elementos");

            numeros.Pop();

            //Recorriendo la Stack
            Console.WriteLine("Recorriendo el Stack");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}