using System;
using System.Collections.Generic;

// Colegio "Dios es bueno" - Ejercicio #3
// (Ejercicio #2 + reporte ordenado por apellido + totales por literal)

// Listas para guardar los datos de todos los estudiantes
List<string> nombres = new List<string>();
List<string> apellidos = new List<string>();
List<int[]> notas = new List<int[]>();
List<decimal> promedios = new List<decimal>();
List<string> literales = new List<string>();

// Contadores para los totales
int totalA = 0;
int totalB = 0;
int totalC = 0;
int totalReprobados = 0;

string continuar = "s";

while (continuar == "s")
{
    Console.WriteLine("\n--- Nuevo estudiante ---");

    Console.Write("Nombre: ");
    string nombre = Console.ReadLine().Trim();

    Console.Write("Apellido: ");
    string apellido = Console.ReadLine().Trim();

    int[] notasEstudiante = new int[4];
    int suma = 0;

    // Pedir las 4 notas (se repite hasta que sea un numero valido entre 0 y 100)
    for (int i = 0; i < 4; i++)
    {
        int nota;
        do
        {
            Console.Write("Nota" + (i + 1) + " (0-100): ");
        }
        while (!int.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100);

        notasEstudiante[i] = nota;
        suma += nota;
    }

    decimal promedio = (decimal)suma / 4;

    // Literal segun el promedio, y de una vez se cuenta en su total
    string literal;
    if (promedio >= 90)
    {
        literal = "A";
        totalA++;
    }
    else if (promedio >= 80)
    {
        literal = "B";
        totalB++;
    }
    else if (promedio >= 70)
    {
        literal = "C";
        totalC++;
    }
    else
    {
        literal = "F";
        totalReprobados++;
    }

    // Guardar todo en las listas
    nombres.Add(nombre);
    apellidos.Add(apellido);
    notas.Add(notasEstudiante);
    promedios.Add(promedio);
    literales.Add(literal);

    Console.Write("\nDesea ingresar otro estudiante? (s/n): ");
    continuar = Console.ReadLine().Trim().ToLower();
}

// Ordenar por apellido:
// en vez de mover los datos de las 5 listas, ordenamos una lista de posiciones (indices)
List<int> orden = new List<int>();
for (int i = 0; i < apellidos.Count; i++)
{
    orden.Add(i);
}
orden.Sort((a, b) => string.Compare(apellidos[a], apellidos[b], StringComparison.OrdinalIgnoreCase));

// Mostrar el reporte
Console.WriteLine("\n\nColegio Dios es bueno.");
Console.WriteLine("Calificaciones del cuatrimestre");
Console.WriteLine("==========================================================================");
Console.WriteLine("{0,-12}{1,-12}{2,-7}{3,-7}{4,-7}{5,-7}{6,-10}{7}",
    "Nombre", "Apellido", "Nota1", "Nota2", "Nota3", "Nota4", "Promedio", "Literal");
Console.WriteLine("==========================================================================");

// Se recorre siguiendo el orden de los apellidos
foreach (int i in orden)
{
    Console.WriteLine("{0,-12}{1,-12}{2,-7}{3,-7}{4,-7}{5,-7}{6,-10}{7}",
        nombres[i], apellidos[i],
        notas[i][0], notas[i][1], notas[i][2], notas[i][3],
        promedios[i].ToString("0.##"), literales[i]);
}

// Totales al final del reporte
Console.WriteLine("==========================================================================");
Console.WriteLine("Estudiantes en A:          " + totalA);
Console.WriteLine("Estudiantes en B:          " + totalB);
Console.WriteLine("Estudiantes en C:          " + totalC);
Console.WriteLine("Estudiantes en Reprobados: " + totalReprobados);