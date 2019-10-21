using RouletteNeoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteNeoLibrary
{
    public interface IRouletteSession
    {
        /// <summary>
        /// Represents at what spin does the Roulette session begin.
        /// </summary>
        int SessionStart { get; }
        /// <summary>
        /// Represents how much money the user has at the beginning of a Roulette session.
        /// </summary>
        decimal StartingMoney { get; set; }
        /// <summary>
        /// Represents the initial BetUnit at the beginning of a Roulette session.
        /// </summary>
        decimal StartingBetUnit { get; set; }
        /// <summary>
        /// Represents how much money the user is allowed to win before the Roulette session ends (the app closes).
        /// </summary>
        decimal Goal { get; set; }
        /// <summary>
        /// Represents every number on European Roulette wheel.
        /// </summary>
        List<NumberModel> AllRouletteNumbers { get; set; }
        /// <summary>
        /// Contains data about each Round (spin) in a Roulette session. Used for undoing changes.
        /// </summary>
        List<RoundModel> AllRounds { get; set; }
        /// <summary>
        /// Represents the user who is currently playing Roulette.
        /// </summary>
        UserModel CurrentUser { get; set; }
        ISessionStart sessionStartForm { get; set; }
        IUserWon userWonForm { get; set; }



        void Close();
    }
}
