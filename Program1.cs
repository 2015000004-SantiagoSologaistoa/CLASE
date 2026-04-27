internal class Program
{
    private static void Main(string[] args)
    {
        double pesoAcumulado = 0;
        double pesoManzana = 0;
        const double META = 1000;
        while (pesoAcumulado < META)
        {
            Console.Write("Falta {0}g para el kilo", META - pesoAcumulado);
            Console.Write("Ingrese el peso de la manzana (100-300): ");

            string entrada = Console.ReadLine();
            if (double.TryParse(entrada, out pesoManzana))
            {
                if (pesoManzana >= 100 && pesoManzana <= 300)
                {
                    pesoAcumulado += pesoManzana;
                    Console.WriteLine("Agregada. Total.{0}g", pesoAcumulado);
                }
                else
                {
                    Console.WriteLine("La manzana no cumple con el peso");
                }


            }

            Console.WriteLine("Ya tiene el kilo de manzana, total:{0}g", pesoAcumulado);
            Console.WriteLine("Presiones una tecla para salir");
            Console.ReadKey();
        }
    }
}