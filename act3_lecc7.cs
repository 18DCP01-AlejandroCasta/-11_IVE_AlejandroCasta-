internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===ACTIVIDAD 3 LECCION 7");
        
        Console.Write("Ingrese el día: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el mes (1-12): ");
        int mes = Convert.ToInt32(Console.ReadLine());

        if ((mes == 3 && dia >= 21) || (mes == 4) || (mes == 5) || (mes == 6 && dia <= 20))
            Console.WriteLine("Primavera");
        if ((mes == 6 && dia >= 21) || (mes == 7) || (mes == 8) || (mes == 9 && dia <= 22))
            Console.WriteLine("Verano");
        if ((mes == 9 && dia >= 23) || (mes == 10) || (mes == 11) || (mes == 12 && dia <= 20))
            Console.WriteLine("Otoño");
        else
            Console.WriteLine("Invierno");
    }
}