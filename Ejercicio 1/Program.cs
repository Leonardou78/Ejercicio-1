// See https://aka.ms/new-console-template for more information
// Crea un programa en C# que permita ingresar la información de . 
// Para cada uno: 
// -Solicita el.Si el nombre está vacío, vuelver a pedirlo.
// - Solicita cuántas calificaciones tiene ese estudiante. Debe ser entre 1 y 5.
// - Validar que la calificación esté entre 1 y 10. 
//- Calcula el promedio (solo con calificaciones válidas).


// Pedir nombre

string nombre = "";

while (nombre == "")
{
    Console.WriteLine("Ingrese un nombre: ");

    nombre = Console.ReadLine();

}
Console.WriteLine($"Se ingresaran las notas del alumno {nombre}");







// Preguntar cuantas calificaciones tiene ese alumno (entre 1 y 5)

Console.WriteLine("¿Cuantas calificaciones tiene este alumno? ");

int calificaciones = int.Parse(Console.ReadLine());
while (calificaciones <1 || calificaciones > 5)
{
    Console.WriteLine("Valor no valido, ingrese un valor entre 1 y 5.");

    calificaciones = int.Parse(Console.ReadLine());
}






// Se usa un FOR para ingresar las calificaciones.
float suma = 0; 
for (int i=1; i <= calificaciones; i++)
{
    Console.WriteLine($"Ingrese la nota {i}°: ");
    float nota = float.Parse(Console.ReadLine());
    while (nota < 1 || nota > 10)
    {
        Console.WriteLine("valor no valido, ingrese un valor entre 1 y 10.");
        nota = float.Parse(Console.ReadLine());

    }
    Console.WriteLine($"La nota {i}° es: {nota}: ");

    suma = suma + nota;
}



// Calculamos el promedio.
float promedio = suma / calificaciones;
Console.WriteLine($"El promedio es: {promedio}");





// Clasificamos el resultado.

if (promedio < 6)
{
    Console.WriteLine($"La nota del alumno {nombre} es Reprobado al tener un promedio menor a 6.");
}

else if (promedio >= 6 && promedio < 7)
{
    Console.WriteLine($"La nota del alumno {nombre} es Regular al tener un promedio de 6.");
}

else if (promedio >=7 && promedio < 9)
{
    Console.WriteLine($"La nota del alumno {nombre} es Bueno al tener un promedio entre 7 y 9.");
}
else if (promedio >=9)
{
    Console.WriteLine($"La nota del alumno {nombre} es Excelente al tener un promedio mayor o igual a 9.");
}


