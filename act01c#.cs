internal class Program
{
    private static void Main(string[] args)
    {
        /*Inciso 1 - Un algoritmo que determine si un alumno aprueba o pierde una materia basado en un promedio de 5.*/
        Console.WriteLine("===PROMEDIO DE NOTAS");
        int n1, n2, n3, n4, n5;
        string nombre;

        Console.WriteLine("Digite la materia: ");
        nombre = Console.ReadLine();
        
        Console.Write("Digite 5 notas: ");

        n1=Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        n3 = Convert.ToInt32(Console.ReadLine());
        n4 = Convert.ToInt32(Console.ReadLine());
        n5 = Convert.ToInt32(Console.ReadLine());
        double promedio = (n1 + n2 + n3 + n4 + n5) / 5;

        if (promedio >= 70)
            Console.WriteLine("Aprobado");
        else
        {
            Console.WriteLine("Desaprobado");
        }

        Console.WriteLine("La materia: "+nombre);
        Console.WriteLine("El promedio: " + promedio);
    }
}