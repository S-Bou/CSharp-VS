namespace _111ThreadsCompleted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tareaTerminada = new TaskCompletionSource<bool>();

            var hilo1 = new Thread(() =>
            {
                for(int i=0; i<5; i++)
                {
                    Console.WriteLine("Hilo 1");
                    Thread.Sleep(1000);
                }

                tareaTerminada.TrySetResult(true);

            });

            var hilo2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 2");
                    Thread.Sleep(1000);
                }
            });

            hilo1.Start();

            var resultado = tareaTerminada.Task.Result;

            hilo2.Start();
        }
    }
}