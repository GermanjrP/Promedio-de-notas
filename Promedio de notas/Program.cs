using System;
namespace promedio_de_calificaciones;
class Program
{
    static void Main()
    {
        string nombre, matricula;
        double suma = 0, promedio, nota;

        Console.WriteLine("Ingrese el nombre del estudiante:");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la matrícula del estudiante:");
        matricula = Console.ReadLine();

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Ingrese la nota del estudiante " + i + ":");
            nota = Convert.ToDouble(Console.ReadLine());
            suma += nota;
        }

        promedio = suma / 5;

        Console.WriteLine("------------ Boletín ------------");
        Console.WriteLine("El promedio del estudiante " + nombre + " es de: " + promedio);
    }
}


