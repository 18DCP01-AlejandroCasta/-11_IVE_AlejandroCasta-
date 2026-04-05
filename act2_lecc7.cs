internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===ACTIVIDAD 2 LECCION 7===\n");
        
        Console.WriteLine("1- Recepcion");
        Console.WriteLine("2- Vigilancia");
        Console.WriteLine("3- Mantenimiento");
        Console.WriteLine("4- Salir\n");
        
        Console.WriteLine("Digite un numero: \n");
        
        int opc = Convert.ToInt32(Console.ReadLine());
        
        if (opc == 1)
        {
            Console.WriteLine("Bienvenido al dep. de Recepción."); 
        }
        if (opc == 2)
        {
            Console.WriteLine("Bienvenido al dep. de Vigilancia.");
        }
        if (opc == 3)
        {
            Console.WriteLine("Bienvenido al dep. de Mantenimiento.");
        }
        if (opc !> 1 && opc !>2 && opc !>3)
        {
            Console.WriteLine("Gracias por su visita.");
        }

    }
}