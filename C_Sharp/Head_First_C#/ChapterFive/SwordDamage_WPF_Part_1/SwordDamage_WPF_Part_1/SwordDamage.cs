using System.Diagnostics;

namespace SwordDamage_WPF_Part_1
{
    internal class SwordDamage
    {
        private const int BASE_DAMAGE = 3; // 상수로 설정, 추후 변경 불가
        private const int FLAME_DAMAGE = 2;

        private int Roll;
        private decimal MagicMultiplier = 1M;
        private int FlamingDamage = 0;
        private int Damage;

        private void CalculateDamage()
        {
            Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;
            Debug.WriteLine($"Calculated Damage = {Damage} | Roll = {Roll}");
        }

        private void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagicMultiplier = 1.75M;
            }
            else
            {
                MagicMultiplier = 1M;
            }
            CalculateDamage();
            Debug.WriteLine($"Magic = {Damage} | Roll = {Roll}");
        }

        private void SetFlaming(bool isFlaming)
        {
            if (isFlaming)
            {
                FlamingDamage += FLAME_DAMAGE;
            }
            CalculateDamage();
            Debug.WriteLine($"Flaming = {Damage} | Roll = {Roll}");
        }
    }
}