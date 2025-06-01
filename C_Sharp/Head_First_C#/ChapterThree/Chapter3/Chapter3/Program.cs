using System.Numerics;

namespace PickRandomCards
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // 기능 안내
            Console.Write("Enter the Number of cards to pick : ");

            // 입력 받은 stirng 정보 저장
            string line = Console.ReadLine();

            if(int.TryParse(line,out int numberOfCards))
            {
                numberOfCards = int.Parse(line);

                foreach(string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("!!!Wrong Input!!!");
            }


        }


    }
}
