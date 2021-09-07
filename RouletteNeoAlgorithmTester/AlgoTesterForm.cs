using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RouletteNeoAlgorithmTester
{
    public partial class AlgoTesterForm : Form
    {
        List<NumberModel> allNumbers = new List<NumberModel>();

        Queue<byte> lastTwelveNumbers = new Queue<byte>();

        decimal currentMoney = 0;

        int spins = 0, winCount = 0, loseCount = 0;

        Random rnd = new Random();





        public AlgoTesterForm()
        {
            InitializeComponent();

            for (byte i = 0; i <= 36; i++)
            {
                allNumbers.Add(new NumberModel(i));
            }
        }




        //              Number logic methods
        public void QueueMaitenance(byte number)
        {
            if (lastTwelveNumbers.Count == 12)
            {
                lastTwelveNumbers.Dequeue();
                lastTwelveNumbers.Enqueue(number);
            }

            else
                lastTwelveNumbers.Enqueue(number);
        }

        public void NumberNotHappenedIncrement(List<NumberModel> numbers)
        {
            foreach (var number in numbers)
            {
                number.NotHappened++;
            }
        }

        public void UpdateNumberProperties(byte digit)
        {
            NumberModel number = allNumbers[digit];

            if (number.NotHappened > 0)
            {
                if (number.NotHappenedList != null)
                {
                    number.NotHappenedList.Add(number.NotHappened);
                    number.AverageGap = (float)number.NotHappenedList.Average();
                }
                else
                {
                    number.AverageGap = number.NotHappened;
                }
            }

            NumberNotHappenedIncrement(allNumbers);
            number.NotHappened = 0;
            number.Happened++;
        }

        public float CalculateHappenedAverage(List<NumberModel> numbers)
        {
            List<float> happenedValues = new List<float>();

            foreach (var number in numbers)
                happenedValues.Add(number.Happened);

            return happenedValues.Average();
        }

        public float CalculateAverageGap(List<NumberModel> numbers)
        {
            List<float> NH_averages = new List<float>();

            foreach (var number in numbers)
                NH_averages.Add(number.AverageGap);

            return NH_averages.Average();
        }

        public HashSet<byte> GetExpectedNumbers(List<NumberModel> numbers)
        {
            float happAVG = (float)Math.Round(CalculateHappenedAverage(allNumbers), 0, MidpointRounding.ToEven);
            float notHappenedAVG = CalculateAverageGap(allNumbers);
            HashSet<byte> expectedNumbers = new HashSet<byte>();
            byte excludeLast = Convert.ToByte(tb_ExcludeLast.Text);



            if (checkBox_A1_NumGapAlgo.Checked)
            {
                try
                {
                    int notHappenedDistance = Convert.ToInt32(tb_A1_NH_Distance.Text);

                    foreach (var number in numbers)
                    {
                        if (number.NotHappened >= (number.AverageGap - notHappenedDistance) && number.NotHappened <= (number.AverageGap + notHappenedDistance))
                            if (!expectedNumbers.Contains(number.Digit))
                            {
                                expectedNumbers.Add(number.Digit);
                            }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("All input parameters must be numbers within a certain range.");
                }
            }




            if (checkBox_A2_AvgGapAlgo.Checked)
            {
                try
                {
                    int notHappenedDistance = Convert.ToInt32(tb_A2_NH_Distance.Text);

                    foreach (var number in numbers)
                    {
                        if (number.NotHappened >= (notHappenedAVG - notHappenedDistance) && number.NotHappened <= (notHappenedAVG + notHappenedDistance))
                            if (!expectedNumbers.Contains(number.Digit))
                            {
                                expectedNumbers.Add(number.Digit);
                            }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("All input parameters must be numbers within a certain range.");
                }
            }




            if (checkBox_A3_AvgHappAlgo.Checked)
            {
                try
                {
                    int happenedToAVG = Convert.ToInt32(tb_A3_HappToAVG.Text);

                    foreach (var number in numbers)
                    {
                        if (number.Happened == (happAVG + happenedToAVG))
                            if (!expectedNumbers.Contains(number.Digit))
                            {
                                expectedNumbers.Add(number.Digit);
                            }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("All input parameters must be numbers within a certain range.");
                }
            }



            expectedNumbers.ExceptWith(lastTwelveNumbers.Take(excludeLast));

            return expectedNumbers;
        }





        //              Testing logic methods
        public void ResetSession(List<NumberModel> numbers)
        {
            foreach (var number in numbers)
            {
                number.Happened = 0;
                number.NotHappened = 0;
                number.AverageGap = 0;
                number.NotHappenedList.Clear();
            }

            spins = 0;
            currentMoney = 0;
        }

        public void SimulateRouletteSession()
        {
            decimal startingMoney = Convert.ToDecimal(tb_StartingMoney.Text);
            decimal oneBetUnit = Convert.ToDecimal(tb_OneBetUnit.Text);
            decimal treshold = Convert.ToDecimal(tb_WinLoseTreshold.Text);
            decimal appliedTreshold = oneBetUnit * treshold;

            
            currentMoney = startingMoney;

            while (currentMoney <= (startingMoney + appliedTreshold) && currentMoney >= startingMoney - appliedTreshold)
            {
                PerformSpin();
            }
            
            if (currentMoney > startingMoney)
                winCount++;
            else
                loseCount++;

            ResetSession(allNumbers);
        }

        public bool HitOrMiss(byte number)
        {
            bool hit;

            List<byte> expectedNumbers = GetExpectedNumbers(allNumbers).ToList();

            if (expectedNumbers.Contains(number))
            {
                hit = true;
            }
            else
            {
                hit = false;
            }

            return hit;
        }

        public void PerformSpin()
        {
            List<byte> playingNumbers = GetExpectedNumbers(allNumbers).ToList();
            int sessionStart = Convert.ToInt32(tb_SessionStart.Text);
            decimal oneBetUnit = Convert.ToDecimal(tb_OneBetUnit.Text);
            byte randomNumber = (byte)rnd.Next(0, 37);


            if (spins >= sessionStart)
            {
                currentMoney = currentMoney - (playingNumbers.Count * oneBetUnit);

                bool hit = HitOrMiss(randomNumber);

                if (hit == true)
                {
                    currentMoney = currentMoney + (36 * oneBetUnit);
                }
            }

            QueueMaitenance(randomNumber);

            switch (randomNumber)
            {
                case 0:
                    UpdateNumberProperties(0);
                    break;

                case 1:
                    UpdateNumberProperties(1);
                    break;

                case 2:
                    UpdateNumberProperties(2);
                    break;

                case 3:
                    UpdateNumberProperties(3);
                    break;

                case 4:
                    UpdateNumberProperties(4);
                    break;

                case 5:
                    UpdateNumberProperties(5);
                    break;

                case 6:
                    UpdateNumberProperties(6);
                    break;

                case 7:
                    UpdateNumberProperties(7);
                    break;

                case 8:
                    UpdateNumberProperties(8);
                    break;

                case 9:
                    UpdateNumberProperties(9);
                    break;

                case 10:
                    UpdateNumberProperties(10);
                    break;

                case 11:
                    UpdateNumberProperties(11);
                    break;

                case 12:
                    UpdateNumberProperties(12);
                    break;

                case 13:
                    UpdateNumberProperties(13);
                    break;

                case 14:
                    UpdateNumberProperties(14);
                    break;

                case 15:
                    UpdateNumberProperties(15);
                    break;

                case 16:
                    UpdateNumberProperties(16);
                    break;

                case 17:
                    UpdateNumberProperties(17);
                    break;

                case 18:
                    UpdateNumberProperties(18);
                    break;

                case 19:
                    UpdateNumberProperties(19);
                    break;

                case 20:
                    UpdateNumberProperties(20);
                    break;

                case 21:
                    UpdateNumberProperties(21);
                    break;

                case 22:
                    UpdateNumberProperties(22);
                    break;

                case 23:
                    UpdateNumberProperties(23);
                    break;

                case 24:
                    UpdateNumberProperties(24);
                    break;

                case 25:
                    UpdateNumberProperties(25);
                    break;

                case 26:
                    UpdateNumberProperties(26);
                    break;

                case 27:
                    UpdateNumberProperties(27);
                    break;

                case 28:
                    UpdateNumberProperties(28);
                    break;

                case 29:
                    UpdateNumberProperties(29);
                    break;

                case 30:
                    UpdateNumberProperties(30);
                    break;

                case 31:
                    UpdateNumberProperties(31);
                    break;

                case 32:
                    UpdateNumberProperties(32);
                    break;

                case 33:
                    UpdateNumberProperties(33);
                    break;

                case 34:
                    UpdateNumberProperties(34);
                    break;

                case 35:
                    UpdateNumberProperties(35);
                    break;

                case 36:
                    UpdateNumberProperties(36);
                    break;
            }

            spins++;
        }

        public void PerformTests(int totalSessions)
        {
            progressBar.Maximum = totalSessions;

            for (int session = 1; session <= totalSessions; session++)
            {
                SimulateRouletteSession();

                progressBar.Value = session * progressBar.Maximum / totalSessions;
            }

            float wonPercent = (float)winCount * 100 / (winCount + loseCount);
            float lostPercent = (float)loseCount * 100 / (winCount + loseCount);

            outcomeLabel.Text = String.Format($"WON  ({wonPercent.ToString("0.0")} %)  {winCount}  -  {loseCount}  ({lostPercent.ToString("0.0")} %)  LOST");
        }





        //              UI event handlers
        private void testButton_Click(object sender, EventArgs e)
        {
            int.TryParse(tb_numberOfSessions.Text, out int totalSessions); 

            PerformTests(totalSessions);
        }

        private void tb_numberOfSessions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                testButton.PerformClick();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            winCount = 0;
            loseCount = 0;

            outcomeLabel.Text = "won (%) ? - ? (%) lost";
        }
    }
}
