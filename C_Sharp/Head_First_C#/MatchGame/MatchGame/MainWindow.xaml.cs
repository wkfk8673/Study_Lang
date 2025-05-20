using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    using System.Windows.Threading; // 스레딩 기능을 사용한다고 네임스페이스 내부에 선언

    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer(); // 신규 타이머 생성
        int tenthsOfSecondsElapsed; // 유저가 게임을 진행한 시간
        int matchesFound; // 유저가 맞춘 동물의 쌍


        public MainWindow() //생성자
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(.1); // 0.1 초마다 시간을 잼
            timer.Tick += Timer_Tick;

            SetUpGame();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthsOfSecondsElapsed++; // 시간 흐름
            TimeTextBlock.Text = (tenthsOfSecondsElapsed / 10f).ToString("0.0s"); // 1초를 10으로 나누어 0.1
            if(matchesFound == 8)
            {
                timer.Stop();
                TimeTextBlock.Text = TimeTextBlock.Text + " - Play Again?";
            }
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
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "TimeTextBlock") // timeTextBlock 을 제외하고 진행
                {
                    textBlock.Visibility = Visibility.Visible; // textBlock 가시화
                    int index = random.Next(animalEmoji.Count); // index 를 animalEmoji 리스트 숫자 중 하나의 난수로 초기화
                    string nextEmoji = animalEmoji[index]; // nextEmoji 에 랜덤한 animalEmoji 리스트 항목을 저장
                    textBlock.Text = nextEmoji; // textBlock 의 text 를 이모지로 변경
                    animalEmoji.RemoveAt(index); // textBlock 값 변경에 쓰인 animalEmoji 의 항목을 제거
                }

            }
            timer.Start(); // 게임 초기화 후 타이머 시작
            tenthsOfSecondsElapsed = 0; // 경과시간 0으로 초기화
            matchesFound = 0; // 짝 맞추기 횟수 0으로 초기화


        }

        TextBlock lastTextBlockClicked;
        bool findingMatch = false;
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {


            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)//최초 클릭
            {
                //어떤 TextBlock 이 클릭됐는지 저장하고 동물을 감춤
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true; // 두번째 클릭과 비교 준비
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)//두 번째 동물을 클릭
            {
                matchesFound++; // 짝 맞추기 횟수 증가
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

        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(matchesFound == 8)
            {
                SetUpGame(); //8쌍의 동물 이모지를 모두 맞췄을 경우 초기화
            }
        }
    }
}