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
    public partial class YouWonForm : Form, IUserWon
    {
        public UserModel CurrentUser { get; set; }
        public IRouletteSession rouletteSessionForm { get; set; }

        public YouWonForm(UserModel user, IRouletteSession rouletteSessFrm)
        {
            InitializeComponent();

            CurrentUser = user;

            rouletteSessionForm = rouletteSessFrm;

            congratzUserLabel.Text = $"Congratulations {user.Username}!";
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            if (CurrentUser.BoughtSub == false)
            {
                BuySubForm buySub = new BuySubForm(CurrentUser, rouletteSessionForm);
                this.Hide();
                rouletteSessionForm.Close();
                buySub.ShowDialog();
                this.Close();
            }
            else
            {
                IRouletteSession newRouletteSession = new RouletteSessionForm(CurrentUser);
                this.Hide();
                rouletteSessionForm.Close();
                newRouletteSession.ShowDialog();
                this.Close();
            }
        }
    }
}
