using RouletteNeoWPF.Models;
using RouletteNeoWPF.Views;
using System.Linq;
using System.Windows.Ink;

namespace RouletteNeoWPF.Logic
{
    public static class MoneyManagement
    {
        public static Round CalibrateBetUnit(this Round round, int spin, RouletteSessionView rouletteSession, int winningNumber)
        {
            if (round.Spin <= rouletteSession.SessionStart)
            {
                if (rouletteSession.AllRounds.Any())
                {
                    round.Money = rouletteSession.AllRounds.Last().Money;
                }
                else
                {
                    round.Money = rouletteSession.StartingMoney;
                }

                round.BetUnit = rouletteSession.StartingBetUnit;
            }

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
            //  Calibrate money only if the Roulette Neo's session has started
            if (round.Spin > rouletteSession.SessionStart)
            {
                round.Money = rouletteSession.AllRounds.Last().Money;

                if (rouletteSession.AllRounds.Last().ExpectedNumbers.Contains(digit))
                {
                    round.Money += (36 * rouletteSession.AllRounds.Last().BetUnit);
                }

                round.Money -= (rouletteSession.AllRounds.Last().ExpectedNumbers.Count * rouletteSession.AllRounds.Last().BetUnit);
            }
            else
            {
                //  If the roulette session didn't start, but 0 happened, substract from the Session Goal and Starting Money
                if (digit == 0)
                {
                    var lastRoundMoney = rouletteSession.AllRounds.Last().Money;

                    round.Money = lastRoundMoney - rouletteSession.StartingBetUnit * 2;
                    rouletteSession.Goal -= rouletteSession.StartingBetUnit * 2;
                }
            }

            return round;
        }
    }
}
