namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();        //Declarar una lista (coleccón de tipo lista)

            Console.WriteLine("Introduce elementos en la colección (0 para salir)");

            int elem = 1;

            while(elem != 0)
            {
                elem = Int32.Parse(Console.ReadLine());
                numeros.Add(elem);
            }

            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine("Elemntos introducidos:");

            foreach (int elemento in numeros)
            {
                Console.WriteLine(elemento);
            }



            //-------------------------------------------------------------------------------------------------------------------------------------------------

            /*
            Console.WriteLine("¿Cuántos elementos quieres introducir");     //Guarda los elementos introducidos en una colección 
            
            int elem = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < elem; i++) 
            {
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Elementos introducidos:");
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            */


            //-------------------------------------------------------------------------------------------------------------------------------------------------

            /*
            int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };             //Guarda los dator de un array en una colección

            for(int i=0;  i<listaNumeros.Length; i++) 
            {
                numeros.Add(listaNumeros[i]);
            }

            for(int i = 0; i < numeros.Count; i++) 
            {
                Console.WriteLine(numeros[i]);
            }
            */
        }
    }
}