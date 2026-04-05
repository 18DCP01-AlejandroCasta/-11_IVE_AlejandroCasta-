internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==ACTIVIDAD 1.2 LECCION 7===\n");

        Console.WriteLine("Inserte su edad");
        int e = Convert.ToInt32(Console.ReadLine());

        if (e >= 18)
        {
            Console.WriteLine("Usted es una persona legal\n");
        }
        else
        {
            Console.WriteLine("Usted es menor");
        }
    }
}