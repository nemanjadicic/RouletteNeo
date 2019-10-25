using RouletteNeoLibrary;
using RouletteNeoLibrary.BusinessLogic;
using RouletteNeoLibrary.DataAccess;
using RouletteNeoLibrary.Models;
using RouletteNeoUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteNeoUI.Logic
{
    public static class UserInputHelper
    {
        public static RoundModel EnterNumber(byte digit, RoundModel round, IRouletteSession rouletteSessionForm, ISessionStart sessionStartForm)
        {
            round.WinningNumber = digit;
            round.CalibrateBetUnit(round.Spin, rouletteSessionForm, sessionStartForm, digit);
            round.CalibrateMoney(digit, rouletteSessionForm);
            round.ExpectedNumbers = NumberLogic.GetExpectedNumbers(rouletteSessionForm, round);

            return round;
        }





        public static void CheckIfUserHasWon(RoundModel round, UserModel currentUser, IRouletteSession rouletteSessionForm, IUserWon userWonForm)
        {
            if (round.Spin > rouletteSessionForm.SessionStart)
            {
                if (round.Money >= rouletteSessionForm.Goal)
                {
                    currentUser.Won = true;

                    userWonForm = new YouWonForm(currentUser, rouletteSessionForm);
                    userWonForm.ShowDialog();
                    rouletteSessionForm.Close();

                    SQLiteDataAccess.UpdateUserWon(currentUser);
                }
            }
        }
    }
}
