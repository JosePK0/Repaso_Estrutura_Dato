namespace arreglosDato;
public class PesosPersonas
{
    public void Ejecutar()
    {
        try
        {
            Console.WriteLine("Ingrese 10 pesos separados por comas:");
            string[] entrada = Console.ReadLine().Split(',');
            double[] pesos = Array.ConvertAll(entrada, double.Parse);

            if (pesos.Length != 10)
            {
                throw new ArgumentException("Debe ingresar exactamente 10 valores.");
            }

            CalcularPromedioYContar(pesos);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar números decimales separados por comas.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }

    public void CalcularPromedioYContar(double[] pesos)
    {
        double promedio = pesos.Average();
        int masAltos = pesos.Count(p => p > promedio);
        int masBajos = pesos.Count(p => p < promedio);

        Console.WriteLine($"El promedio de los pesos es: {promedio}");
        Console.WriteLine($"Personas con peso mayor que el promedio: {masAltos}");
        Console.WriteLine($"Personas con peso menor que el promedio: {masBajos}");
    }
}
