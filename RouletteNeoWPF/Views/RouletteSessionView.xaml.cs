using RouletteNeoWPF.Logic;
using RouletteNeoWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RouletteNeoWPF.Views
{
    /// <summary>
    /// Interaction logic for RouletteSessionView.xaml
    /// </summary>
    public partial class RouletteSessionView : UserControl
    {
        public RouletteSessionView(string user, float startMoney, float betUnit)
        {
            InitializeComponent();

            UserName = user;

            WelcomeTextBlock.Text = $"Welcome {UserName}!";
            MoneyTextBlock.Text =  startMoney.ToString("0.00");
            GoalTextBlock.Text = (startMoney + betUnit * 50).ToString("0.00");
            BetUnitTextBlock.Text = betUnit.ToString("0.00");



            for (int i = 0; i <= 36; i++)
            {
                AllRouletteNumbers.Add(new Number(i));
            }



            List<Button> numberButtons = new List<Button>{ Button0, Button1, Button2, Button3, Button4, Button5, Button6, Button7,
                Button8, Button9, Button10, Button11, Button12, Button13, Button14, Button15, Button16, Button17, Button18, Button19,
                Button20, Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28, Button29, Button30, Button31,
                Button32, Button33, Button34, Button35, Button36 };



            foreach (Button numberButton in numberButtons)
            {
                numberButton.Click += NumberButton_Click;
            }
        }



        public string UserName { get; set; }
        public int SessionStart { get; set; } = 56;
        public float StartingMoney { get; set; }
        public float StartingBetUnit { get; set; }
        public float Goal { get; set; } = 0;
        public List<Round> AllRounds { get; set; } = new List<Round>();
        public List<Number> AllRouletteNumbers { get; set; } = new List<Number>();



        SoundPlayer tickSound = new SoundPlayer(FileLocator.TickSoundLocation());



        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int digit = int.Parse(button.Content.ToString());



            Round round = new Round();
            round.Spin = AllRounds.Count() + 1;
            round = UserInputHandler.EnterNumber(digit, round, this);
            AllRounds.Add(round);



            NumberLogic.UpdateNumberProperties(digit, this);
            UserInputHandler.CheckIfUserHasWon(round, this);



            CascadeTextboxes();
            DisplayCurrentRound(round);

            tickSound.Play();
        }

        private void InputTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            Round round = new Round();
            round.Spin = AllRounds.Count() + 1;

            if (e.Key == Key.Enter)
            {
                if (InputValueAllowed())
                {
                    byte currentNumber = byte.Parse(InputTextBox.Text);

                    foreach (Number number in AllRouletteNumbers)
                    {
                        if (currentNumber == number.Digit)
                        {
                            round = UserInputHandler.EnterNumber(currentNumber, round, this);
                        }
                    }

                    AllRounds.Add(round);

                    NumberLogic.UpdateNumberProperties(currentNumber, this);
                    UserInputHandler.CheckIfUserHasWon(round, this);
                }

                InputTextBox.Clear();
                CascadeTextboxes();
                DisplayCurrentRound(round);

                tickSound.Play();
            }
        }

        private bool InputValueAllowed()
        {
            bool numberValid = byte.TryParse(InputTextBox.Text, out byte number);

            if (!numberValid)
            {
                MessageBox.Show("Letters and blank input are not allowed. Please enter a number between 0 and 36!", "Warning");
            }

            if (number < 0 || number > 36)
            {
                numberValid = false;
                MessageBox.Show("Only numbers between 0 and 36 are allowed!", "Warning");
            }

            return numberValid;
        }

        private void CascadeTextboxes()
        {
            TextBox12.Text = TextBox11.Text;
            TextBox11.Text = TextBox10.Text;
            TextBox10.Text = TextBox9.Text;
            TextBox9.Text = TextBox8.Text;
            TextBox8.Text = TextBox7.Text;
            TextBox7.Text = TextBox6.Text;
            TextBox6.Text = TextBox5.Text;
            TextBox5.Text = TextBox4.Text;
            TextBox4.Text = TextBox3.Text;
            TextBox3.Text = TextBox2.Text;
            TextBox2.Text = TextBox1.Text;
        }

        private void ReverseTextboxes()
        {
            TextBox1.Text = TextBox2.Text;
            TextBox2.Text = TextBox3.Text;
            TextBox3.Text = TextBox4.Text;
            TextBox4.Text = TextBox5.Text;
            TextBox5.Text = TextBox6.Text;
            TextBox6.Text = TextBox7.Text;
            TextBox7.Text = TextBox8.Text;
            TextBox8.Text = TextBox9.Text;
            TextBox9.Text = TextBox10.Text;
            TextBox10.Text = TextBox11.Text;
            TextBox11.Text = TextBox12.Text;

            if (AllRounds.Count > 0)
            {
                int index = AllRounds.Count() - 13;

                if (AllRounds.Count > 12)
                {
                    Round round = AllRounds[index];
                    TextBox12.Text = round.WinningNumber.ToString();
                }
                else
                {
                    TextBox12.Clear();
                }
            }
        }

        private void DisplayCurrentRound(Round round)
        {
            SpinsTextblock.Text = round.Spin.ToString();

            TextBox1.Text = round.WinningNumber.ToString();

            GoalTextBlock.Text = $"Goal: {Goal.ToString("0.00")}";
            MoneyTextBlock.Text = $"Money: {round.Money.ToString("0.00")}";
            BetUnitTextBlock.Text = $"Bet Unit: {round.BetUnit.ToString("0.00")}";

            if (round.Spin >= SessionStart)
            {
                OutputRichTextBox.Document.Blocks.Clear();
                OutputRichTextBox.HorizontalContentAlignment = HorizontalAlignment.Center;
                if (round.ExpectedNumbers != null)
                {
                    OutputRichTextBox.AppendText($"Place {round.BetUnit.ToString("0.00")} on the {round.ExpectedNumbers.Count} expected numbers: " +
                                $"\n\n\n" + String.Join(", ", round.ExpectedNumbers));
                }
            }
            else
            {
                OutputRichTextBox.Document.Blocks.Clear();
                OutputRichTextBox.HorizontalContentAlignment = HorizontalAlignment.Center;
                OutputRichTextBox.AppendText($"Expected numbers: \n\n\n ???");
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            ChangeTextBoxInterface(tb);
        }

        private void ChangeTextBoxInterface(TextBox tb)
        {
            bool validNumber = int.TryParse(tb.Text, out int tempNumber);

            int[] redNumbers = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

            if (validNumber)
            {
                if (redNumbers.Contains(tempNumber))
                {
                    tb.Foreground = new SolidColorBrush(Colors.Red);
                    tb.HorizontalContentAlignment = HorizontalAlignment.Left;
                }
                else if (tempNumber == 0)
                {
                    tb.Foreground = new SolidColorBrush(Colors.Green);
                    tb.HorizontalContentAlignment = HorizontalAlignment.Center;
                }
                else
                {
                    tb.Foreground = new SolidColorBrush(Colors.Black);
                    tb.HorizontalContentAlignment = HorizontalAlignment.Right;
                }
            }
            else
            {
                tb.Clear();
            }
        }
        


        private void UndoButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Round round = new Round();

            int index = AllRounds.Count - 2;

            if (index > 0)
            {
                round = AllRounds[index];
            }

            if (AllRounds.Count > 0)
            {
                NumberLogic.UndoNumberProperties(AllRounds.Last().WinningNumber, this);
            }

            DisplayCurrentRound(round);

            ReverseTextboxes();

            if (AllRounds.Count > 0)
            {
                AllRounds.RemoveAt(AllRounds.Count - 1);
            }
        }

        private void HelpButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show("1. Don't use this app if you are playing American Roulette! It only works on European Roulette. Also, it's advised to use " +
                "only on virtual Roulette tables. The app has never been tested on real Roulette tables." +
                "\n\n2. The app's AI needs input of 56 numbers that happened during your Roulette session." +
                " The AI will then calculate expected numbers and you're good to go.\n\n", "Instructions");
        }

        private void RestartButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NumberLogic.ResetProgress(this);
            ResetUI();
        }

        private void ResetUI()
        {
            List<TextBox> textBoxes =
                new List<TextBox> { TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8,
                    TextBox9, TextBox10, TextBox11, TextBox12 };


            foreach (var tb in textBoxes)
            {
                tb.Clear();
            }

            SpinsTextblock.Text = "0";

            GoalTextBlock.Text = Goal.ToString("0.00");
            MoneyTextBlock.Text = StartingMoney.ToString("0.00");
            BetUnitTextBlock.Text = StartingBetUnit.ToString("0.00");

            OutputRichTextBox.Document.Blocks.Clear();
            OutputRichTextBox.HorizontalContentAlignment = HorizontalAlignment.Center;
            OutputRichTextBox.AppendText($"Expected numbers: \n\n\n ???");
        }
    }
}
