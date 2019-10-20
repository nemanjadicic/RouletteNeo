using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouletteNeoLibrary
{
    public interface ISessionStart
    {
        decimal StartMoney { get; set; }
        decimal BetUnit { get; set; }
        
        DialogResult ShowDialog();
    }
}
