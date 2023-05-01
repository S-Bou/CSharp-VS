
namespace Enumeraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Estaciones alergia = Estaciones.Primavera;
            String La_alergia = alergia.ToString();
            Console.WriteLine(La_alergia);*/

            /*Bonus Antonio = Bonus.bueno;
            double bonusAntonio = (double)Antonio;
            double salarioAntonio = 1500 + bonusAntonio;
            Console.WriteLine(salarioAntonio);*/

            Empleado Juan = new Empleado(Bonus.extra, 1900.50);

            Console.WriteLine("El salario del empleado es: " + Juan.getSalario());

        }
    }

    class Empleado
    {
        public Empleado(Bonus bonusEmpleado, double salario)
        {
            this.bonusEmpleado = bonusEmpleado;
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario + (double)bonusEmpleado;
        }

        private double salario;
        private Bonus bonusEmpleado;
    }

    enum Bonus { bajo=500, normal=1000, bueno=1500, extra=3000 };
    enum Estaciones { Primavera, Verano, Otoño, Invierno};
}
