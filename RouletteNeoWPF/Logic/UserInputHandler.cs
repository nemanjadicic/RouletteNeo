using RouletteNeoWPF.Models;
using RouletteNeoWPF.Views;

namespace RouletteNeoWPF.Logic
{
    public static class UserInputHandler
    {
        public static Round EnterNumber(int digit, Round round, RouletteSessionView rouletteSession)
        {
            round.WinningNumber = digit;
            round.CalibrateBetUnit(round.Spin, rouletteSession, digit);
            round.CalibrateMoney(digit, rouletteSession);
            round.ExpectedNumbers = NumberLogic.GetExpectedNumbers(rouletteSession, round);

            return round;
        }



        public static void CheckIfUserHasWon(Round round, RouletteSessionView rouletteSession)
        {
            if (round.Spin > rouletteSession.SessionStart)
            {
                if (round.Money >= rouletteSession.Goal)
                {
                    YouWonView youWon = new YouWonView(rouletteSession.UserName);
                    rouletteSession.UserWonView.Content = youWon;
                }
            }
        }
    }
}
