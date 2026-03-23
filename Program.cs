internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===MENU PRINCIPAL===");
        //Variables
        int opc;
        //Crear Menu
        Console.Write("MENU PRINCIPAL\n");
        Console.Write("1- Recepcion\n");
        Console.Write("2- Vigilancia\n");
        Console.Write("3- Mantenimiento\n");
        Console.Write("4- Salida\n");
        Console.Write("Digite una opcion [ ]: ");
        opc=Convert.ToInt32(Console.ReadLine());
        //Condiciones
        if (opc == 1)
        {
            //limpiar pantalla
            Console.Clear();
            Console.WriteLine("Bienvenido al depto. de Recepcion");
        }
        if (opc == 2)
        {
            //limpiar pantalla
            Console.Clear();
            Console.WriteLine("Bienvenido al depto. de Vigilancia");
        }
        if (opc == 3)
        {
            //limpiar pantalla
            Console.Clear();
            Console.WriteLine("Bienvenido al depto. de Mantenimiento");
        }
        if (opc!= 1 && opc!=2 && opc!=3)
        {
            //limpiar pantalla
            Console.Clear();
            Console.WriteLine("Saliendo del sistema...");
        }

    }
}