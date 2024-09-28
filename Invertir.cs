namespace arreglosDato;

public class InvertirArreglo
{
    public void Ejecutar()
    {
        try
        {
            Console.WriteLine("Ingrese los números del arreglo separados por comas:");
            string[] entrada = Console.ReadLine().Split(',');
            int[] arreglo = Array.ConvertAll(entrada, int.Parse);

            Invertir(arreglo);

            Console.WriteLine("Arreglo invertido: " + string.Join(", ", arreglo));
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar números enteros separados por comas.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }

    public void Invertir(int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length / 2; i++)
        {
            int temp = arreglo[i];
            arreglo[i] = arreglo[arreglo.Length - 1 - i];
            arreglo[arreglo.Length - 1 - i] = temp;
        }
    }
}
