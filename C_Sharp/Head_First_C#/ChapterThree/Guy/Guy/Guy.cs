namespace Guy
{
    internal class Guy
    {
        public int cash;
        public string name;
        static void Main(string[] args)
        {
            Guy joe = new Guy() { cash = 50, name = "joe" };
            Guy bob = new Guy() { cash = 100, name = "bob" };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();
                Console.Write("Enter an amount : ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int result))
                {
                    Console.Write("Who should give the cash : ");
                    string whichGuy = Console.ReadLine();
                    if(whichGuy == "joe")
                    {
                        int cashGiven = joe.GiveCash(result);
                        bob.ReceiveCash(cashGiven);
                    }
                    else if (whichGuy == "bob")
                    {
                        int cashGiven = bob.GiveCash(result);
                        joe.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Enter joe or bob");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter amount or blank line to exit");
                }
            }



        }

        /// <summary>
        /// 이 사람이 가진 돈과 이름을 콘솔에 출력
        /// </summary>
        /// <param name="args"></param>
        public void WriteMyInfo()
        {
            Console.WriteLine(name + " has " + cash + " bucks.");
        }

        /// <summary>
        /// 돈을 주기 위해 이 사람의 지갑에서 돈을 꺼냅니다.
        /// 돈이 부족하면 메세지를 출력합니다.
        /// </summary>
        /// <param name="amount">줄 돈의 금액</param>
        /// <returns>
        /// 줄어든 돈의 금액
        /// 돈이 부족하거나 금액이 유효하지 않은 경우 0을 반환
        /// </returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(name + " says : " + amount + " isn't valid amount.");
                return 0;
            }
            if (amount > cash)
            {
                Console.WriteLine(name + " says : " + "I don't have enough cash to give you " + amount);
                return 0;
            }
            cash -= amount;
            return amount;
        }

        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(name + " says : " + amount + " isn't an amount I'll take.");
            }
            else
            {
                cash += amount;
            }
        }
    }
}
