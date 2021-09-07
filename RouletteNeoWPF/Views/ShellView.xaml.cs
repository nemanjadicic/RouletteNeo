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
            if (UserDataValid())
            {
                RouletteSessionView rouletteSession = new RouletteSessionView
                    (
                        UsernameTextBox.Text,
                        float.Parse(StartingMoneyTextBox.Text),
                        float.Parse(BettingUnitTextBox.Text)
                    );

                ActiveView.Content = rouletteSession;
            }
            else
            {
                MessageBox.Show("Please enter valid Starting Money and Betting Unit");
            }
        }

        private bool UserDataValid()
        {
            bool dataValid = true;

            bool moneyValid = float.TryParse(StartingMoneyTextBox.Text, out float startingMoney);
            bool betUnitValid = float.TryParse(BettingUnitTextBox.Text, out float betUnit);

            if (moneyValid == false || betUnitValid == false)
            {
                dataValid = false;
            }

            return dataValid;
        }
    }
}
