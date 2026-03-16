internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Numeros Positivos y Negativos");

        double num;
        Console.Write("Ingrese un numero entero");
        num = Convert.ToDouble(Console.ReadLine());

        if (num>0)
        {
            Console.WriteLine("Soy numero positivo w");
        }
        else
        {
            Console.WriteLine("Soy numero negativo w");
        }
    }
}