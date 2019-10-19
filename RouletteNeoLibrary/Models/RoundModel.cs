﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteNeoLibrary.Models
{
    /// <summary>
    /// Represents each round (spin) during a Roulette session. This class is used to store all data related to each round, 
    /// so it can be easer to roll back 1 step when the user clicks on the Undo button.
    /// </summary>
    public class RoundModel
    {
        /// <summary>
        /// Represents the number that just happened (the number that the ball landed on) in Roulette session.
        /// </summary>
        public byte WinningNumber { get; set; }
        /// <summary>
        /// Represents an integer value of what spin Roulette session is currently at.
        /// </summary>
        public int Spin { get; set; }
        /// <summary>
        /// Represents the List of numbers predicted by the App for each individual Round (spin).
        /// </summary>
        public List<int> ExpectedNumbers { get; set; }
        /// <summary>
        /// Represents how much money the user has at a specific Round (spin).
        /// </summary>
        public decimal Money { get; set; }
        /// <summary>
        /// Represents the user's current BetUnit for a specific Round (spin).
        /// </summary>
        public decimal BetUnit { get; set; }



        public RoundModel()
        {

        }
    }
}
