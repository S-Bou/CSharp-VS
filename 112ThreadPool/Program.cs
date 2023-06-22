namespace _112ThreadPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                /*
                Thread t = new Thread(EjecutarTarea); 
                t.Start();
                */

                ThreadPool.QueueUserWorkItem(EjecutarTarea, i);
            }

            Console.ReadLine();
        }

        static void EjecutarTarea(Object o)
        {
            int nTarea = (int)o;

            Console.WriteLine($"Thread nº: {Thread.CurrentThread.ManagedThreadId} ha comenzado la tarea nº " + nTarea);

            Thread.Sleep(1000);

            Console.WriteLine($"Thread nº: {Thread.CurrentThread.ManagedThreadId} ha terminado la tarea nº " + nTarea);
        }
    }
}