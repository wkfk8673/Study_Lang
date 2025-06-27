using System.ComponentModel;

namespace PaintBallGun
{
    internal class PaintBallGun
    {
        public PaintBallGun(int balls, int magazineSize, bool loaded)
        {
            Balls = balls;
            MagazineSize = magazineSize;
            if (!loaded) Reload();
        }

        public int MagazineSize { get; private set; } = 16; // 초기화 

        private int balls;
        public int Balls
        {
            get { return balls; }
            set
            {
                if (value > 0)
                    balls = value;
                Reload();
            }
        }

        public int BallsLoaded { get; private set; }

        public bool IsEmpty() { return BallsLoaded == 0; }

        public void Reload()
        {
            if (Balls > MagazineSize)
            {
                BallsLoaded = MagazineSize;
            }
            else
            {
                BallsLoaded = Balls;
            }
        }

        public bool Shoot()
        {
            if (BallsLoaded == 0) return false;
            BallsLoaded--;
            Balls--;
            return true;
        }
    }
}