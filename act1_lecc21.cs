internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Inserte un dia de la semana en numero");
        int d = Convert.ToInt32(Console.ReadLine());

        if (d == 1)
        {
            Console.WriteLine("Lunes");
        }
        if (d == 2)
        {
            Console.WriteLine("Martes");
        }
        if (d == 3)
        {
            Console.WriteLine("Miercoles");
        }
        if (d == 4)
        {
            Console.WriteLine("Jueves");
        }
        if (d == 5)
        {
            Console.WriteLine("Viernes");
        }
        if (d == 6)
        {
            Console.WriteLine("Sabado");
        }
        if (d == 7)
        {
            Console.WriteLine("Domingo");
        }
    }
}