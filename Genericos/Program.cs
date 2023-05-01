namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<DateTime> archivos = new AlmacenObjetos<DateTime>(4);

            /*
            archivos.agregar("Juan");
            archivos.agregar("Elena");
            archivos.agregar("Antonio");
            archivos.agregar("Sandra");
            */
            
            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime());


            DateTime nombrePersona = archivos.getElemento(2);

            Console.WriteLine(nombrePersona);
        }
    }

    class AlmacenObjetos<T>
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z];
            
        }
        public void agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }
        public T getElemento(int i)
        {
            return datosElemento[i];
        }

        private T[] datosElemento;

        private int i = 0;

    }

    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        { 
            return salario; 
        }

        private double salario;
    }

}
