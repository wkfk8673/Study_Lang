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

namespace ExperimentWithControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void nubmerTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            number.Text = nubmerTextBox.Text; // number TextBlock 의 텍스트 Textbox 의 텍스트로 변경
        }

        private void nubmerTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result); // 숫자가 아닌 모든 텍스트를 무시
        }
    }
}