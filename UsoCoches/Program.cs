
using System;

namespace UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();                       //TODO: Crea objeto/instancia de tipo coche + da estado inicial a coche1

            Coche coche2 = new Coche();

            Console.WriteLine(coche1.GetInfoCoche());

            Console.WriteLine(coche2.GetInfoCoche());

            Coche coche3 = new Coche(4500.25, 1200.35);

            Console.WriteLine(coche3.GetInfoCoche());

            coche3.SetExtras(true, "cuero");

            Console.WriteLine(coche3.GetExtras());
        }

    }

    partial class Coche
    {
        public Coche()                                          //TODO: Constructor uno, más de un constructor -> sobrecarga de constructores
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "tela";
        }

        public Coche(double largoCoche, double anchoCoche)      //TODO: Constructor dos
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "tela";
        }
    }
    partial class Coche
    {
        public string GetInfoCoche()
        {
            return "Información del coche:\n" + "Ruedas: " + ruedas + "\nLargo: " + largo + "\nAncho: " + ancho + "\n";
        }

        public int GetRuedas()
        {
            return ruedas;
        }

        public void SetExtras(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public String GetExtras()
        {
            return "Extras del coche:\n" + "Tapicería: " + tapiceria + "\n" + "Climatizador: " + climatizador + "\n";
        }

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;      //Por defecto es false

        private String tapiceria;       //Por defecto es ""


    }

}