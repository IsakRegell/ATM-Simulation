namespace ATM_Simulation
{
    //Skapa en bankkontoklass med egenskaper som kontonummer, pinkod och saldo.
    //Implementera metoderna Deposit(), Draw() och CheckBalance().
    //Skapa ett konsolgränssnitt där användaren loggar in med sitt  PIN-kod, 
    //och sedan utför olika åtgärder(sätta in, ta ut, kontrollera saldo) genom att välja från en meny.
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankkonto isakbankkonto = new Bankkonto(1234567, 1234);

            Console.Write("Please enter your pincode: ");
            int pinkod = Convert.ToInt32(Console.ReadLine());

            if (pinkod == isakbankkonto.Pinkod)
            {
                Console.WriteLine("Välkomen Isak");
                Console.WriteLine("Tryck (1) för att kolla saldo");
                Console.WriteLine("Tryck (2) för att ta ut pengar");
                Console.WriteLine("Tryck (3) för att sätta in pengar");
                String val = Console.ReadLine();

                if (val == "1")
                {
                    Console.WriteLine($"Ditt saldo är {isakbankkonto.CheckBalance()}");
                }

                if (val == "2")
                {
                    Console.WriteLine("Hur mycket pengar vill du ta ut?");
                    String val2 = Console.ReadLine();
                    Console.WriteLine($"{val2} kr togs ut från ditr konto");
                }

                if (val == "3")
                {
                    Console.WriteLine("Hur mycekt pengar vill du sätta in?");
                    String val3 = Console.ReadLine();
                    Console.WriteLine($"{val3} kr sattes in på ditt konto");
                }

            }
            else
            {
                Console.WriteLine("Fel pinkod");
            }

        }
    }
}
