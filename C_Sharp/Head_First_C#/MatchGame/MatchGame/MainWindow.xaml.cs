using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame() // 게임 초기화 메소드
        {
            List<string> animalEmoji = new List<string>() { // 리스트에 8쌍의 이모지를 저장
                "🐻‍","🐻‍",
                "🐨","🐨",
                "🐯","🐯",
                "🐭","🐭",
                "🐹","🐹",
                "🐰","🐰",
                "🐸","🐸",
                "🐼","🐼",
            };

            Random random = new Random(); // 랜덤 숫자 생성기

            //mainGrid 에 포함된 모든 TextBlock 을 찾고, 해당 textBlock 마다 아래의 명령어 실행
            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timeTextBlock") // timeTextBlock 을 제외하고 진행
                {
                    textBlock.Visibility = Visibility.Visible; // textBlock 가시화
                    int index = random.Next(animalEmoji.Count); // index 를 animalEmoji 리스트 숫자 중 하나의 난수로 초기화
                    string nextEmoji = animalEmoji[index]; // nextEmoji 에 랜덤한 animalEmoji 리스트 항목을 저장
                    textBlock.Text = nextEmoji; // textBlock 의 text 를 이모지로 변경
                    animalEmoji.RemoveAt(index); // textBlock 값 변경에 쓰인 animalEmoji 의 항목을 제거
                }
                
            }

        }

        TextBlock lastTextBlockClicked;
        bool findingMatch = false;
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
          
          
          

            TextBlock textBlock = sender as TextBlock;
            if(findingMatch == false)//최초 클릭
            {
                //어떤 TextBlock 이 클릭됐는지 저장하고 동물을 감춤
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true; // 두번째 클릭과 비교 준비
            }
            else if(textBlock.Text == lastTextBlockClicked.Text)//두 번째 동물을 클릭
            {
                //두 동물이 일치할 경우 둘다 감춤
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false; // 비교 중이지 않은 상태로 변경
            }
            else //두 번째 동물을 클릭
            {
                //일치하지 않을 경우 첫번째 동물 다시 표기
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;// 비교 중이지 않은 상태로 변경
            }
        }
    }
}