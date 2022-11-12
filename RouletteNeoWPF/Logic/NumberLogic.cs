using RouletteNeoWPF.Models;
using RouletteNeoWPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RouletteNeoWPF.Logic
{
    public static class NumberLogic
    {
        private static void NumberNotHappenedIncrement(RouletteSessionView rouletteSession)
        {
            foreach (Number number in rouletteSession.AllRouletteNumbers)
                number.NotHappened++;
        }



        private static void NumberNotHappenedDecrement(RouletteSessionView rouletteSession)
        {
            foreach (Number number in rouletteSession.AllRouletteNumbers)
                number.NotHappened--;
        }



        public static void UpdateNumberProperties(int digit, RouletteSessionView rouletteSession)
        {
            Number number = rouletteSession.AllRouletteNumbers[digit];

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

            NumberNotHappenedIncrement(rouletteSession);
            number.NotHappened = 0;
            number.Happened++;
        }



        public static void UndoNumberProperties(int? latestNumber, RouletteSessionView rouletteSession)
        {
            foreach (Number number in rouletteSession.AllRouletteNumbers)
            {
                if (number.Digit == latestNumber)
                {
                    NumberNotHappenedDecrement(rouletteSession);

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



        private static float CalculateGlobalAverageGap(RouletteSessionView rouletteSession)
        {
            List<float> allNumberGaps = new List<float>();

            foreach (var number in rouletteSession.AllRouletteNumbers)
            {
                allNumberGaps.Add(number.AverageGap);
            }

            return allNumberGaps.Average();
        }



        private static int CalculateHappenedAverage(RouletteSessionView rouletteSession)
        {
            int happenedAVG;
            List<int> happenedList = new List<int>();

            foreach (var number in rouletteSession.AllRouletteNumbers)
            {
                happenedList.Add(number.Happened);
            }

            happenedAVG = Convert.ToInt32(Math.Round(happenedList.Average(), MidpointRounding.AwayFromZero));

            return happenedAVG;
        }



        public static List<int> GetExpectedNumbers(RouletteSessionView rouletteSession, Round round)
        {
            int notHappenedDistance = 9;    // CHANGEABLE PARAMETER. Represents how far is Number's NotHappened value from the Number's AverageGap value.

            List<int> expectedNumbers = new List<int>();
            float globalAverageGap = CalculateGlobalAverageGap(rouletteSession);

            foreach (var number in rouletteSession.AllRouletteNumbers)
            {
                if (number.NotHappened >= (globalAverageGap - notHappenedDistance) && number.NotHappened <= (globalAverageGap + notHappenedDistance))
                {
                    if (!expectedNumbers.Contains(number.Digit))
                    {
                        expectedNumbers.Add(number.Digit);
                    }
                }
            }

            return expectedNumbers;
        }



        public static void ResetProgress(RouletteSessionView rouletteSession)
        {
            rouletteSession.AllRounds.Clear();

            foreach (Number number in rouletteSession.AllRouletteNumbers)
            {
                number.Happened = 0;
                number.NotHappened = 0;
                number.AverageGap = 0;
                number.NotHappenedList.Clear();
            }
        }
    }
}
