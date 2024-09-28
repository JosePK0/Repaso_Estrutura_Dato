namespace arreglosDato;

class Program
{
     static void Main(string[] args)
    {
        
        int opcion = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1. Invertir arreglo");
            Console.WriteLine("2. Buscar elemento en matriz");
            Console.WriteLine("3. Pesos de personas");
            Console.WriteLine("4. Promedio de cursos");
            Console.WriteLine("5. Sueldos de empleados");
            Console.WriteLine("6. Salir");
            
            try
            {
                opcion = int.Parse(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                        InvertirArreglo invertArreglo = new InvertirArreglo();
                        invertArreglo.Ejecutar();
                        break;
                    case 2:
                        BuscarElementoMatriz buscar = new BuscarElementoMatriz();
                        buscar.Ejecutar();
                        break;
                    case 3:
                        PesosPersonas pesos = new PesosPersonas();
                        pesos.Ejecutar();
                        break;
                    case 4:
                        PromedioCursos promedioCursos = new PromedioCursos();
                        promedioCursos.Ejecutar();
                        break;
                    case 5:
                        SueldoEmpleados sueldos = new SueldoEmpleados();
                        sueldos.Ejecutar();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida. Debes ingresar un número.");
            }
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        } while (opcion != 6);
    }
}
