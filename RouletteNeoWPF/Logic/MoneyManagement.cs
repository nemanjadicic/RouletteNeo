using RouletteNeoWPF.Models;
using RouletteNeoWPF.Views;
using System.Linq;

namespace RouletteNeoWPF.Logic
{
    public static class MoneyManagement
    {
        public static Round CalibrateBetUnit(this Round round, int spin, RouletteSessionView rouletteSession, int winningNumber)
        {
            if (round.Spin >= rouletteSession.SessionStart)
            {
                if (rouletteSession.AllRounds.Last().Money > 0)
                {
                    round.Money = rouletteSession.AllRounds.Last().Money;
                }
                else
                {
                    round.Money = rouletteSession.StartingMoney;
                }



                if (rouletteSession.AllRounds.Last().BetUnit > 0)
                {
                    round.BetUnit = rouletteSession.AllRounds.Last().BetUnit;
                }
                else
                {
                    round.BetUnit = rouletteSession.StartingBetUnit;
                }


                CalibrateMoney(round, winningNumber, rouletteSession);
                float playingCost = NumberLogic.GetExpectedNumbers(rouletteSession, round).Count * round.BetUnit;



                if (round.Money - playingCost >= rouletteSession.StartingMoney - (rouletteSession.StartingBetUnit * 50))
                    round.BetUnit = rouletteSession.StartingBetUnit;

                if (round.Money - playingCost <= rouletteSession.StartingMoney - (rouletteSession.StartingBetUnit * 50))
                    round.BetUnit = rouletteSession.StartingBetUnit * 2;

                if (round.Money - playingCost <= rouletteSession.StartingMoney - (rouletteSession.StartingBetUnit * 150) && round.Money > rouletteSession.StartingMoney - (rouletteSession.StartingBetUnit * 350))
                    round.BetUnit = rouletteSession.StartingBetUnit * 4;

                if (round.Money - playingCost <= rouletteSession.StartingMoney - (rouletteSession.StartingBetUnit * 350) && round.Money > rouletteSession.StartingMoney - (rouletteSession.StartingBetUnit * 750))
                    round.BetUnit = rouletteSession.StartingBetUnit * 8;

                if (round.Money - playingCost <= rouletteSession.StartingMoney - (rouletteSession.StartingBetUnit * 750))
                    round.BetUnit = rouletteSession.StartingBetUnit * 16;
            }

            return round;
        }

        public static Round CalibrateMoney(this Round round, int digit, RouletteSessionView rouletteSession)
        {
            if (round.Spin > rouletteSession.SessionStart)
            {
                if (rouletteSession.AllRounds.Last().Money > 0)
                {
                    round.Money = rouletteSession.AllRounds.Last().Money;
                }
                else
                {
                    round.Money = rouletteSession.StartingMoney;
                }

                if (rouletteSession.AllRounds.Last().ExpectedNumbers.Contains(digit))
                {
                    round.Money += (36 * rouletteSession.AllRounds.Last().BetUnit);
                }

                round.Money -= (rouletteSession.AllRounds.Last().ExpectedNumbers.Count * rouletteSession.AllRounds.Last().BetUnit);
            }

            return round;
        }
    }
}
