internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int dia = int.Parse(Console.ReadLine());

        if (dia == 6 || dia == 7)
            Console.WriteLine("Fin de semana");
        else
            Console.WriteLine("Entre semana");
    }
}