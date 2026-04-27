internal class Program
{
    private static void Main(string[] args)
    {
        const int TOTAL_SELLOS = 8;
        Console.WriteLine("BIENVENIDO A LA BARBERIA PRESI");

        for (int i = 1; i <=TOTAL_SELLOS; i++)
        {
            Console.WriteLine("Sellos actuales: {o} e {1}", i, TOTAL_SELLOS);
            Console.WriteLine("Presione cualquier tecla pata trgistrar esta visita");
            Console.ReadKey();

            Console.WriteLine(">> sellos #{0}: registrados correctamente-<<", i);
        }
        Console.WriteLine("CUPONERA COMPLETADA");
        Console.WriteLine("Presi, te has ganado un corte gratis");
    }
}