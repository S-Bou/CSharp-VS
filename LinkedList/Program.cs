namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int numero in new int[] {10, 8, 6, 4, 2, 0}) 
            {
                numeros.AddLast(numero);
            }
            /*
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }*/
            for(LinkedListNode<int> nodo=numeros.First; nodo != null; nodo = nodo.Next)
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }
        }
    }
}