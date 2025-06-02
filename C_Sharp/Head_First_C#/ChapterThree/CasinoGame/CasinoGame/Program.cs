namespace CasinoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double odd = 0.75;
            Random random = new Random();

            Guy player = new Guy() { cash = 100, name = "The Player" };
            Console.WriteLine("Welcome To Casino! The Odds are " + odd);

            while (player.cash > 0)
            {
                player.WriteMyInfo();


                Console.Write("How much do you want to bet : ");
                string howMuch = Console.ReadLine();


                if (howMuch == "") return;

                if (int.TryParse(howMuch, out int amount))
                {
                    player.GiveCash(amount);
                    double rand = random.NextDouble();

                    if (rand > odd)
                    {
                        int pot = amount * 2;
                        player.ReceiveCash(pot);
                        Console.WriteLine("Good luck, you win.");
                    }
                    else if (rand <= odd)
                    {
                        Console.WriteLine("Bad luck, you lose.");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter amount or blank line to exit");
                }
            }
            Console.WriteLine("The house always wins");
        }
    }
}
