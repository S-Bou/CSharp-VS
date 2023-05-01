namespace Destructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miarchivo = new ManejoArchivos();
            miarchivo.mensaje();
            //Console.WriteLine("Hello, World!");
        }
    }

    class ManejoArchivos
    {
        StreamReader archivo = null;

        int contador = 0;

        string linea;

        public ManejoArchivos()
        {
            archivo = new StreamReader(@"D:\Projects\CSharp-VS\texto.txt");

            while((linea=archivo.ReadLine()) !=null) 
            {
                Console.WriteLine(linea);

                contador++; 

            }
        }
        public void mensaje()
        {
            Console.WriteLine("Hay {0} líneas", contador);
        }

        ~ManejoArchivos()
        {
            archivo.Close();
        }
    }

}