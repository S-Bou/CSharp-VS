namespace TrabajoConThreads
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread t2 = new Thread(MetodoSaludoDos);
            t2.Start();
            t2.Join();


            Console.WriteLine("Hello, people from thread 1");
            Thread.Sleep(500);

            Console.WriteLine("Hello, people from thread 1");
            Thread.Sleep(500);

            Console.WriteLine("Hello, people from thread 1");
            Thread.Sleep(500);

            Console.WriteLine("Hello, people from thread 1");
            Thread.Sleep(500);

            Console.WriteLine("Hello, people from thread 1");
            Thread.Sleep(500);

            Thread t3 = new Thread(MetodoSaludoTres);
            t3.Start();
            t3.Join();
        }

        static void MetodoSaludoDos()
        {
            Console.WriteLine("Hello, people from thread 2");
            Thread.Sleep(500);

            Console.WriteLine("Hello, people from thread 2");
            Thread.Sleep(500);

            Console.WriteLine("Hello, people from thread 2");
            Thread.Sleep(500);

            Console.WriteLine("Hello, people from thread 2");
            Thread.Sleep(500);

            Console.WriteLine("Hello, people from thread 2");
            Thread.Sleep(500);
        }

        static void MetodoSaludoTres()
        {
            Console.WriteLine("Hello, people from thread 3");
            Thread.Sleep(500);

            Console.WriteLine("Hello, people from thread 3");
            Thread.Sleep(500);

            Console.WriteLine("Hello, people from thread 3");
            Thread.Sleep(500);

            Console.WriteLine("Hello, people from thread 3");
            Thread.Sleep(500);

            Console.WriteLine("Hello, people from thread 3");
            Thread.Sleep(500);
        }
    }
}