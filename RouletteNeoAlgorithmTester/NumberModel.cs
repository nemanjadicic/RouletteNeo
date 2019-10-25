using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteNeoAlgorithmTester
{
    public class NumberModel
    {
        public byte Digit { get; set; }
        public int Happened { get; set; }
        public int NotHappened { get; set; }
        public float AverageGap { get; set; }
        public List<int> NotHappenedList { get; set; } = new List<int>();



        public NumberModel(byte digit)
        {
            Digit = digit;
        }
    }
}
