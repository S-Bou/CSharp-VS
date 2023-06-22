using System.Linq.Expressions;

namespace _109ThreadsBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria CuentaFamilia = new CuentaBancaria(2000);

            Thread[] hilosPersonas = new Thread[15];

            for(int i = 0; i < hilosPersonas.Length; i++)
            {
                Thread t = new Thread(CuentaFamilia.VamosRetirarEfectivo);
                
                t.Name= i.ToString();

                hilosPersonas[i] = t;
            }

            for (int i = 0;i < hilosPersonas.Length;i++) { hilosPersonas[i].Start(); }  
        }

        class CuentaBancaria
        {
            private Object bloqueaSaldoPositivo = new object();

            double Saldo { set; get; }

            public CuentaBancaria(double Saldo)
            {
                this.Saldo = Saldo;
            }

            public double RetirarEfectivo(double cantidad)
            {
                if((Saldo - cantidad) < 0)
                {
                    Console.WriteLine($"Lo siento quueda {Saldo} euros en la cuenta. Hilo: {Thread.CurrentThread.Name}");

                    return Saldo;
                }

                lock (bloqueaSaldoPositivo)
                {

                    if (Saldo >= cantidad)
                    {
                        Console.WriteLine("Retirado {0} y queda {1} en la cuenta {2}", cantidad, (Saldo - cantidad), Thread.CurrentThread.Name);

                        Saldo -= cantidad;
                    }
                    return Saldo;
                }
            }

            public void VamosRetirarEfectivo()
            {
                Console.WriteLine("Está sacando dinero el hilo: {0}", Thread.CurrentThread.Name);
                for(int i = 0; i < 4; i++) RetirarEfectivo(500);
            }
        }
    }
}