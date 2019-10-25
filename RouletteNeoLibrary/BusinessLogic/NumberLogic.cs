using RouletteNeoLibrary.DataAccess;
using RouletteNeoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteNeoLibrary.BusinessLogic
{
    public static class NumberLogic
    {
        private static void NumberNotHappenedIncrement(IRouletteSession rouletteSessionForm)
        {
            foreach (NumberModel number in rouletteSessionForm.AllRouletteNumbers)
                number.NotHappened++;
        }





        private static void NumberNotHappenedDecrement(IRouletteSession rouletteSessionForm)
        {
            foreach (NumberModel number in rouletteSessionForm.AllRouletteNumbers)
                number.NotHappened--;
        }





        public static void UpdateNumberProperties(byte digit, IRouletteSession rouletteSessionForm)
        {
            NumberModel number = rouletteSessionForm.AllRouletteNumbers[digit];

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

            NumberNotHappenedIncrement(rouletteSessionForm);
            number.NotHappened = 0;
            number.Happened++;
        }





        public static void UndoNumberProperties(int? latestNumber, IRouletteSession rouletteSessionForm)
        {
            foreach (NumberModel number in rouletteSessionForm.AllRouletteNumbers)
            {
                if (number.Digit == latestNumber)
                {
                    NumberNotHappenedDecrement(rouletteSessionForm);

                    if (number.NotHappenedList.Count > 0)
                    {
                        number.NotHappened = number.NotHappenedList.Last();
                        number.NotHappenedList.RemoveAt(number.NotHappenedList.Count - 1);

                        if (number.NotHappenedList.Count > 0)
                        {
                            number.AverageGap = (float)number.NotHappenedList.Average();
                        }
                        else
                        {
                            number.AverageGap = 0;
                        }
                    }
                    else
                    {
                        number.NotHappened = 0;
                    }



                    if (number.Happened > 0)
                    {
                        number.Happened--;
                    }
                }
            }
        }





        private static float CalculateGlobalAverageGap(IRouletteSession rouletteSessionForm)
        {
            List<float> allNumberGaps = new List<float>();

            foreach (var number in rouletteSessionForm.AllRouletteNumbers)
            {
                allNumberGaps.Add(number.AverageGap);
            }

            return allNumberGaps.Average();
        }





        private static int CalculateHappenedAverage(IRouletteSession rouletteSessionForm)
        {
            int happenedAVG;
            List<int> happenedList = new List<int>();

            foreach (var number in rouletteSessionForm.AllRouletteNumbers)
            {
                happenedList.Add(number.Happened);
            }

            happenedAVG = Convert.ToInt32(Math.Round(happenedList.Average(), MidpointRounding.AwayFromZero));

            return happenedAVG;
        }





        public static List<int> GetExpectedNumbers(IRouletteSession rouletteSessionForm, RoundModel round)
        {
            int notHappenedDistance = 8;    // CHANGEABLE PARAMETER. Represents how far is Number's NotHappened value from the Number's AverageGap value.

            List<int> expectedNumbers = new List<int>();
            List<int> happenedList = new List<int>();
            float globalAverageGap = CalculateGlobalAverageGap(rouletteSessionForm);
            double happenedAVG = CalculateHappenedAverage(rouletteSessionForm);

            foreach (var number in rouletteSessionForm.AllRouletteNumbers)
            {
                if (number.Happened == happenedAVG)
                {
                    happenedList.Add(number.Digit);
                }



                if (number.NotHappened >= (globalAverageGap - notHappenedDistance) && number.NotHappened <= (globalAverageGap + notHappenedDistance))
                {
                    if (happenedList.Contains(number.Digit))
                    {
                        if (!expectedNumbers.Contains(number.Digit))
                        {
                            expectedNumbers.Add(number.Digit);
                        }
                    }
                }



                if (number.NotHappened >= (number.AverageGap - notHappenedDistance) && number.NotHappened <= (number.AverageGap + notHappenedDistance))
                {
                    if (happenedList.Contains(number.Digit))
                    {
                        if (!expectedNumbers.Contains(number.Digit))
                        {
                            expectedNumbers.Add(number.Digit);
                        }
                    }
                }
            }

            return expectedNumbers;
        }





        public static void ResetProgress(IRouletteSession rouletteSessionForm)
        {
            rouletteSessionForm.AllRounds.Clear();
            rouletteSessionForm.Goal = 0;
            rouletteSessionForm.StartingMoney = 0;
            rouletteSessionForm.StartingBetUnit = 0;

            foreach (NumberModel number in rouletteSessionForm.AllRouletteNumbers)
            {
                number.Happened = 0;
                number.NotHappened = 0;
                number.AverageGap = 0;
                number.NotHappenedList.Clear();
            }
        }
    }
}
