using System;
using System.Collections.Generic;
using System.Text;

namespace SwordDamage_Console_Part_1
{
    internal class SwordDamage
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            SwordDamage swordDamage = new SwordDamage();

            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit : ");
                char num = Console.ReadKey().KeyChar;
                if (num != '0' && num != '1' && num != '2' && num != '3') return;
                int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                swordDamage.Roll = roll;
                swordDamage.SetMagic(num == 1 || num == 3);
                swordDamage.SetFlaming(num == 2 || num == 3);
                Console.WriteLine("\nRolled " + roll + " for " + swordDamage.Damage + "HP\n");

            }


        }

        public const int BASE_DAMAGE = 3; // 상수로 설정, 추후 변경 불가
        public const int FLAME_DAMAGE = 2;

        public int Roll;
        public decimal MagicMultiplier = 1M;
        public int FlamingDamage = 0;
        public int Damage;

        public void CalculateDamage()
        {
            Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;
        }
        
        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagicMultiplier = 1.75M;
            }
            else
            {
                MagicMultiplier = 1M;
            }
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }
    }
}
