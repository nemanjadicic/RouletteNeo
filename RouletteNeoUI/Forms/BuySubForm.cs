using RouletteNeoLibrary;
using RouletteNeoLibrary.DataAccess;
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
    public partial class BuySubForm : Form
    {
        UserModel currentUser = new UserModel();

        IRouletteSession previousRouletteSession;
        
        public BuySubForm(UserModel user, IRouletteSession rouletteSessFrm)
        {
            InitializeComponent();

            currentUser = user;

            previousRouletteSession = rouletteSessFrm;

            Button[] allButtons = { oneMonthButton, sixMonthButton, yearButton };

            foreach (Button button in allButtons)
            {
                button.Click += Button_Click;
            }
        }

        private void BuySubAndOpenRouletteNeo(UserModel user, IRouletteSession rouletteSessFrm)
        {
            user.BoughtSub = true;

            SQLiteDataAccess.UpdateUserSubscription(currentUser);

            rouletteSessFrm = new RouletteSessionForm(user);
            this.Hide();
            previousRouletteSession.Close();
            rouletteSessFrm.ShowDialog();
            this.Close();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            BuySubAndOpenRouletteNeo(currentUser, previousRouletteSession);
        }
    }
}
