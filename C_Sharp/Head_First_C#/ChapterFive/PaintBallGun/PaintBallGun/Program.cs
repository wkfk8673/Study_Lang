namespace PaintBallGun
{
    internal class Program
    {
        /// <summary>
        /// 속성을 사용하여 단순화
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numberOfBalls = ReadInt(20, "number of balls");
            int magazineSize = ReadInt(16, "magazineSize");

            Console.WriteLine($"Loaded [false]: ");
            bool.TryParse(Console.ReadLine(), out bool isLoaded);

            PaintBallGun gun = new PaintBallGun(numberOfBalls, magazineSize, isLoaded);
            while (true)
            {
                Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");
                if (gun.IsEmpty()) Console.WriteLine("WARNING : You're out of ammo");
                Console.WriteLine("Space to Shoot, r to reload, + to add ammo, q to quit");
                char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
                else if (key == 'r') gun.Reload();
                else if (key == '+') gun.Balls += gun.MagazineSize;
                else if (key == 'q') return;
            }
        }

        public static int ReadInt(int lastUsedVaule, string prompt)
        {
            Console.Write(prompt + "[" + lastUsedVaule + "]: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value))
            {
                Console.WriteLine(" using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine(" using default value " + lastUsedVaule);
                return lastUsedVaule;
            }
        }
    }
}
