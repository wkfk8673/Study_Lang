namespace SharpenYourPencil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33};
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40};

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine($"You Pressed {input}");
                if (input == '1')
                {
                    lloyd.whoAmI();
                }
                else if (input == '2')
                {
                    lucinda.whoAmI();
                }
                else if (input == '3') // swap
                {
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;

                    Console.WriteLine("References have been swapped");
                }
                else if (input == '5')
                {
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
                }
                else return;
                Console.WriteLine();
            }
        }
    }

    class Elephant
    {
        public int EarSize;
        public string Name;

        public void whoAmI()
        {
            Console.WriteLine($"Calling {Name}.WhoAmI()");
            Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"My ears are {EarSize} inches tall.");
        }

        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine($"{Name} heard a message");
            Console.WriteLine($"{whoSaidIt.Name} said this : {message}");
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}
