using RouletteNeoLibrary;
using RouletteNeoLibrary.BusinessLogic;
using RouletteNeoLibrary.DataAccess;
using RouletteNeoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouletteNeoUI.Forms
{
    public partial class RouletteSessionForm : Form, IRouletteSession
    {
        public int SessionStart { get; } = 37;
        public decimal StartingMoney { get; set; } = 0;
        public decimal StartingBetUnit { get; set; } = 0;
        public decimal Goal { get; set; } = 0;
        public List<NumberModel> AllRouletteNumbers { get; set; } = new List<NumberModel>();
        public List<RoundModel> AllRounds { get; set; } = new List<RoundModel>();
        public UserModel CurrentUser { get; set; }
        public ISessionStart sessionStartForm { get; set; }
        public IUserWon userWonForm { get; set; }

        SoundPlayer tickSound = new SoundPlayer(Properties.Resources.tick);





        public RouletteSessionForm(UserModel user)
        {
            InitializeComponent();

            CurrentUser = user;




            for (byte i = 0; i <= 36; i++)
            {
                AllRouletteNumbers.Add(new NumberModel(i));
            }




            List<Button> numberButtons = new List<Button>{ button0, button1, button2, button3, button4, button5, button6, button7,
                button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19,
                button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31,
                button32, button33, button34, button35, button36 };

            foreach (Button numberButton in numberButtons)
            {
                numberButton.Click += NumberButton_Click;
            }




            TextBox[] allTextBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7,
            textBox8, textBox9, textBox10, textBox11, textBox12 };

            foreach (var textBox in allTextBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }




            outputRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            outputRichTextBox.AppendText($"Expected numbers: \n\n\n ???");
        }





        //                  UI RELATED METHODS AND EVENT HANDLERS
        private void ChangeTextBoxInterface(TextBox tb)
        {
            bool validNumber = byte.TryParse(tb.Text, out byte tempNumber);

            byte[] redNumbers = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

            if (validNumber)
            {
                if (redNumbers.Contains(tempNumber))
                {
                    tb.ForeColor = Color.Red;
                    tb.TextAlign = HorizontalAlignment.Left;
                }
                else if (tempNumber == 0)
                {
                    tb.ForeColor = Color.Green;
                    tb.TextAlign = HorizontalAlignment.Center;
                }
                else
                {
                    tb.ForeColor = Color.Black;
                    tb.TextAlign = HorizontalAlignment.Right;
                }
            }
            else
            {
                tb.Clear();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            ChangeTextBoxInterface(tb);
        }

        private void CascadeTextboxes()
        {
            textBox12.Text = textBox11.Text;
            textBox11.Text = textBox10.Text;
            textBox10.Text = textBox9.Text;
            textBox9.Text = textBox8.Text;
            textBox8.Text = textBox7.Text;
            textBox7.Text = textBox6.Text;
            textBox6.Text = textBox5.Text;
            textBox5.Text = textBox4.Text;
            textBox4.Text = textBox3.Text;
            textBox3.Text = textBox2.Text;
            textBox2.Text = textBox1.Text;
        }

        private void ReverseTextboxes()
        {
            textBox1.Text = textBox2.Text;
            textBox2.Text = textBox3.Text;
            textBox3.Text = textBox4.Text;
            textBox4.Text = textBox5.Text;
            textBox5.Text = textBox6.Text;
            textBox6.Text = textBox7.Text;
            textBox7.Text = textBox8.Text;
            textBox8.Text = textBox9.Text;
            textBox9.Text = textBox10.Text;
            textBox10.Text = textBox11.Text;
            textBox11.Text = textBox12.Text;

            if (AllRounds.Count > 0)
            {
                int index = AllRounds.Count() - 13;

                if (AllRounds.Count > 12)
                {
                    RoundModel round = AllRounds[index];
                    textBox12.Text = round.WinningNumber.ToString();
                }
                else
                {
                    textBox12.Clear();
                }
            }
        }

        private void DisplayCurrentRound(RoundModel round)
        {
            spinsLabel.Text = round.Spin.ToString();

            textBox1.Text = round.WinningNumber.ToString();

            goalLabel.Text = $"Goal: {Goal.ToString("0.00")}";
            moneyLabel.Text = $"Money: {round.Money.ToString("0.00")}";
            betUnitLabel.Text = $"Bet Unit: {round.BetUnit.ToString("0.00")}";

            if (round.Spin >= SessionStart)
            {
                outputRichTextBox.Clear();
                outputRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                if (round.ExpectedNumbers != null)
                {
                    outputRichTextBox.AppendText($"Place {round.BetUnit.ToString("0.00")} on the {round.ExpectedNumbers.Count} expected numbers: " +
                                $"\n\n\n" + String.Join(", ", round.ExpectedNumbers));
                }
            }
            else
            {
                outputRichTextBox.Clear();
                outputRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                outputRichTextBox.AppendText($"Expected numbers: \n\n\n ???");
            }
        }

        private void ResetUI()
        {
            foreach (var control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }

            spinsLabel.Text = "0";

            goalLabel.Text = "Goal: ?";
            moneyLabel.Text = "Money: ?";
            betUnitLabel.Text = "Bet Unit: ?";

            outputRichTextBox.Clear();
            outputRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            outputRichTextBox.AppendText($"Expected numbers: \n\n\n ???");
        }





        //                  CONTROLS EVENT HANDLERS
        private void RouletteSessionForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Won == true && CurrentUser.BoughtSub == false)
            {
                BuySubForm newBuySub = new BuySubForm(CurrentUser, this);
                this.Hide();
                newBuySub.ShowDialog();
                this.Close();
            }
            else
            {
                welcomeUserLabel.Text = $"Welcome {CurrentUser.Username}!";
            }
        }
        
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            byte digit = byte.Parse(button.Text);



            RoundModel round = new RoundModel();
            round.Spin = AllRounds.Count() + 1;
            round = NumberLogic.EnterNumber(digit, round, this, sessionStartForm);
            AllRounds.Add(round);



            NumberLogic.UpdateNumberProperties(digit, this);
            NumberLogic.CheckIfUserHasWon(round, CurrentUser, this, userWonForm);



            CascadeTextboxes();
            DisplayCurrentRound(round);

            tickSound.Play();
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            RoundModel round = new RoundModel();
            round.Spin = AllRounds.Count() + 1;

            if (e.KeyCode == Keys.Enter)
            {
                if (InputValueAllowed())
                {
                    byte currentNumber = byte.Parse(inputTextBox.Text);

                    foreach (NumberModel number in AllRouletteNumbers)
                    {
                        if (currentNumber == number.Digit)
                        {
                            round = NumberLogic.EnterNumber(currentNumber, round, this, sessionStartForm);
                        }
                    }

                    AllRounds.Add(round);

                    NumberLogic.UpdateNumberProperties(currentNumber, this);
                    NumberLogic.CheckIfUserHasWon(round, CurrentUser, this, userWonForm);
                }

                inputTextBox.Clear();
                CascadeTextboxes();
                DisplayCurrentRound(round);

                tickSound.Play();
            }
        }

        private bool InputValueAllowed()
        {
            bool numberValid = byte.TryParse(inputTextBox.Text, out byte number);

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

        private void undoButton_Click(object sender, EventArgs e)
        {
            RoundModel round = new RoundModel();

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

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Don't use this app if you are playing American Roulette! It only works on European Roulette. Also, it's advised to use " +
                "only on virtual Roulette tables. The app has never been tested on real Roulette tables." +
                "\n\n2. The app's AI needs input of 37 numbers that happened during your Roulette session." +
                " The AI will then calculate expected numbers and you're good to go.\n\n", "Instructions");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            NumberLogic.ResetProgress(this);
            ResetUI();
        }
    }
}
