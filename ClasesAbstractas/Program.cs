using System;

namespace InterfacesClase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Ejemplo de herencias");
            Caballo miBabieca = new Caballo("Babieca");           //El nombre de la instancia no es el mismo que el argumento
            Humano miJuan = new Humano("Juan");
            Gorila miCopito = new Gorila("Copito");

            Mamiferos animal = new Caballo("Bucéfalo");           //Principio de sustitución
            Mamiferos persona = new Humano("Juan");

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = miBabieca;
            almacenAnimales[1] = miJuan;
            almacenAnimales[2] = miCopito;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            //almacenAnimales[1].getNombre();

            IMamiferosTerrestres ImiBabieca = miBabieca;

            Ballena miWally = new Ballena("Wally");

            miWally.nadar();

            Console.WriteLine("Numero de patas de Babieca: " + ImiBabieca.NumeroPatas());
            */

            Lagartija Juancho = new Lagartija("Juancho");

            Juancho.getNombre();

            Humano Juan = new Humano("Juan");

            Juan.getNombre();

        }
    }

    interface IMamiferosTerrestres
    {
        int NumeroPatas();

    }

    interface IAnimalesYDeportes
    {
        string TipoDeporte();

        Boolean EsOlimpico();
    }

    interface ISaltoConPatas
    {
        int NumeroPatas();
    }

    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();
    }

    class Lagartija : Animales
    {
        public Lagartija(String nombre)
        {
            NombreReptil = nombre;
        }
        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es: " + NombreReptil);
        }

        private String NombreReptil;
    }

    class Mamiferos : Animales                                        //Clase principal o única
    {
        private String NombreSerVivo;

        public Mamiferos(String nombre)
        {
            NombreSerVivo = nombre;
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se valgan por si solas");
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del mamífero es: " + NombreSerVivo);
        }

    }

    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas        //Clase que hereda de Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }

        public string TipoDeporte()
        {
            return "Hipica";
        }

        public Boolean EsOlimpico()
        {
            return true;
        }
    }

    class Humano : Mamiferos                               //Clase que hereda de Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos, IMamiferosTerrestres                                //Clase que hereda de Mamiferos
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public int NumeroPatas()
        {
            return 2;

        }
    }

    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Hola soy capaz de nadar");
        }
    }
}