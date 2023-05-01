using System;

namespace ProyectoHerencia 
{
    class Program
    {
        static void Main(string[] args)
        {
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

            /* miJuan.getNombre();
             miBabieca.getNombre();
             miCopito.getNombre();*/

        }
    }
    class Mamiferos                                         //Clase principal o única
    {
        private String nombreSerVivo;

        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se valgan por si solas");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }
    }

    class Caballo : Mamiferos                               //Clase que hereda de Mamiferos
    {
        public Caballo(String nombreCaballo):base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Humano : Mamiferos                               //Clase que hereda de Mamiferos
    {
        public Humano(String nombreHumano):base(nombreHumano)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos                                //Clase que hereda de Mamiferos
    {
        public Gorila(String nombreGorila):base(nombreGorila) 
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
    }
}