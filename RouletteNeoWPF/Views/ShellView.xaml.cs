using System.Windows;
using System.Windows.Input;

namespace RouletteNeoWPF.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            string user = UsernameTextBox.Text;
            float startMoney = float.Parse(StartingMoneyTextBox.Text);
            float betUnit = float.Parse(BettingUnitTextBox.Text);

            RouletteSessionView rouletteSession = new RouletteSessionView(user, startMoney, betUnit);

            ActiveView.Content = rouletteSession;
        }
    }
}
