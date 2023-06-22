namespace _100FirstLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();

            string entrada = Console.ReadLine();

            try
            {
                int entradaId = Convert.ToInt32(entrada);

                ce.getEmpleadosEmpresa(entradaId);

            }catch (Exception)
            {
                Console.WriteLine("Valor introducido incompatible");
            }


        }
    }

    class ControlEmpresasEmpleados
    {
        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();

            listaEmpleados = new List<Empleado>();
            
            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google" });

            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Pildoras I" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Sergey Brin", Cargo = "CEO", EmprersaId = 1, Salario = 150000 });

            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Juan Díaz", Cargo = "CEO", EmprersaId = 2, Salario = 1500000 });

            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Larry Page", Cargo = "Co-CEO", EmprersaId = 1, Salario = 150001 });

            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Irina Shayk", Cargo = "Co-CEO", EmprersaId = 2, Salario = 1500001 });

        }

        public void getCEO()
        {
            IEnumerable<Empleado> ceos = from empleado in listaEmpleados where empleado.Cargo == "CEO" select empleado;

            foreach (Empleado empleado1 in ceos)
            {
                empleado1.getDatosEmpleado();
            }
        }

        public void getEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Nombre select empleado;

            foreach (Empleado empleado1 in empleados)
            {
                empleado1.getDatosEmpleado();
            }
        }

        public void getEmpleadosEmpresa(int Id)
        {
            IEnumerable<Empleado> empleadosPil = from empleado in listaEmpleados join empresa in listaEmpresas
                                              on empleado.EmprersaId equals empresa.Id
                                              where empresa.Id == Id select empleado;

            foreach (Empleado empleado1 in empleadosPil)
            {
                empleado1.getDatosEmpleado();
            }
        }

        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;


    }

    class Empresa
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public void getDatosEmpresa()
        {
            Console.WriteLine("Empresa {0} con Id {1}", Nombre, Id);
        }
    }

    class Empleado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Cargo { get; set; }

        public double Salario { get; set; }

        //Clave foráneo

        public int EmprersaId { get; set; }

        public void getDatosEmpleado()
        {
            Console.WriteLine("Empleado {0} con Id {1}, cargo {2} con salario {3} y" +
                " pertenece a la empresa {4}", Nombre, Id, Cargo, Salario, EmprersaId);
        }
    }
}

