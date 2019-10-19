using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteNeoLibrary.Models
{
    /// <summary>
    /// Represents each number on European Roulette wheel.
    /// </summary>
    public class NumberModel
    {
        /// <summary>
        /// Represents the digit associated with a Number. 
        /// <example> Zero - 0, Twenty-seven - 27, Thirty-six - 36... </example>
        /// </summary>
        public byte Digit { get; set; }
        /// <summary>
        /// Counts how many times each Number has happened during a Roulette session.
        /// </summary>
        public int Happened { get; set; } = 0;
        /// <summary>
        /// Counts how many times each Number has not happened during a Roulette session.
        /// </summary>
        public int NotHappened { get; set; } = 0;
        /// <summary>
        /// <para>
        /// Represents the average gap between 2 instances of Number happening during a Roulette session.
        /// </para>
        /// An average of all NotHappened values for that Number.
        /// </summary>
        public float AverageGap { get; set; } = 0;
        /// <summary>
        /// Represents every NotHappened value stored in a list.
        /// </summary>
        public List<int> NotHappenedList { get; set; } = new List<int>();


        /// <summary>
        /// Created a new instance (object) of the NumberModel class. 
        /// </summary>
        /// <param name="digit">Integer value (Arabic numbers) associated with the Number we want to create.</param>
        public NumberModel(byte digit)
        {
            Digit = digit;
        }
    }
}
