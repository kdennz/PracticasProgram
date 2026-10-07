using System;

// Ejercicio #1 - Operaciones con dos valores

double valor1;
double valor2;

// Pedir el primer valor se repite hasta que sea un numero valido
do
{
    Console.Write("Ingrese el primer valor: ");
}
while (!double.TryParse(Console.ReadLine(), out valor1));

// Pedir el segundo valor
do
{
    Console.Write("Ingrese el segundo valor: ");
}
while (!double.TryParse(Console.ReadLine(), out valor2));

Console.WriteLine("\n===== RESULTADOS =====");

// Suma, resta y multiplicacion
Console.WriteLine("Suma:           " + valor1 + " + " + valor2 + " = " + (valor1 + valor2));
Console.WriteLine("Resta:          " + valor1 + " - " + valor2 + " = " + (valor1 - valor2));
Console.WriteLine("Multiplicacion: " + valor1 + " * " + valor2 + " = " + (valor1 * valor2));

// Division (no se puede dividir entre cero)
if (valor2 == 0)
{
    Console.WriteLine("Division:       No se puede dividir entre cero");
}
else
{
    Console.WriteLine("Division:       " + valor1 + " / " + valor2 + " = " + (valor1 / valor2));
}

// Raiz cuadrada de cada valor no se pueden numeros negativos
if (valor1 < 0)
{
    Console.WriteLine("Raiz de " + valor1 + ":    No existe raiz cuadrada real de un numero negativo");
}
else
{
    Console.WriteLine("Raiz de " + valor1 + ":    " + Math.Sqrt(valor1));
}

if (valor2 < 0)
{
    Console.WriteLine("Raiz de " + valor2 + ":    No existe raiz cuadrada real de un numero negativo");
}
else
{
    Console.WriteLine("Raiz de " + valor2 + ":    " + Math.Sqrt(valor2));
}