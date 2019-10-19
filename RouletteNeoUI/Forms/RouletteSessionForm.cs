using RouletteNeoLibrary;
using RouletteNeoLibrary.Models;
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
    public partial class RouletteSessionForm : Form, IRouletteSession
    {
        public int SessionStart { get; } = 37;
        public decimal StartingMoney { get; set; } = 0;
        public decimal StartingBetUnit { get; set; } = 0;
        public decimal Goal { get; set; } = 0;
        public List<NumberModel> AllRouletteNumbers { get; set; } = new List<NumberModel>();
        public List<RoundModel> AllRounds { get; set; } = new List<RoundModel>();
        public UserModel CurrentUser { get; set; }




        public RouletteSessionForm()
        {
            InitializeComponent();
        }
    }
}
