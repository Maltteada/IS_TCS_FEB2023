// See https://aka.ms/new-console-template for more information

//Imprimir numero pares

using LinqColeccion;

int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("Numeros;");

/*Sin LINQ
List<int> numerosPares = new List<int>();
foreach (int numero in numeros)
{
    if(numero % 2 == 0)
    {
        numerosPares.Add(numero);
    }
}
*/

//Con LINQ
/*IEnumerable<int> numerosPares = from numero in numeros where numero % 2 == 0 select numero;
Console.WriteLine("linq");

foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
} */

// Ejemplo control alumnos objetos

ControlAlumnos controlAlumnos = new ControlAlumnos();
controlAlumnos.obtenerAlumnosConCarrera(2);
