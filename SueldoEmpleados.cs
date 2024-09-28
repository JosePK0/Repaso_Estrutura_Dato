namespace arreglosDato;

public class SueldoEmpleados
{
    private string[] empleados = new string[5]; 
    private double[,] sueldos = new double[5, 5]; 

    public void Ejecutar()
    {
        try
        {
            IngresarDatos();
            MostrarTotalSueldosPagados();
            EmpleadoConMayorIngresoAcumulado();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar números válidos para los sueldos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }

  
    public void IngresarDatos()
    {
        for (int i = 0; i < empleados.Length; i++)
        {
            Console.WriteLine($"\n--- Ingreso de datos para el empleado {i + 1} ---");
            Console.WriteLine("Ingrese el nombre del empleado:");

            empleados[i] = Console.ReadLine();

            for (int j = 0; j < 5; j++)
            {
                bool sueldoValido = false;
                while (!sueldoValido)
                {
                    Console.WriteLine($"Ingrese el sueldo de la quincena {j + 1} para {empleados[i]}:");
                    try
                    {
                        double sueldo = double.Parse(Console.ReadLine());
                        if (sueldo >= 0)
                        {
                            sueldos[i, j] = sueldo;
                            sueldoValido = true;
                        }
                        else
                        {
                            Console.WriteLine("El sueldo debe ser un valor positivo. Intente nuevamente.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error: Ingrese un valor numérico válido.");
                    }
                }
            }
        }
    }

  
    public void MostrarTotalSueldosPagados()
    {
        double totalPagado = 0;

        for (int i = 0; i < empleados.Length; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                totalPagado += sueldos[i, j];
            }
        }

        Console.WriteLine($"\nEl total pagado en sueldos a todos los empleados en los últimos 5 meses es: {totalPagado}");
    }

    // Identifica al empleado con mayor ingreso acumulado
    public void EmpleadoConMayorIngresoAcumulado()
    {
        double maxIngreso = 0;
        string empleadoConMayorIngreso = "";

        for (int i = 0; i < empleados.Length; i++)
        {
            double ingresoAcumulado = 0;
            for (int j = 0; j < 5; j++)
            {
                ingresoAcumulado += sueldos[i, j];
            }

            if (ingresoAcumulado > maxIngreso)
            {
                maxIngreso = ingresoAcumulado;
                empleadoConMayorIngreso = empleados[i];
            }
        }

        Console.WriteLine($"\nEl empleado con mayor ingreso acumulado es {empleadoConMayorIngreso} con un total de {maxIngreso}");
    }
}

