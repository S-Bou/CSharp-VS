using System;

namespace HerenciaVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche();
            Avion avion = new Avion();

            coche.conducir();
            avion.conducir();

            Console.WriteLine();
            Console.WriteLine("Ejemplo de polimorfismo");

            Vehiculo miVehiculo;            //Creación de objeto

            miVehiculo = coche;

            miVehiculo.conducir();          //Aquí el objeto se comporta como un coche

            miVehiculo = avion;

            miVehiculo.conducir();          //Aquí el objeto se comporta como un avión

        }
    }

    class Vehiculo
    {
        public void arrancarMotor()
        {
            Console.WriteLine("Arranca el motor");
        }
        public void pararMotor()
        {
            Console.WriteLine("Se para el motor");
        }
        public virtual void conducir()
        {
            Console.WriteLine("Conduciendo vehículo");
        }
     }
    class Coche : Vehiculo
    {
        public override void conducir()
        {
            Console.WriteLine("Conduciendo coche");
        }
    }

    class Avion : Vehiculo
    {
        public override void conducir()
        {
            Console.WriteLine("Conduciendo avión");
        }
    }
}

