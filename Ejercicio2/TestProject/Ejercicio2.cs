
// Colegio "Dios es bueno" - Ejercicio #2

// Listas para guardar los datos de todos los estudiantes
List<string> nombres = new List<string>();
List<string> apellidos = new List<string>();
List<int[]> notas = new List<int[]>();
List<decimal> promedios = new List<decimal>();
List<string> literales = new List<string>();

string continuar = "s";

while (continuar == "s")
{
    Console.WriteLine("\n--- Nuevo estudiante ---");

    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();

    Console.Write("Apellido: ");
    string apellido = Console.ReadLine();

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

    // Literal segun el promedio
    string literal;
    if (promedio >= 90)
        literal = "A";
    else if (promedio >= 80)
        literal = "B";
    else if (promedio >= 70)
        literal = "C";
    else
        literal = "F";

    // Guardar todo en las listas
    nombres.Add(nombre);
    apellidos.Add(apellido);
    notas.Add(notasEstudiante);
    promedios.Add(promedio);
    literales.Add(literal);

    Console.Write("\nDesea ingresar otro estudiante? (s/n): ");
    continuar = Console.ReadLine().Trim().ToLower();
}

// Mostrar el reporte
Console.WriteLine("\n\nColegio Dios es bueno.");
Console.WriteLine("Calificaciones del cuatrimestre");
Console.WriteLine("==========================================================================");
Console.WriteLine("{0,-12}{1,-12}{2,-7}{3,-7}{4,-7}{5,-7}{6,-10}{7}",
    "Nombre", "Apellido", "Nota1", "Nota2", "Nota3", "Nota4", "Promedio", "Literal");
Console.WriteLine("==========================================================================");

for (int i = 0; i < nombres.Count; i++)
{
    Console.WriteLine("{0,-12}{1,-12}{2,-7}{3,-7}{4,-7}{5,-7}{6,-10}{7}",
        nombres[i], apellidos[i],
        notas[i][0], notas[i][1], notas[i][2], notas[i][3],
        promedios[i].ToString("0.##"), literales[i]);
}