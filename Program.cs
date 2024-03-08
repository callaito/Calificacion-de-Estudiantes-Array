// See https://aka.ms/new-console-template for more information
using System.Dynamic;

Console.WriteLine("Hello, World!");
Console.WriteLine("Introduzca la cantidad de estudiante a calificar");
int cantidad = int.Parse(Console.ReadLine());

String[] estudiante = new string[cantidad];
Double[] calificacion = new double[cantidad];

for (int i = 0; i < estudiante.Length; i++)
{
    Console.WriteLine("Introduzca el nombre del estudiante: {0}"+(i+1));

    estudiante[i] = Console.ReadLine();
  
    Console.WriteLine("Introduzca la calificacion: {0}"+(i+1));
    calificacion[i] = Convert.ToDouble(Console.ReadLine());

    
}
Console.WriteLine();
for(int i =0; i < estudiante.Length
    ; i++)
{
    Console.WriteLine("Estudiante: {0} tiene {1} puntos", estudiante[i], calificacion[i]);
}