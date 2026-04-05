internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===ACTIVIDAD 2 LECCION 7===\n");

        Console.WriteLine("1- Ventas");
        Console.WriteLine("2- Recepcion");
        Console.WriteLine("3- Direccion");
        Console.WriteLine("4- Compras");

        Console.WriteLine("Digite un numero: \n");

        int opc = Convert.ToInt32(Console.ReadLine());

        if (opc == 1)
        {
            Console.WriteLine("Bienvenido al dep. de Ventas.");
            Console.WriteLine("Victor");
            Console.WriteLine("victor1@gmail.com");
        }
        if (opc == 2)
        {
            Console.WriteLine("Bienvenido al dep. de Recepcion.");
            Console.WriteLine("Victor");
            Console.WriteLine("victor2@gmail.com");
        }
        if (opc == 3)
        {
            Console.WriteLine("Bienvenido al dep. de Direccion.");
            Console.WriteLine("Victor");
            Console.WriteLine("victor3@gmail.com");
        }
        if (opc == 4)
        {
            Console.WriteLine("Bienvenido al dep. de Compras.");
            Console.WriteLine("Victor");
            Console.WriteLine("victor4@gmail.com");
        }
    }
}