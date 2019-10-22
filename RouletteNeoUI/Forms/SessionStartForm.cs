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

        protected override CreateParams CreateParams    //  Disables the close button (X).
        {
            get
            {
                CreateParams params1 = base.CreateParams;
                params1.ClassStyle |= 0x200;
                return params1;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bool startingMoneyValid = decimal.TryParse(startingMoneyValue.Text, out decimal sm);
            bool betUnitValid = decimal.TryParse(betUnitValue.Text, out decimal bu);

            if (startingMoneyValid && betUnitValid)
            {
                StartMoney = sm;
                BetUnit = bu;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Starting Money / Bet Unit. Please try again.");
            }
        }
    }
}
