internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ACTIVIDAD 4 LECCION 20");

        Console.Write("Ingrese la contraseña: ");
        string password = Console.ReadLine();

        if (password == "Password123")
            Console.WriteLine("Bienvenido");
        else
            Console.WriteLine("Acceso prohibido");

    }
}