namespace arreglosDato;
using System;
using System.Collections.Generic;

public class PromedioCursos
{
    private string[] cursos = { "Estructura de Datos", "Desarrollo de Aplicaciones", "Ingeniería de Software", "Administración de Base de Datos", "Inglés IV" };
    private double[,] notas;       private double[] promedios; 

    public PromedioCursos()
    {
        notas = new double[cursos.Length, 5]; 
        promedios = new double[cursos.Length]; 
    }

    public void Ejecutar()
    {
        try
        {
            IngresarDatos();
            CalcularPromedios();
            MostrarCursoConMayorPromedio();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar números válidos para las notas.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }

    
    public void IngresarDatos()
    {
        for (int i = 0; i < cursos.Length; i++)
        {
            Console.WriteLine($"\n--- Curso: {cursos[i]} ---");

            for (int j = 0; j < 5; j++)
            {
                bool notaValida = false;
                while (!notaValida)
                {
                    Console.WriteLine($"Ingrese la calificación final del alumno {j + 1} (entre 0 y 100):");
                    try
                    {
                        double nota = double.Parse(Console.ReadLine());
                        if (nota >= 0 && nota <= 100)
                        {
                            notas[i, j] = nota;
                            notaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("La calificación debe estar entre 0 y 100. Intente de nuevo.");
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


    public void CalcularPromedios()
    {
        for (int i = 0; i < cursos.Length; i++)
        {
            double sumaNotas = 0;

            for (int j = 0; j < 5; j++)
            {
                sumaNotas += notas[i, j];
            }

            promedios[i] = sumaNotas / 5; 
            Console.WriteLine($"El promedio del curso {cursos[i]} es: {promedios[i]}");
        }
    }

    
    public void MostrarCursoConMayorPromedio()
    {
        double maxPromedio = 0;

    
        for (int i = 0; i < promedios.Length; i++)
        {
            if (promedios[i] > maxPromedio)
            {
                maxPromedio = promedios[i];
            }
        }

        
        Console.WriteLine($"\nEl mayor promedio general es: {maxPromedio}");
        Console.WriteLine("Los cursos que obtuvieron este promedio son:");

        for (int i = 0; i < promedios.Length; i++)
        {
            if (promedios[i] == maxPromedio)
            {
                Console.WriteLine($"- {cursos[i]}");
            }
        }
    }
}


