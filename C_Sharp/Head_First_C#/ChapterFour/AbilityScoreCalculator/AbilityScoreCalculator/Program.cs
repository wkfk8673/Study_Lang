

namespace AbilityScore
{
    internal class AbilityScoreCalculator
    {
        
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

                public void CalculateAbilityScore()
        {
            //DivideBy 필드로 값을 나눔
            double divided = RollResult / DivideBy;

            //AddAmount를 나눗셈 결과에 더함
            //소수점 이하를 버리고 정수로 만들기
            int added = AddAmount + (int)divided;

            //결과값이 너무 작으면 Minimum 값을 사용
            if (added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }

        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll ");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide By ");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add Amount ");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum ");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability Score: " + calculator.Score);
                Console.WriteLine("Press Q to Quit, and other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;


            }
        }

        /// <summary>
        /// 메세지를 출력하고 콘솔에서 double 값을 읽어들임
        /// </summary>
        /// <param name="lastUsedValue"></param>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private static double ReadDouble(double lastUsedValue, string prompt)
        {
            // 메세지와 함께 기본값을 출력
            Console.Write(prompt + " [" + lastUsedValue + "] : ");
            string number = Console.ReadLine();

            if (double.TryParse(number, out double value))
            {
                Console.WriteLine("     using value : " + value);
                return value;
            }
            else
            {
                Console.WriteLine("     using default value : " + lastUsedValue);
                return lastUsedValue;
            }
        }

        /// <summary>
        /// 메세지를 출력하고 콘솔에서 Int 값을 읽어들임
        /// </summary>
        /// <param name="lastUsedValue"></param>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private static int ReadInt(int lastUsedValue, string prompt)
        {
            // 메세지와 함께 기본값을 출력
            Console.WriteLine(prompt + " [" + lastUsedValue + "] :    ");
            string number = Console.ReadLine();

            if (int.TryParse(number, out int value))
            {
                Console.WriteLine("     using value : " + value);
                return value;
            }
            else
            {
                Console.WriteLine("     using default value : " + lastUsedValue);
                return lastUsedValue;
            }

        }


    }
}
