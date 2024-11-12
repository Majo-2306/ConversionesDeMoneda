namespace ConversionesDeMoneda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MostrarMenu();

                switch (Console.ReadLine().ToString())
                {
                    case "1":
                        Console.WriteLine("Pesos a Dolares");
                        break;
                    case "2":
                        Console.WriteLine("Dolares a Pesos");
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        break;
                }
                Console.ReadLine();
            }
            //decimal conversion = PesosADolares(20.43m, 50000m);
            //Console.WriteLine(conversion.ToString("N2"));
        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Conversiones");
            Console.WriteLine("1) Pesos a Dolares");
            Console.WriteLine("2) Dolares a Pesos");
            Console.WriteLine("");
        }

        static decimal PesosADolares(decimal tipoCambio, decimal pesos)
        {
            decimal dolares = 0.00m;
            dolares = pesos / tipoCambio;
            return dolares;
        }
    }
}
