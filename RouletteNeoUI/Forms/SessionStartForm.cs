using RouletteNeoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouletteNeoUI.Forms
{
    public partial class SessionStartForm : Form, ISessionStart
    {
        public decimal StartMoney { get; set; } = 0;
        public decimal BetUnit { get; set; } = 0;

        public SessionStartForm()
        {
            InitializeComponent();
        }
    }
}
