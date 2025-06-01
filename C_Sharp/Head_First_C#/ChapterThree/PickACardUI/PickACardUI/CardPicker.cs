using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace PickACardUI
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCard)
        {
            string[] pickedCards = new string[numberOfCard];
            for(int i = 0; i < numberOfCard; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }


        private static string RandomValue()
        {
            // 1 ~ 14 사이 임의의 숫자 뽑기
            int value = random.Next(1, 14);

            //1 이면 에이스를 반환
            if (value == 1) return "Ace";
            //11 이면 잭을 반환
            if (value == 11) return "Jack";
            //12 이면 퀸을 반환
            if (value == 12) return "Queen";
            //13 이면 킹을 반환
            if (value == 13) return "King";




            //그 외 숫자가 확인될 경우 숫자를 string 형태로 변환 후 리턴
            return value.ToString(); 
        }
        private static string RandomSuit()
        {
            //1 ~ 4 사이 임의의 숫자 뽑기
            int value = random.Next(1,5);
            //1 이면 스페이드를 반환
            if (value == 1) return "Spades";
            //2 이면 하트
            if (value == 2) return "Hearts";
            //3 이면 클로버
            if (value == 3) return "Clubs";
            // 그 외 값이면 다이아몬드
            return "Diamonds";
        }
    }
}