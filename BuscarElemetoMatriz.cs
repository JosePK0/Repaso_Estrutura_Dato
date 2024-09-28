namespace arreglosDato;

public class BuscarElementoMatriz
{
    public void Ejecutar()
    {
        try
        {
            int[,] matriz = {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };

            Console.WriteLine("Ingrese el número que desea buscar en la matriz:");
            int elemento = int.Parse(Console.ReadLine());

            bool encontrado = Buscar(matriz, elemento);
            Console.WriteLine(encontrado ? "Elemento encontrado" : "Elemento no encontrado");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar un número entero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }

    public bool Buscar(int[,] matriz, int elemento)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == elemento)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
