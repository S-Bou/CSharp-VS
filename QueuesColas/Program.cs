
namespace QueuesColas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();

            //Rellenando o agregando elementos a la cola
            foreach (int numero in new int[] { 2, 4, 6, 8, 10 })
            {
                numeros.Enqueue(numero);
            }
            
            //Recorriendo la cola
            Console.WriteLine("Recorriendo el Queue");
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //Eliminando elementos del Queue
            Console.WriteLine("Eliminando elementos");
            numeros.Dequeue();
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
