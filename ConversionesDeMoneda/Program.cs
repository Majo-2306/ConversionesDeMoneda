namespace ConversionesDeMoneda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MostrarMenu();

                string respuestaUsuario = Console.ReadLine();

                switch (respuestaUsuario)
                {
                    case "1":
                        ConvertirPesosADolares();
                        break;
                    case "2":
                        ConvertirDolaresAPesos();
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        break;
                }
                Console.ReadLine();
            }

        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Conversiones");
            Console.WriteLine("1) Pesos a Dolares");
            Console.WriteLine("2) Dolares a Pesos");
            Console.WriteLine("");
        }
        static void ConvertirPesosADolares()
        {
            Console.WriteLine("Pesos a dolares");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);


            Console.WriteLine("Introducir la cantidad en pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal pesos);

            decimal dolares = PesosADolares(tipoDeCambio, pesos);
            Console.WriteLine($"Cantidad en dolares: {dolares}");
        }
        static void ConvertirDolaresAPesos()
        {
            Console.WriteLine("Dolares a Pesos");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);

            Console.WriteLine("introducir la cantidad en dolares");
            respuestaUsuario = Console.ReadLine();

            decimal.TryParse(respuestaUsuario, out decimal dolares);

            decimal pesos = DolaresAPesos(tipoDeCambio, dolares);
            Console.WriteLine($"La cantidad en pesos es {pesos.ToString("N2")}");

        }
        static decimal PesosADolares(decimal tipoCambio, decimal pesos)
        {
            decimal dolares = 0.00m;

            dolares = pesos / tipoCambio;
            return dolares;
        }

        static decimal DolaresAPesos(decimal tipoCambio, decimal dolares)
        {
            decimal pesos = 0.0m;
            pesos = tipoCambio * dolares;
            return pesos;
        }
    }
}
