internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===ACTIVIDAD 3.1 LECCION 7===\n");

        Console.WriteLine("Ingrese el lado 1 del triangulo\n");
        int l1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el lado 2 del triangulo\n");
        int l2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el lado 3 del triangulo\n");
        int l3 = Convert.ToInt32(Console.ReadLine());

        if (l1 == l2 && l2 == l3)
            Console.WriteLine("Triángulo equilátero");
        if (l1 == l2 || l1 == l3 || l2 == l3)
            Console.WriteLine("Triángulo isósceles");
        else
            Console.WriteLine("Triángulo escaleno");

    }
}