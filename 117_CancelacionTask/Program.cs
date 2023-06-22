namespace _117_CancelacionTask
{
    internal class Program
    {
        static int acumulador = 0;
        static void Main(string[] args)
        {

            CancellationTokenSource miToken = new CancellationTokenSource();

            CancellationToken cancellationToken = miToken.Token;

            Task tarea = Task.Run(() => RealizarTarea(cancellationToken));

            for(int i = 0; i < 100; i++)
            {
                acumulador += 30;
                Thread.Sleep(1000);

                if(acumulador > 100)
                {
                    miToken.Cancel();
                    break;
                }
            }

            Thread.Sleep(1000);

            Console.WriteLine("VALOR DEL ACUMULADOR: " + acumulador);

            Console.ReadLine();
        }

        static void RealizarTarea(CancellationToken token)
        {
            for (int i = 0; i < 100; i++)
            {
                acumulador++;

                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine("Ejecutando tarea el Thread: " + miThread);

                Console.WriteLine(acumulador);

                if (token.IsCancellationRequested)
                {
                    acumulador = 0;
                    return;
                }
            }
        }
    }
}