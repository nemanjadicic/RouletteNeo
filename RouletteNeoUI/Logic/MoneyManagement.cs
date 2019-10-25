using RouletteNeoLibrary;
using RouletteNeoLibrary.BusinessLogic;
using RouletteNeoLibrary.Models;
using RouletteNeoUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteNeoUI.Logic
{
    public static class MoneyManagement
    {
        public static RoundModel CalibrateBetUnit(this RoundModel round, int spin, IRouletteSession rouletteSess, ISessionStart sessionStart, byte winningNumber)
        {
            if (round.Spin == rouletteSess.SessionStart)
            {
                sessionStart = new SessionStartForm();
                sessionStart.ShowDialog();

                rouletteSess.StartingMoney = sessionStart.StartMoney;
                rouletteSess.StartingBetUnit = sessionStart.BetUnit;

                rouletteSess.Goal = rouletteSess.StartingMoney + rouletteSess.StartingBetUnit * 50;
                round.Money = rouletteSess.StartingMoney;
                round.BetUnit = rouletteSess.StartingBetUnit;
            }

            if (round.Spin >= rouletteSess.SessionStart)
            {
                if (rouletteSess.AllRounds.Last().Money > 0)
                {
                    round.Money = rouletteSess.AllRounds.Last().Money;
                }
                else
                {
                    round.Money = rouletteSess.StartingMoney;
                }



                if (rouletteSess.AllRounds.Last().BetUnit > 0)
                {
                    round.BetUnit = rouletteSess.AllRounds.Last().BetUnit;
                }
                else
                {
                    round.BetUnit = rouletteSess.StartingBetUnit;
                }


                CalibrateMoney(round, winningNumber, rouletteSess);
                decimal playingCost = NumberLogic.GetExpectedNumbers(rouletteSess, round).Count * round.BetUnit;



                if (round.Money - playingCost >= rouletteSess.StartingMoney - (rouletteSess.StartingBetUnit * 50))
                    round.BetUnit = rouletteSess.StartingBetUnit;

                if (round.Money - playingCost <= rouletteSess.StartingMoney - (rouletteSess.StartingBetUnit * 50))
                    round.BetUnit = rouletteSess.StartingBetUnit * 2;

                if (round.Money - playingCost <= rouletteSess.StartingMoney - (rouletteSess.StartingBetUnit * 150) && round.Money > rouletteSess.StartingMoney - (rouletteSess.StartingBetUnit * 350))
                    round.BetUnit = rouletteSess.StartingBetUnit * 4;

                if (round.Money - playingCost <= rouletteSess.StartingMoney - (rouletteSess.StartingBetUnit * 350) && round.Money > rouletteSess.StartingMoney - (rouletteSess.StartingBetUnit * 750))
                    round.BetUnit = rouletteSess.StartingBetUnit * 8;

                if (round.Money - playingCost <= rouletteSess.StartingMoney - (rouletteSess.StartingBetUnit * 750))
                    round.BetUnit = rouletteSess.StartingBetUnit * 16;
            }

            return round;
        }



        public static RoundModel CalibrateMoney(this RoundModel round, byte digit, IRouletteSession rouletteSessionForm)
        {
            if (round.Spin > rouletteSessionForm.SessionStart)
            {
                if (rouletteSessionForm.AllRounds.Last().Money > 0)
                {
                    round.Money = rouletteSessionForm.AllRounds.Last().Money;
                }
                else
                {
                    round.Money = rouletteSessionForm.StartingMoney;
                }

                if (rouletteSessionForm.AllRounds.Last().ExpectedNumbers.Contains(digit))
                {
                    round.Money += (36 * rouletteSessionForm.AllRounds.Last().BetUnit);
                }

                round.Money -= (rouletteSessionForm.AllRounds.Last().ExpectedNumbers.Count * rouletteSessionForm.AllRounds.Last().BetUnit);
            }

            return round;
        }
    }
}
